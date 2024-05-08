using System;
using System.Net.Sockets;
using System.Net;
using System.Windows.Forms;
using System.Threading;

namespace Lab03
{
    public partial class Bai03_Client : Form
    {
        public Bai03_Client()
        {
            InitializeComponent();
        }
        B3_Client client;
        private void btnSend_Click(object sender, EventArgs e)
        {
            string message = txtSend.Text;
            client.Send(message);
            txtSend.Text = "";
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                client = new B3_Client();
                client.Connect();
                btnSend.Enabled = true;
                btnConnect.Enabled = false;
                btnDisconnect.Enabled = true;
            }
            catch (System.Net.Sockets.SocketException)
            {
                MessageBox.Show("Không thể kết nối server.", "Notice");
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            client.Disconnect();
            btnSend.Enabled = false;
            btnConnect.Enabled = true;
            btnDisconnect.Enabled = false;
        }

        private void btnSend_Enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSend_Click(sender, e);
            }
        }

        private void btnSend_Click_1(object sender, EventArgs e)
        {
            string message = txtSend.Text;
            client.Send(message);
            txtSend.Text = "";
        }
    }
    class Client
    {
        int serverport = 8888;
        IPAddress serverAddr = IPAddress.Parse("127.0.0.1");
        TcpClient client = new TcpClient();

        public void Connect()
        {
            client.Connect(serverAddr, serverport);
        }
        public void Send(string message)
        {
            byte[] data = System.Text.Encoding.UTF8.GetBytes(message);
            NetworkStream stream = client.GetStream();
            stream.Write(data, 0, data.Length);
        }
        public void Disconnect()
        {
            client.Close();
        }
    }
    class B3_Client
    {
        int serverport = 8888;
        IPAddress serverAddr = IPAddress.Parse("127.0.0.1");
        TcpClient client = new TcpClient();

        public void Connect()
        {
            client.Connect(serverAddr, serverport);
        }
        public void Send(string message)
        {
            byte[] data = System.Text.Encoding.UTF8.GetBytes(message);
            NetworkStream stream = client.GetStream();
            stream.Write(data, 0, data.Length);
        }
        public void Disconnect()
        {
            client.Close();
        }
    }
}
