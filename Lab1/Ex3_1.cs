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
    public partial class Ex3_1 : Form
    {

        private static string[] ones = { "", "Một", "Hai", "Ba", "Bốn", "Năm", "Sáu", "Bảy", "Tám", "Chín" };
        private static string[] tens = { "", "Mười", "Hai mươi", "Ba mươi", "Bốn mươi", "Năm mươi", "Sáu mươi", "Bảy mươi", "Tám mươi", "Chín mươi" };
        private static string[] hundreds = { "Không Trăm", "Một trăm", "Hai trăm", "Ba trăm", "Bốn trăm", "Năm trăm", "Sáu trăm", "Bảy trăm", "Tám trăm", "Chín trăm" };
        private static string[] thousands = { "", "Ngàn", "Triệu", "Tỷ" };

        public Ex3_1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num;
            if (string.IsNullOrEmpty(textBoxInput.Text))
            {
                MessageBox.Show("Chưa có dữ liệu vui lòng thử lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Double.TryParse(textBoxInput.Text, out num))
            {
                MessageBox.Show("Số không hợp lệ vui lòng nhập lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string numInput = textBoxInput.Text;
            string res = "";
            int length = numInput.Length;
            if (numInput[0] == '-')
            {
                res += "Âm ";
                for (int i = 1; i < length; i++)
                {
                    int digit = int.Parse(numInput[i].ToString());
                    if ((length - i) % 3 == 0)
                    {
                        res += hundreds[digit] + " ";
                    }
                    else if ((length - i) % 3 == 2)
                    {
                        res += tens[digit] + " ";
                    }
                    else
                    {
                        res += ones[digit] + " ";
                        if ((length - i - 1) / 3 > 0)
                        {
                            res += thousands[(length - i - 1) / 3] + ", ";
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < length; i++)
                {
                    int digit = int.Parse(numInput[i].ToString());
                    if ((length - i) % 3 == 0)
                    {
                        res += hundreds[digit] + " ";
                    }
                    else if ((length - i) % 3 == 2)
                    {
                        res += tens[digit] + " ";
                    }
                    else
                    {
                        res += ones[digit] + " ";
                        if ((length - i - 1) / 3 > 0)
                        {
                            res += thousands[(length - i - 1) / 3] + ", ";
                        }
                    }
                }
            }

            textBoxResult.Text = res;
        }

        private void textBoxInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Restore_Click(object sender, EventArgs e)
        {
            textBoxInput.Text = string.Empty;
            textBoxResult.Text = string.Empty;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Ex3_1_FormClosed(object sender, FormClosedEventArgs e)
        {
            var MainForm = new MainForm();
            MainForm.Show();
        }
    }
}
