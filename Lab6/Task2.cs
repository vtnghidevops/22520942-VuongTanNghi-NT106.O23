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
    public partial class Task2 : Form
    {
        public Task2()
        {
            InitializeComponent();
        }

        private void btn_Encrypt_Click(object sender, EventArgs e)
        {
            string key = tb_Key.Text;
            string input = rtb_Input.Text;
            rtb_Encrypt.Text = VigenereEncrypt(input, key);
        }

        private void btn_Decrypt_Click(object sender, EventArgs e)
        {
            string key = tb_Key.Text;
            string input = rtb_Encrypt.Text;
            rtb_Decrypt.Text = VigenereDecrypt(input, key);
        }
        private string VigenereEncrypt(string text, string key)
        {
            string result = string.Empty;
            key = key.ToUpper();
            int keyIndex = 0;

            foreach (char c in text)
            {
                if (char.IsLetter(c))
                {
                    char offset = char.IsUpper(c) ? 'A' : 'a';
                    char keyChar = key[keyIndex % key.Length];
                    int k = keyChar - 'A';
                    result += (char)((((c + k) - offset) % 26) + offset);
                    keyIndex++;
                }
                else
                {
                    result += c;  // Preserve non-letter characters
                }
            }
            return result;
        }

        private string VigenereDecrypt(string text, string key)
        {
            string result = string.Empty;
            key = key.ToUpper();
            int keyIndex = 0;

            foreach (char c in text)
            {
                if (char.IsLetter(c))
                {
                    char offset = char.IsUpper(c) ? 'A' : 'a';
                    char keyChar = key[keyIndex % key.Length];
                    int k = keyChar - 'A';
                    result += (char)((((c - k) - offset + 26) % 26) + offset);
                    keyIndex++;
                }
                else
                {
                    result += c;  // Preserve non-letter characters
                }
            }
            return result;
        }
    }
}
