using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonEx1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Ex1 = new Ex1();
            Ex1.Show();
        }


        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Ex4 = new Ex4();
            Ex4.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            var Ex7 = new Ex7();
            Ex7.Show();
        }

        private void buttonEx2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            var Ex2 = new Ex2();
            Ex2.Show();

        }

        private void buttonEx3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            var Ex3 = new Ex3();
            Ex3.Show();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            var Ex4 = new Ex4();
            Ex4.Show();
        }

        private void buttonEx5_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            var Ex5 = new Ex5();
            Ex5.Show();
        }

        private void buttonEx6_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            var Ex6 = new Ex6();
            Ex6.Show();
        }

        private void buttonExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
