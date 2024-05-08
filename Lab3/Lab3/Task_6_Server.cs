using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Task_6_Server : Form
    {
        private List<Socket> listClient;
        private IPEndPoint ipepServer;
        private Socket listenerSocket;
        private Thread listenThread;

        public Task_6_Server()
        {
            InitializeComponent();
        }

        private void btn_Listen_Click(object sender, EventArgs e)
        {
            StartListening();
        }

        private void StartListening()
        {
            if (listenThread == null || !listenThread.IsAlive)
            {
                listenThread = new Thread(ListenThread);
                listenThread.Start();
                btn_Listen.Enabled = false;
                btn_Listen.Text = "Listening...";
            }
        }

        private void ListenThread()
        {
            try
            {
                listClient = new List<Socket>();
                listenerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                ipepServer = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
                listenerSocket.Bind(ipepServer);
                listenerSocket.Listen(10); // Specify the maximum number of connections

                Invoke(new Action(() =>
                {
                    lv_ListLog.Items.Add("Listening on : " + ipepServer.ToString());
                }));

                while (true)
                {
                    Socket clientSocket = listenerSocket.Accept();
                    listClient.Add(clientSocket);
                    string welcomeMsg = "Message From Server: Hi, Welcome to Room Chat!";
                    SendMess(welcomeMsg, clientSocket);
                    Invoke(new Action(() =>
                    {
                        lv_ListLog.Items.Add("New Client Connected: " + clientSocket.RemoteEndPoint.ToString());
                    }));

                    Thread receiver = new Thread(() => ReceiveDataThread(clientSocket));
                    receiver.Start();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ReceiveDataThread(Socket clientSocket)
        {
            try
            {
                byte[] recv = new byte[1024];
                while (true)
                {
                    int bytesReceived = clientSocket.Receive(recv);
                    if (bytesReceived == 0)
                    {
                        // Client disconnected
                        CloseClientConnection(clientSocket);
                        return;
                    }
                    string msg = Encoding.UTF8.GetString(recv, 0, bytesReceived);
                    string listViewString = clientSocket.RemoteEndPoint.ToString() + ": " + msg;
                    Invoke(new Action(() =>
                    {
                        lv_ListLog.Items.Add(listViewString);
                    }));
                    Broadcast(msg);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void CloseClientConnection(Socket clientSocket)
        {
            clientSocket.Close();
            listClient.Remove(clientSocket);
            Invoke(new Action(() =>
            {
                lv_ListLog.Items.Add("Client Disconnected: " + clientSocket.RemoteEndPoint.ToString());
            }));
        }

        private void Broadcast(string msg)
        {
            foreach (var item in listClient)
            {
                SendMess(msg, item);
            }
        }

        private void SendMess(string mess, Socket client)
        {
            byte[] data = Encoding.UTF8.GetBytes(mess);
            client.Send(data);
        }

        private void Task_6_Server_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (listenerSocket != null && listenerSocket.Connected)
            {
                listenerSocket.Close();
            }
            foreach (var client in listClient)
            {
                if (client != null && client.Connected)
                {
                    client.Close();
                }
            }
        }
    }
}
