using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Net;

namespace Lab3
{
    public partial class Task2 : Form
    {
        public Task2()
        {
            InitializeComponent();
        }
        Thread TCPServer;

        private void btn_Listen_Click(object sender, EventArgs e)
        {
            TCPServer = new Thread(new ThreadStart(ServerThread));
            TCPServer.IsBackground = true;
            TCPServer.Start();
        }

        private void ServerThread()
        {
            IPEndPoint ipepServer = new IPEndPoint(IPAddress.Any, 8080);
            Socket clientSocket;
            Socket serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            int bytesReceived = 0;
            byte[] recv = new byte[1];
            while (true)
            {
                try
                {
                    serverSocket.Bind(ipepServer);
                    serverSocket.Listen(5);

                    clientSocket = serverSocket.Accept();
                    string connectInfo = "Server running on " + clientSocket.LocalEndPoint.ToString() + "\n";

                    if (!IsDisposed && InvokeRequired)
                    {
                        Invoke(new Action(() => rtb_showContent.Text = connectInfo));
                    }
                    else if (!IsDisposed)
                    {
                        rtb_showContent.Text = connectInfo;
                    }

                    while (clientSocket.Connected)
                    {
                        string returnData = "";
                        do
                        {
                            bytesReceived = clientSocket.Receive(recv);
                            if (bytesReceived == 0)
                            {
                                break;
                            }
                            returnData += Encoding.ASCII.GetString(recv);
                        } while (returnData[returnData.Length - 1] != '\n');
                        if (!IsDisposed && InvokeRequired)
                        {
                            Invoke(new Action(() => rtb_showContent.Text += returnData));
                        }
                        else if (!IsDisposed)
                        {
                            rtb_showContent.Text += returnData;
                        }
                    }
                    serverSocket.Close();
                    clientSocket.Close();
                }
                catch
                {

                }
            }
        }
    }
}
