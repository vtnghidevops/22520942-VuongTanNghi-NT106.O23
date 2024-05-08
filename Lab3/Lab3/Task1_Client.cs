using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace Lab3
{
    public partial class Task1_Client : Form
    {
        public Task1_Client()
        {
            InitializeComponent();
        }

        private void btn_ClientSend_Click(object sender, EventArgs e)
        {
            //Tao ket noi UDP
            UdpClient udpClient = new UdpClient();
            string msg = rtb_Message.Text;
            //Chuyen message sang bytes
           
            if(msg == null)
            {
                MessageBox.Show("Hãy nhập thông điệp!");
            }
            else
            {
                Byte[] sendBytes = Encoding.UTF8.GetBytes(msg);
                udpClient.Send(sendBytes, sendBytes.Length, tb_IPHost.Text, Int32.Parse(tb_HostPort.Text));
            }
        }  

        
    }
}
