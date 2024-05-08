using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Task1_Server : Form
    {
        public Task1_Server()
        {
            InitializeComponent();
        }

        

        private void serverThread()
        {
            
            UdpClient udpClient = new UdpClient(int.Parse(tb_PortListen.Text));
            while (true)
            {
                IPEndPoint remoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);
                Byte[] receiveByte = udpClient.Receive(ref remoteIpEndPoint);
                string returnData = Encoding.UTF8.GetString(receiveByte);
                string msg = remoteIpEndPoint.Address.ToString() + " : " + returnData.ToString();
                rtb_ReceivedMessage.AppendText(msg + '\n');
            }
        }

        private void btn_ServerListen_Click(object sender, EventArgs e)
        {
            if (tb_PortListen == null)
            {
                MessageBox.Show("Hãy nhập số port");
            }
            else
            {
                CheckForIllegalCrossThreadCalls = false;
                Thread thdUDPServer = new Thread(new ThreadStart(serverThread));
                thdUDPServer.Start();
            }
        }
    }
}
