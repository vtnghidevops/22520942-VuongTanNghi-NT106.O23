using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6
{
    public partial class Task1 : Form
    {
        public Task1()
        {
            InitializeComponent();
        }

        private void btn_Encrypt_Click(object sender, EventArgs e)
        {
            int shift = int.Parse(tb_Shift.Text);
            string input = rtb_Input.Text;
            rtb_Encrypt.Text = CaesarEncrypt(input, shift);
        }

        private void btn_Decrypt_Click(object sender, EventArgs e)
        {
            int shift = int.Parse(tb_Shift.Text);
            string input = rtb_Encrypt.Text;
            rtb_Decrypt.Text = CaesarDecrypt(input, shift);
        }
        private string CaesarEncrypt(string text, int shift)
        {
            string result = string.Empty;
            foreach (char c in text)
            {
                if (char.IsLetter(c))
                {
                    char d = char.IsUpper(c) ? 'A' : 'a';
                    result += (char)((((c + shift) - d) % 26) + d);
                }
                else
                {
                    result += c;
                }
            }
            return result;
        }

        private string CaesarDecrypt(string text, int shift)
        {
            return CaesarEncrypt(text, 26 - shift);
        }
    }
}
