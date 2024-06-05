using MailKit;
using MailKit.Net.Imap;
using MimeKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.Web.WebView2.WinForms;
using Microsoft.Web.WebView2.Wpf;
using System.Net.Mail;
using System.Net;
using Org.BouncyCastle.Math.Field;

namespace Lab5
{
    public partial class Task5 : Form
    {
        public Task5()
        {
            InitializeComponent();
        }
        private async void btn_SignIn_Click(object sender, EventArgs e)
        {
            if (btn_SignIn.Tag == "1")
            {
                ShowListView();
            }
            else if (btn_SignIn.Tag == "2")
            {
                SignOut();
            }
        }
        private void SignOut()
        {
            btn_Send.Visible = false;
            btn_Refresh.Visible = false;
            btn_SignIn.Text = "Đăng nhập";
            listView1.Items.Clear();
            btn_SignIn.Tag = "1";
        }
        private async void ShowListView()
        {

            string server = tbx_IMAP.Text;
            if (!int.TryParse(domainUpDown1.Text, out int port))
            {
                MessageBox.Show("Invalid port number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string username = tbx_account.Text;
            string password = tbx_password.Text;
            int limit = 30;

            try
            {
                using (var client = new ImapClient())
                {
                    var loadingMessage = new Label
                    {
                        Text = "Loading emails, please wait...",
                        AutoSize = true,
                        Location = new System.Drawing.Point(10, 10)
                    };
                    this.Controls.Add(loadingMessage);
                    loadingMessage.BringToFront();
                    loadingMessage.Refresh();

                    await client.ConnectAsync(server, port, true); // imap host, port, use ssl.
                    await client.AuthenticateAsync(username, password); // gmail account, app password.

                    MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    btn_Send.Visible = true;
                    btn_Refresh.Visible = true;
                    btn_SignIn.Text = "Đăng xuất";
                    btn_SignIn.Tag = "2";

                    var inbox = client.Inbox;
                    await inbox.OpenAsync(FolderAccess.ReadOnly);

                    int messageCount = inbox.Count;
                    int recentMessageCount = Math.Min(limit, messageCount);

                    listView1.Items.Clear(); // Clear existing items in the ListView

                    for (int i = 0; i < recentMessageCount; i++)
                    {
                        var message = await inbox.GetMessageAsync(i);
                        // Display email information in ListView: message.Subject, message.From.ToString(), message.Date.ToString()
                        var listViewItem = new ListViewItem(new[] { message.Subject, message.From.ToString(), message.Date.ToString() })
                        {
                            Tag = message // Store the entire message in the Tag property
                        };
                        listView1.Items.Add(listViewItem);
                    }

                    await client.DisconnectAsync(true);
                    this.Controls.Remove(loadingMessage);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                // Get the selected email
                var selectedItem = listView1.SelectedItems[0];
                var message = (MimeMessage)selectedItem.Tag;

                // Populate the controls with email details
                lblFrom.Text = "From: " + string.Join(", ", message.From.Select(f => f.ToString()));
                lblTo.Text = "To: " + string.Join(", ", message.To.Select(t => t.ToString()));
                lblSubject.Text = "Subject: " + message.Subject;
                richTextBox1.Text = message.TextBody;

                var imageParts = message.BodyParts.OfType<MimePart>().Where(part => part.IsAttachment && part.ContentType.MimeType.StartsWith("image/"));

                if (imageParts.Any())
                {
                    pictureBox1.Visible = true;
                    var imagePart = imageParts.First();
                    using (var stream = new MemoryStream())
                    {
                        imagePart.Content.DecodeTo(stream);
                        stream.Position = 0;
                        pictureBox1.Image = Image.FromStream(stream);
                    }
                }
                else
                {
                    pictureBox1.Image = null; // Clear the PictureBox if no images are found
                }

                // Make the panel visible
                pn_readmail.Visible = true;
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            pn_readmail.Visible = false;
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            ;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string fromEmail = tbx_account.Text;
            string password = tbx_password.Text;
            string toEmail = tbToMail.Text;

            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
            smtpClient.Port = 587;
            smtpClient.EnableSsl = true;
            smtpClient.Credentials = new NetworkCredential(fromEmail, password);

            MailMessage mailMessage = new MailMessage(fromEmail, toEmail);
            mailMessage.Subject = tbSubject.Text;
            mailMessage.Body = rtbBody.Text;
            mailMessage.IsBodyHtml = false; // Set to true if you are sending HTML email

            foreach (string filePath in attachmentFilePaths)
            {
                Attachment attachment = new Attachment(filePath);
                mailMessage.Attachments.Add(attachment);
            }

            try
            {
                smtpClient.Send(mailMessage);
                MessageBox.Show("Email sent successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                attachmentFilePaths.Clear(); // Clear attachments after sending
                linkLabel1.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to send email. Error message: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Send_Click_1(object sender, EventArgs e)
        {
            //listView1.Visible = false;
            pn_SendMail.Visible = true; pn_readmail.Visible = false;
        }

        private void btn_Back2_Click(object sender, EventArgs e)
        {
            tbToMail.Text = "";
            tbSubject.Text = "";
            rtbBody.Text = "";
            pn_SendMail.Visible = false;
            listView1.Visible = true;
        }

        private void btn_Reply_Click(object sender, EventArgs e)
        {
            if (pn_SendMail.Visible == false)
            {
                if (listView1.SelectedItems.Count > 0)
                {
                    // Get the selected email
                    var selectedItem = listView1.SelectedItems[0];
                    var message = (MimeMessage)selectedItem.Tag;

                    // Extract email addresses from the "From" field
                    var emailAddresses = message.From.Mailboxes.Select(mb => mb.Address).ToList();
                    tbToMail.Text = string.Join(", ", emailAddresses); // Set To field to the extracted email addresses

                    tbSubject.Text = "Re: " + message.Subject; // Prefix the subject with "Re: "
                    rtbBody.Text = "\n\n\n--------------------------------\n" +
                                    "From: " + string.Join(", ", message.From.Select(f => f.ToString())) + "\n" +
                                    "To: " + string.Join(", ", message.To.Select(t => t.ToString())) + "\n" +
                                    "Date: " + message.Date.ToString() + "\n" +
                                    "Subject: " + message.Subject + "\n\n" +
                                    message.TextBody; // Include original message

                    // Switch to the send mail panel
                    pn_SendMail.Visible = true;
                    pn_readmail.Visible = false;
                    listView1.Visible = false;
                }
            }
            else if (pn_SendMail.Visible = true)
            {
                pn_SendMail.Visible = false;
                listView1.Visible = true;
                ShowListView();
            }
        }
        private List<string> attachmentFilePaths = new List<string>();
        private void btn_attach_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Multiselect = true;
                openFileDialog.Filter = "All Files (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    foreach (string fileName in openFileDialog.FileNames)
                    {
                        attachmentFilePaths.Add(fileName);
                    }

                    MessageBox.Show("Files attached successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    linkLabel1.Text = string.Join("\n", attachmentFilePaths); // Display the file paths in the link label
                }
            }
        }

        private void rtbBody_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
