using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB4.BAI7
{
    public partial class BAI7_Random : Form
    {
        private DataGridViewRow dgvr;

        public BAI7_Random(DataGridViewRow dgvr)
        {
            InitializeComponent();
            this.dgvr = dgvr;
            DisplayData();
        }

        private void DisplayData()
        {
            if (dgvr != null && dgvr.Cells.Count >= 5)
            {
                if (dgvr.Cells[1].Value != null && dgvr.Cells[1].Value is Image)
                {
                    pictureBox1.Image = (Image)dgvr.Cells[1].Value;
                }

                label1.Text = dgvr.Cells[2].Value?.ToString();
                label5.Text = dgvr.Cells[3].Value?.ToString();
                label6.Text = dgvr.Cells[4].Value?.ToString();
                label7.Text = dgvr.Cells[5].Value?.ToString();
            }
        }

        private void btn_share_Click(object sender, EventArgs e)
        {
            Task5_invite invite = new Task5_invite(dgvr);
            invite.Show();
            Task5_emailSetting setting = new Task5_emailSetting();
            setting.Show();

        }
    }
}
