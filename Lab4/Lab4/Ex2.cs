using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Lab4
{
    public partial class Ex2 : Form
    {
        public Ex2()    
        {
            InitializeComponent();
        }

        private void btn_down_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_filePath.Text) || string.IsNullOrEmpty(tb_url.Text))
            {
                MessageBox.Show("Please fill out.", "Note:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                //Khởi tạo WebClient
               WebClient myClient = new WebClient();

                // Sử dụng OpenRead để đọc nội dung trang web vào một Stream
                Stream response = myClient.OpenRead(tb_url.Text);

                // Sử dụng DownloadFile để tải xuống nội dung trang web và lưu vào tệp
                myClient.DownloadFile(tb_url.Text, tb_filePath.Text);

                string htmlContent = File.ReadAllText(tb_filePath.Text);
                rtb_res.Text = htmlContent;

                MessageBox.Show("Tải xuống thành công!", "Thông báo:", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}
