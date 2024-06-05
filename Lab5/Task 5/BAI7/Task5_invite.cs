using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LAB4.BAI7.Task5_emailSetting;

namespace LAB4.BAI7
{
    public partial class Task5_invite : Form
    {
        private DataGridViewRow dgvr;
        public Task5_invite(DataGridViewRow dgvr)
        {
            InitializeComponent();
            this.dgvr = dgvr;
            DisplayData();
        }
        private void DisplayData()
        {
            if (dgvr != null && dgvr.Cells.Count >= 5)
            {
                if (dgvr.Cells[1].Value != null && dgvr.Cells[1].Value is Image)
                {
                    pictureBox1.Image = (Image)dgvr.Cells[1].Value;
                }

                label8.Text = dgvr.Cells[2].Value?.ToString();
                label5.Text = dgvr.Cells[3].Value?.ToString();
                label6.Text = dgvr.Cells[4].Value?.ToString();
                label7.Text = dgvr.Cells[5].Value?.ToString();
            }
        }



        private void btn_addMailAddr_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_MailAddress.Text))
            {
                MessageBox.Show("Hãy nhập email! ");
                return;
            }
            else
            {
                string email = tb_MailAddress.Text;
                rtb_ListEmail.Text += email + '\n';
                tb_MailAddress.Text = null;
            }
        }

        private void Task5_invite_Load(object sender, EventArgs e)
        {


        }

        private void btn_Preview_Click(object sender, EventArgs e)
        {
            Task5_Preview preview = new Task5_Preview(dgvr);
            preview.ShowDialog();
        }

        public static class EmailHelper
        {
            public static void SendEmail(string senderEmail, string senderPassword, List<string> receiverEmails, string subject, string body, bool isHtml = false)
            {
                try
                {
                    using (SmtpClient client = new SmtpClient())
                    {
                        client.Port = 587;
                        client.DeliveryMethod = SmtpDeliveryMethod.Network;
                        client.UseDefaultCredentials = false;
                        client.Credentials = new NetworkCredential(senderEmail, senderPassword);
                        client.Host = "smtp.gmail.com";
                        client.EnableSsl = true;
                        foreach (string receiverEmail in receiverEmails)
                        {
                            using (MailMessage mail = new MailMessage(senderEmail, receiverEmail))
                            {
                                mail.Subject = subject;
                                mail.Body = body;
                                mail.IsBodyHtml = isHtml;
                                client.Send(mail);
                            }
                        }
                    }
                    MessageBox.Show("Gửi thành công email!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi gửi email" + ex.Message);
                }
            }
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(rtb_ListEmail.Text))
            {
                MessageBox.Show("Hãy nhập email người nhận! ");
                return;
            }
            else
            {
                string[] emails = rtb_ListEmail.Text.Split('\n');
                List<string> receiverEmails = new List<string>();
                foreach (string email in emails)
                {
                    if(!string.IsNullOrEmpty(email))
                    {
                        receiverEmails.Add(email.Trim());
                    }
                }
                string foodname = dgvr.Cells[2].Value?.ToString();
                string price = dgvr.Cells[3].Value?.ToString();
                string address = dgvr.Cells[4].Value?.ToString();
                string img = dgvr.Cells[1].Value?.ToString();
                string htmlBody = "<!DOCTYPE html>" +
                     "<html>" +
                    "<head>" +
                    "<title> Món ăn </title>" +
                    "<style>" +
                    "body {" +
                    "text-align: center;" +
                    "font-family: Arial, sans-serif;" +
                    "}" +
                    "h1 {" +
                    "font-size: 36px;" +
                    "margin-bottom: 10px;" +
                    "color: red" +
                    "}" +
                    "p {" +
                    "font-size: 18px;" +
                    "margin-bottom: 5px;" +
                    "}" +
                    "small {" +
                    "font-size: 14px;" +
                    "color: gray;" +
                    "}" +
                    "</style>" +
                    "</head>" +
                    "<body>" +
                    $"<img src={img} width=300 height=300>" +
                    $"<h1>{foodname}</h1>" +
                    $"<p>{price}</p>" +
                    $"<small>{address}</small>" +
                    "</body>" +
                    "</html>";
                EmailHelper.SendEmail(Email, Password, receiverEmails, "Mời bạn đến nhé !", htmlBody, true);
            }
        }

        private void btn_CheckConnect_Click(object sender, EventArgs e)
        {
            if(Email != null && Password != null && IMAPServer != null && SMTPServer != null)
            {
                label_connectStatus.Text = "Server Connected !";
                label_connectStatus.ForeColor = Color.Green;
            }
            else
            {
                label_connectStatus.Text = "Server Disconnected !";
                label_connectStatus.ForeColor = Color.Red; 
            }
        }
    }
}
