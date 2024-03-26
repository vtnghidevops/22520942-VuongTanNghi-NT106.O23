using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Ex6 : Form
    {
        public Ex6()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxDay.Text = string.Empty;
            textBoxMonth.Text = string.Empty;
            textBoxResult.Text = string.Empty;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Find_Click(object sender, EventArgs e)
        {
            int num;
            if (string.IsNullOrEmpty(textBoxDay.Text) || string.IsNullOrEmpty(textBoxMonth.Text))
            {
                MessageBox.Show("Chưa có dữ liệu vui lòng thử lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Int32.TryParse(textBoxDay.Text, out num) || !Int32.TryParse(textBoxDay.Text, out num))
            {
                MessageBox.Show("Số không hợp lệ vui lòng nhập lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int day = int.Parse(textBoxDay.Text);
            int month = int.Parse(textBoxMonth.Text);

            string zodiacSign = "";

            if ((month == 1 && day >= 21) || (month == 2 && day <= 19))
                zodiacSign = "Bảo Bình";
            else if ((month == 2 && day >= 20) || (month == 3 && day <= 20))
                zodiacSign = "Song Ngư";
            else if ((month == 3 && day >= 21) || (month == 4 && day <= 20))
                zodiacSign = "Bạch Dương";
            else if ((month == 4 && day >= 21) || (month == 5 && day <= 21))
                zodiacSign = "Kim Ngưu";
            else if ((month == 5 && day >= 22) || (month == 6 && day <= 21))
                zodiacSign = "Song Tử";
            else if ((month == 6 && day >= 22) || (month == 7 && day <= 22))
                zodiacSign = "Cự Giải";
            else if ((month == 7 && day >= 23) || (month == 8 && day <= 22))
                zodiacSign = "Sư Tử";
            else if ((month == 8 && day >= 23) || (month == 9 && day <= 23))
                zodiacSign = "Xử Nữ";
            else if ((month == 9 && day >= 24) || (month == 10 && day <= 23))
                zodiacSign = "Thiên Bình";
            else if ((month == 10 && day >= 24) || (month == 11 && day <= 22))
                zodiacSign = "Thần Nông";
            else if ((month == 11 && day >= 23) || (month == 12 && day <= 21))
                zodiacSign = "Nhân Mã";
            else
                zodiacSign = "Ma Kết";

            textBoxResult.Text = zodiacSign;
        }

        private void textBoxResult_TextChanged(object sender, EventArgs e)
        {

        }
        private void Ex6_FormClosed(object sender, FormClosedEventArgs e)
        {
            var MainForm = new MainForm();
            MainForm.Show();
        }
    }
}
