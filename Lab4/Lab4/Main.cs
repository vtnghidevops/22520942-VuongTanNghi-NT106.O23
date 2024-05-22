using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Ex1 ex1 = new Ex1();
            ex1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Ex2 ex2 = new Ex2();
            ex2.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            Ex3 ex3 = new Ex3();
            ex3.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            Ex4 ex4 = new Ex4();
            ex4.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            Ex5 ex5 = new Ex5();
            ex5.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Ex6 ex6 = new Ex6();
            ex6.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            //Ex7 ex7 = new Ex7();
            //ex7.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
