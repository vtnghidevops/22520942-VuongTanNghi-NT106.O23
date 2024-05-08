using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Task_1 : Form
    {
        public Task_1()
        {
            InitializeComponent();
        }

        private void btn_Server_Click(object sender, EventArgs e)
        {
            Task1_Server task1_Server = new Task1_Server();
            task1_Server.Show();
            btn_Server.Enabled = false;
        }

        private void btn_Client_Click(object sender, EventArgs e)
        {
            Task1_Client task1_Client = new Task1_Client();
            task1_Client.Show();
        }
    }
}
