using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public partial class Task1 : Form
    {
        public Task1()
        {
            InitializeComponent();
        }

        private void btn_SEND_Click(object sender, EventArgs e)
        {
            string fromEmail = tbFromMail.Text;
            string password = tbPassword.Text;
            string toEmail = tbToMail.Text;


            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
            smtpClient.Port = 465;
            smtpClient.EnableSsl = true;
            smtpClient.Credentials = new NetworkCredential(fromEmail, password);


            MailMessage mailMessage = new MailMessage(fromEmail, toEmail);
            mailMessage.Subject = tbSubject.Text;
            mailMessage.Body = rtbBody.Text;

            try
            {
                smtpClient.Send(mailMessage);
                MessageBox.Show("Email sent successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to send email. Error message: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
