
using System;
using System.Collections;
using System.Drawing.Imaging;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Security.Cryptography;

namespace Lab3
{
    public partial class Client : Form
    {



        private TcpClient tcpClient;
        private NetworkStream ns;
        //private Thread updateUIThread;
        private string clientName;
        private Dictionary<string, TcpClient> clients;





        public Client()
        {
            InitializeComponent();
            clients = new Dictionary<string, TcpClient>();


        }



        private void btn_Connect_Click(object sender, EventArgs e)
        {
            ConnectToServerChat();


        }

        private void ConnectToServerChat()
        {
            try
            {
                tcpClient = new TcpClient(); 
                tcpClient.Connect(IPAddress.Parse(tb_ipServer.Text), 16333); 
                ns = tcpClient.GetStream(); 
                Thread receiver = new Thread(ReceiveFromServerTCP);

                receiver.Start();
                btn_Connect.Enabled = false;
                clientName = tb_NameOfClient.Text;

                // Gửi tên client vừa connect lên server 
                string notiConnectToServer = $"{clientName} đã vào phòng, bây giờ các bạn có thể nhắn tin riêng hoặc chung, video với nhau";
                SendMess(notiConnectToServer);
                clients[clientName] = tcpClient; // Thêm client vào danh sách



                // Hiển thị thông báo "Kết nối server thành công" trên client
                MessageBox.Show("Kết nối server thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Client: " + ex.Message);
            }
        }


        // Thường khi nhận bất kì gì từ server thì nó luôn phải nhận dạng bytes
        private void ReceiveFromServerTCP()
        {
            AES_256 aes = new AES_256();
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024];
                    int bytesRead = ns.Read(data, 0, data.Length);

                    if (bytesRead > 0)
                    {
                        byte[] actualData = new byte[bytesRead];
                        Array.Copy(data, actualData, bytesRead);

                        string message = aes.Decrypt(actualData);
                        Invoke(new Action(() =>
                        {
                            lv_messageLog.Items.Add(message);
                        }));
                    }
                    else
                    {
                        MessageBox.Show("Error Receive Data From Server !");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void btn_SendMessage_Click(object sender, EventArgs e)
        {
            string message = tb_Message.Text; // Tin nhắn muốn gửi
            SendMess($"{clientName}: " + message);

        }

        private void SendMess(string text)
        {

            AES_256 aes = new AES_256();
            byte[] encryptedData = aes.Encrypt(text);
            ns.Write(encryptedData, 0, encryptedData.Length);
            tb_Message.Text = ""; // Clear the message textbox
        }


        private void CloseClient()
        {
            if (tcpClient != null)
            {
                tcpClient.Close();
            }
            clients.Remove(clientName); // Xóa client khỏi danh sách
        }

        private void Task_6_Client_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseClient();
        }

        private void lv_messageLog_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void Client_Load(object sender, EventArgs e)
        {

        }

    }
}
