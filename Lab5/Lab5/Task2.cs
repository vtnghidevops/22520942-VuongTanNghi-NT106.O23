using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using MailKit.Net;
using MimeKit;
using MailKit.Net.Smtp;
using System.Net.Mail;
using SmtpClient = MailKit.Net.Smtp.SmtpClient;
using Org.BouncyCastle.Bcpg;
using MailKit.Net.Imap;

namespace Lab5
{
    public partial class Task2 : Form
    {
        public Task2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string server = "imap.gmail.com";
            int port = 993;
            string username = tb_username.Text;
            string password = tb_password.Text;
            int limit = 10;

            try
            {
                using (var client = new ImapClient())
                {
                    client.Connect(server, port, true); // IMAP host, port, use SSL.
                    client.Authenticate(username, password); // Gmail account, app password.

                    var inbox = client.Inbox;
                    inbox.Open(MailKit.FolderAccess.ReadOnly);

                    int messageCount = inbox.Count;
                    int recentMessageCount = 0;

                    // Clear previous items in ListView
                    listView1.Items.Clear();

                    // Iterate from the most recent emails
                    for (int i = messageCount - 1; i >= 0 && recentMessageCount < limit; i--)
                    {
                        var message = inbox.GetMessage(i);

                        // Debug: Output the subject of each email to the console
                        Console.WriteLine($"Email {i}: {message.Subject}");

                        // Display email information in ListView: message.Subject, message.From, message.Date
                        var listViewItem = new ListViewItem(new[] { message.Subject, message.From.ToString(), message.Date.ToString() });

                        // Ensure this update is done on the UI thread
                        listView1.Invoke(new Action(() => listView1.Items.Add(listViewItem)));
                        recentMessageCount++;
                    }

                    // Update the labels on the UI thread
                    labelTotalEmails.Invoke(new Action(() => labelTotalEmails.Text = $"{messageCount}"));
                    labelRecentEmails.Invoke(new Action(() => labelRecentEmails.Text = $"{recentMessageCount}"));

                    // Debug: Output total and recent message count
                    Console.WriteLine($"Total Emails: {messageCount}");
                    Console.WriteLine($"Recent Emails with specific subject: {recentMessageCount}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Debug: Output exception message to the console
                Console.WriteLine($"Exception: {ex.Message}");
            }
        }

    }
}

