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
    public partial class Ex8 : Form
    {
        private static List<string> Food = new List<string>() { "Bún Bò", "Phở", "Bún Đậu Mắm Tôm", "Cơm Gà" };


        public Ex8()
        {
            InitializeComponent();
            foreach (string food in Food)
            {
                listBoxFood.Items.Add(food);
            }
        }
        

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random randomIndex = new Random();
            int index = randomIndex.Next(listBoxFood.Items.Count);
            textBoxResult.Text = listBoxFood.Items[index].ToString();
            

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            double num;
            if (string.IsNullOrEmpty(textBoxInput.Text))
            {
                MessageBox.Show("Chưa Nhập Món Ăn, Vui Lòng Nhập Rồi Thêm Sau", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Double.TryParse(textBoxInput.Text, out num))
            {
                MessageBox.Show("Sai Định Dạng , Vui Lòng Nhập Dạng Chữ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string input = textBoxInput.Text;
            Food.Add(input.ToString());
            listBoxFood.Items.Add(input.ToString());
            textBoxInput.Text = null;

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_restore_Click(object sender, EventArgs e)
        {
            textBoxInput.Text = string.Empty;

            // Kiểm tra xem có mục nào được chọn hay không

            if (listBoxFood.SelectedIndex != -1)
            {
                int selectedIndex = listBoxFood.SelectedIndex;
                // Xóa mục được chọn
                listBoxFood.Items.RemoveAt(listBoxFood.SelectedIndex);
                Food.RemoveAt(selectedIndex);
            }

            textBoxResult.Text = string.Empty;
        }

        private void listBoxFood_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            

        }
        private void Ex8_FormClosed(object sender, FormClosedEventArgs e)
        {
            var MainForm = new MainForm();
            MainForm.Show();
        }
    }
}
