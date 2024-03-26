using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Ex5 : Form
    {
        public static BigInteger Factorial(int n)
        {
            BigInteger result = 1;

            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
        public static long Sum(int a, int b)
        {
            return Enumerable.Range(1, b).Select(i => (long)Math.Pow(a, i)).Sum();
        }
        public Ex5()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Restore_Click(object sender, EventArgs e)
        {
            textBoxInput1.Text = string.Empty;
            textBoxInput2.Text = string.Empty;
            textBoxResult.Text = string.Empty;
            comboBox1.Text = string.Empty;



        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Cal_Click(object sender, EventArgs e)
        {
            int num1, num2;
            
            if (string.IsNullOrEmpty(textBoxInput1.Text) || string.IsNullOrEmpty(textBoxInput2.Text))
            {
                MessageBox.Show("Chưa có dữ liệu, Vui lòng nhập lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Int32.TryParse(textBoxInput1.Text, out num1) || !Int32.TryParse(textBoxInput2.Text, out num2))
            {
                MessageBox.Show("Dữ liệu ở dạng số, Vui lòng nhập lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Chưa lựa chọn loại tính toán, Vui lòng chọn", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Option 1
            if (comboBox1.SelectedItem.ToString() == "Bảng Cửu Chương ( B - A )")
            {
                int multi = int.Parse(textBoxInput2.Text) - int.Parse(textBoxInput1.Text);
                string multiplicationTable = "";
                for (int i = 1; i <= 10; i++)
                {
                    multiplicationTable += $"{multi} x {i} = {multi * i}";
                    multiplicationTable += "\t";
                }


                textBoxResult.Text = multiplicationTable;

            }
            else
            {
                int facto = int.Parse(textBoxInput1.Text) - int.Parse(textBoxInput2.Text);
                int A = int.Parse(textBoxInput1.Text);
                int B = int.Parse(textBoxInput2.Text);
                if (facto < 0)
                {
                    MessageBox.Show("Không tồn tại giai thừa của số âm", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                textBoxResult.Text = "(A - B)! = " + Factorial(facto).ToString() + Environment.NewLine
                    + "S = A^1 + A^2 + A^3 + A^4 + ... + A^B = " + Sum(A,B).ToString();

            }
        }
        private void Ex5_FormClosed(object sender, FormClosedEventArgs e)
        {
            var MainForm = new MainForm();
            MainForm.Show();
        }
    }
}
