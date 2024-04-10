namespace Lab2
{
    public partial class Ex1 : Form
    {
        public Ex1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Mở đường dẫn file
                OpenFileDialog ofd = new OpenFileDialog();
                // Chỉ định chọn file định dạng file đuôi .txt
                ofd.Filter = "Text File|*.txt";
                // Check liệu lấy đường dẫn thành công và nhấn oke trên ofd dialog chưa
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    // Tạo file or Mở file tại đường dẫn đã chọn
                    FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
                    // Đọc file và ghi kết quả
                    StreamReader sr = new StreamReader(fs);
                    rtb_Result.Text += sr.ReadToEnd();
                    fs.Close();
                    MessageBox.Show($"Read successfully from {ofd.FileName}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }else
                {
                    MessageBox.Show("Can not open file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btn_Write_Click(object sender, EventArgs e)
        {
            // Lấy đường dẫn để lưu file để ghi
            SaveFileDialog sfDialog = new SaveFileDialog();
            sfDialog.Filter = "Text File|*.txt";
            // Check liệu lấy đường dẫn thành công và nhấn oke trên sfDia dialog chưa
            if (sfDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(sfDialog.FileName, FileMode.OpenOrCreate);
                // Ghi vào file có đường dẫn được lấy từ sfDialog
                StreamWriter sw = new StreamWriter(fs);
                // Chuyển sang in Hoa 
                sw.Write(rtb_Result.Text.ToUpper());
                //Đảm bảo rằng tất cả dữ liệu đang chờ trong bộ đệm của luồng sw được ghi xuống đích
                sw.Flush();
                fs.Close();
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Ex1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Restore_Click(object sender, EventArgs e)
        {
            // Xóa giá trị trong richTextBox mỗi lần click vào ĐỌC FILE
            rtb_Result.Clear();
        }

        private void Ex1_FormClosed(object sender, FormClosedEventArgs e)
        {
            var MainForm = new MainForm();
            MainForm.Show();
        }
    }
}
