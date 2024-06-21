
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;


namespace Lab3
{
    public partial class Server : Form
    {
        private List<Socket> listSocketClientTCP; // list quản li socket khi mở cho client
        private IPEndPoint ipepServer;
        private Socket listenerSocket;
        private Dictionary<string, string> infoClient = new Dictionary<string, string>(); // Use Dictionary to store client name and IP


       
        private string ipServerBind;


        public Server()
        {
            InitializeComponent();
            StartListening();
            //ipServerBind = "192.168.137.1";
            ipServerBind = "127.0.0.1";

            //ipServerBind = "26.157.218.78";
        }

        public class UdpClientInfo
        {
            public string IPAddress { get; set; }
            public int Port { get; set; }

            public override string ToString()
            {
                return $"IPAddress: {IPAddress}, Port: {Port}";
            }
        }


        private void StartListening()
        {


            Thread tcpThread = new Thread(new ThreadStart(ListenThreadTCP));
            tcpThread.Start();


        }




        // Nào xem trước xem như là thằng này , còn lại về Receive hết
        private void ListenThreadTCP()
        {
            try
            {
                listSocketClientTCP = new List<Socket>();
                listenerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                ipepServer = new IPEndPoint(IPAddress.Parse(ipServerBind), 16333);
                // listenerSocket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true); // Thêm dòng này để tránh lỗi bind port
                listenerSocket.Bind(ipepServer);
                listenerSocket.Listen(-1);

                Invoke(new Action(() =>
                {
                    lv_ListLog.Items.Add("Sẵn sàng để trò chuyện trên địa chỉ : " + ipepServer.ToString()); // thông báo cho biết nó đang listen 
                }));

                while (true)
                {
                    Socket clientSocketTCP = listenerSocket.Accept(); // Chấp nhận kết nối và trả về cái socket mới để giao tiếp với client 
                    listSocketClientTCP.Add(clientSocketTCP); // gán socket mới mở đó để quản lí giao tiếp
                 
                    Thread receiver = new Thread(() => ReceiveDataThreadTCP(clientSocketTCP)); // mở luồng nhận dữ liệu 
                    receiver.Start();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error TCP: " + ex.Message);
            }
        }


        private void ReceiveDataThreadTCP(Socket clientSocket)
        {
            AES_256 aes = new AES_256();
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
                    else
                    {
                      

                        byte[] actualData = new byte[bytesReceived];
                        Array.Copy(recv, actualData, bytesReceived);

                        string decryptedMessage = aes.Decrypt(actualData);
                        string listViewString = clientSocket.RemoteEndPoint.ToString() + ": " + decryptedMessage;

                        Invoke(new Action(() =>
                        {
                            lv_ListLog.Items.Add(listViewString);
                        }));

                        Broadcast(decryptedMessage); // lan truyền tới mấy thằng đang mở room
                    }

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
            listSocketClientTCP.Remove(clientSocket);
            Invoke(new Action(() =>
            {
                lv_ListLog.Items.Add("Client Disconnected: " + clientSocket.RemoteEndPoint.ToString());
            }));
        }

        private void Broadcast(string msg)
        {
            AES_256 aes = new AES_256();

            foreach (Socket clientSocket in listSocketClientTCP)
            {
                try
                {
                    byte[] encryptedData = aes.Encrypt(msg);
                    clientSocket.Send(encryptedData);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error sending message: " + ex.Message);
                }
            }
        }

        private void Task_6_Server_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (listenerSocket != null && listenerSocket.Connected)
            {
                listenerSocket.Close();
            }
            foreach (var client in listSocketClientTCP)
            {
                if (client != null && client.Connected)
                {
                    client.Close();
                }
            }
        }

        private void btn__sendClient_Click(object sender, EventArgs e)
        {
            
            string message = tb__msgToClient.Text;
            if (!string.IsNullOrEmpty(message))
            {
                // Encrypt and broadcast the message
                Broadcast("Server: " + message);
                tb__msgToClient.Clear();

                // Update lv__ListLog when sending a message (Sender)
                Invoke(new Action(() =>
                {
                    lv_ListLog.Items.Add("You: " + message);
                }));
            }
        }



        private void AddClientInfo(string username, string clientIp)
        {
            infoClient[username] = clientIp; // Add client name and IP to the dictionary
        }

      

    }
}
