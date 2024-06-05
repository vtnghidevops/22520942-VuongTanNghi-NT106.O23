using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit.Net.Pop3;

namespace Lab5
{
    public partial class Task3 : Form
    {
        public Task3()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string server = "pop.gmail.com";
            int port = 995;
            string username = tb_username.Text;
            string password = tb_password.Text;
            int limit = 10;

            try
            {
                using (var client = new Pop3Client())
                {
                    client.Connect(server, port, true); // pop host, port, use ssl.
                    client.Authenticate(username, password); // gmail accout, app password.

                    int messageCount = client.Count;
                    int recentMessageCount = Math.Min(limit, messageCount);

                    for (int i = messageCount - 1; i >= Math.Max(0, messageCount - limit); i--)
                    {
                        var message = client.GetMessage(i);
                        // Hiển thị thông tin email lên ListView: message.Subject, message.From, message.Date
                        var listViewItem = new ListViewItem(new[] { message.Subject, message.From.ToString(), message.Date.ToString() });
                        listView1.Items.Add(listViewItem);
                    }

                    // Hiển thị tổng số lượng email và số lượng email gần đây trên các nhãn
                    labelTotalEmails.Text = $"{messageCount}";
                    labelRecentEmails.Text = $"{recentMessageCount}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
