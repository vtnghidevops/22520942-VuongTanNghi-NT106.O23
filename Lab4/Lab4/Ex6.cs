using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Lab4
{
    public partial class Ex6 : Form
    {
        public Ex6()
        {
            InitializeComponent();
        }

        private async void btn_Get_Click(object sender, EventArgs e)
        {
            
            string url = tb_URL.Text;
            string token = tb_Token.Text;

            if(token.Length == 0)
            {
                MessageBox.Show("Please enter token!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                //Using http client to make HTTP get request
                using (var client = new HttpClient())
                {
                    
                    // Use the access toen to authen a get request
                    client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
                    var getUserURl = tb_URL.Text;
                    var getUserResponse = await client.GetAsync(getUserURl);

                    if (getUserResponse.IsSuccessStatusCode)
                    {
                        var getUserResponseString = await getUserResponse.Content.ReadAsStringAsync();
                        rtb_res.AppendText(getUserResponseString + Environment.NewLine);
                    }
                    else
                    {
                        var errorDetail = await getUserResponse.Content.ReadAsStringAsync();
                        MessageBox.Show($"Failed to get user info: {errorDetail}");
                    }
                }
            }
            catch
            {
                rtb_res.Text = "Token not is no longer active!";
            }


        }
    }
}
