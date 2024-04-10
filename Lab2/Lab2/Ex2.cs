using System;
using System.Drawing;
using System.IO;
using System.Security.Policy;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Ex2 : Form
    {
        public Ex2()
        {
            InitializeComponent();
        }

        
        private void btn_Read_Click(object sender, EventArgs e)
        {
            // Mở hộp thoại để chọn file
            OpenFileDialog ofd = new OpenFileDialog();
            // Chỉ cho phép chọn các file có định dạng .txt
            ofd.Filter = "Text File|*.txt";
            try
            {
                // Nếu người dùng chọn một file và nhấn OK
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    // Mở file và tạo một đối tượng StreamReader để đọc dữ liệu
                    FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
                    StreamReader sr = new StreamReader(fs);

                    // Hiển thị tên file đã chọn lên TextBox textBox_FileName
                    textBox_FileName.Text = ofd.SafeFileName.ToString();
                    // Hiển thị đường dẫn file đã chọn lên TextBox textBox_URL
                    textBox_URL.Text = ofd.FileName.ToString();
                    // Đọc nội dung của file và hiển thị lên RichTextBox rtb_Result
                    rtb_Result.Text = sr.ReadToEnd();

                    // Lấy thông tin về kích thước của file
                    FileInfo f = new FileInfo(ofd.FileName);
                    // Hiển thị kích thước file lên TextBox textBox_Size
                    textBox_Size.Text = f.Length.ToString() + " bytes";

                    // Đếm số dòng trong file và hiển thị lên TextBox textBox_LineCount
                    string[] arr = rtb_Result.Text.Split("\n");
                    textBox_LineCount.Text = arr.Length.ToString();

                    // Đếm số từ trong file và hiển thị lên TextBox textBox_WordCount
                    arr = rtb_Result.Text.Split(new Char[] { ' ', '\n' });
                    textBox_WordCount.Text = arr.Length.ToString();

                    // Đếm số ký tự trong file và hiển thị lên TextBox textBox_CharCount
                    string s1 = rtb_Result.Text.Replace("\r\n", "");
                    s1 = s1.Replace(" ", "");
                    textBox_CharCount.Text = s1.Length.ToString();

                    // Đóng file sau khi đọc xong
                    fs.Close();

                    // Thông báo đọc file thành công
                    MessageBox.Show($"Read successfully from {ofd.FileName}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Thông báo không thể mở file nếu người dùng không chọn file hoặc nhấn Cancel
                    MessageBox.Show("Can not open file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi nếu có lỗi xảy ra trong quá trình đọc file
                MessageBox.Show("An error occurred while loading the file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Ex2_FormClosed(object sender, FormClosedEventArgs e)
        {
            var MainForm = new MainForm();
            MainForm.Show();
        }
    }
}
