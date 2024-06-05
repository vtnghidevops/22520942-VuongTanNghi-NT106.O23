using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using MailKit.Net.Imap;
using System.Linq.Expressions;
using Newtonsoft.Json;

namespace LAB4.BAI7
{
    public partial class Task5_emailSetting : Form
    {
        public Task5_emailSetting()
        {
            InitializeComponent();
        }

        public class Config
        {
            public string Email { get; set; }
            public string Password { get; set; }
            public string IMAPServer { get; set; }
            public string SMTPServer { get; set; }
        }

        public static string Email;
        public static string Password;
        public static string IMAPServer;
        public static string SMTPServer;

        private void btn_TestConnect_Click(object sender, EventArgs e)
        {
            if (tb_Username == null || tb_PassWord == null)
            {
                MessageBox.Show("Hãy nhập đầy đủ Username và Password!");
                return;
            }
            try
            {
                using (var client = new MailKit.Net.Imap.ImapClient())
                {
                    client.Connect(tb_IMAP.Text, 993, true);
                    client.Authenticate(tb_Username.Text, tb_PassWord.Text);
                    MessageBox.Show("Kết nối IMAP thành công!");
                }
                using (var client = new MailKit.Net.Smtp.SmtpClient())
                {
                    client.Connect(tb_SMPT.Text, 465, true);
                    client.Authenticate(tb_Username.Text, tb_PassWord.Text);
                    MessageBox.Show("Kết nối SMTP thành công!");
                }
                Email = tb_Username.Text;
                Password = tb_PassWord.Text;
                IMAPServer = tb_IMAP.Text;
                SMTPServer = tb_SMPT.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kết nối không thành công! Lỗi: " + ex.Message);
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(tb_NickName.Text) || string.IsNullOrEmpty(tb_PassWord.Text) || string.IsNullOrEmpty(tb_IMAP.Text)||string.IsNullOrEmpty(tb_SMPT.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                    return;
                }
                //Tao config luu thong tin cau hinh
                Config config = new Config
                {
                    Email = tb_Username.Text,
                    Password = tb_PassWord.Text,
                    IMAPServer = tb_IMAP.Text,
                    SMTPServer = tb_SMPT.Text,
                };
                //Luu doi tuong config vao file cau hinh json
                string jsonConfig = JsonConvert.SerializeObject(config);
                File.WriteAllText("config.json", jsonConfig);
                MessageBox.Show("Lưu thành công!");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi lưu cấu hình! " + ex.Message);
            }
        }
    }
}
