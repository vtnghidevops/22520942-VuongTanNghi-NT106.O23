using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Task_6_Client : Form
    {
        private TcpClient tcpClient;
        private NetworkStream ns;
        private Thread updateUIThread;
        private string clientName;

        public Task_6_Client()
        {
            InitializeComponent();
        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            ConnectToServer();
        }

        private void ConnectToServer()
        {
            try
            {
                tcpClient = new TcpClient();
                tcpClient.Connect(IPAddress.Parse("127.0.0.1"), 8080);
                ns = tcpClient.GetStream();
                Thread receiver = new Thread(ReceiveFromServer);
                receiver.Start();
                btn_Connect.Enabled = false;
                clientName = tb_NameOfClient.Text.Trim(); // Get the client name from the textbox
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ReceiveFromServer()
        {
            try
            {
                byte[] recv = new byte[1024];
                while (true)
                {
                    int bytesReceived = ns.Read(recv, 0, recv.Length);
                    if (bytesReceived == 0)
                    {
                        // Server disconnected
                        MessageBox.Show("Server disconnected");
                        CloseClient();
                        return;
                    }
                    string text = Encoding.UTF8.GetString(recv, 0, bytesReceived);
                    UpdateUIThread(text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                CloseClient();
            }
        }

        private void UpdateUIThread(string text)
        {
            if (lv_messageLog.InvokeRequired)
            {
                lv_messageLog.Invoke(new Action<string>(UpdateUIThread), text);
            }
            else
            {
                lv_messageLog.Items.Add(text); // Include client's name in the message
            }
        }

        private void btn_SendMessage_Click(object sender, EventArgs e)
        {
            SendMess(tb_Message.Text);
        }

        private void SendMess(string text)
        {
            string fullMessage = clientName + ": " + text; // Include client's name in the message
            byte[] data = Encoding.UTF8.GetBytes(fullMessage);
            ns.Write(data, 0, data.Length);
            tb_Message.Text = ""; // Clear the message textbox
        }

        private void CloseClient()
        {
            if (tcpClient != null)
            {
                tcpClient.Close();
            }
        }

        private void Task_6_Client_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseClient();
        }
    }
}
