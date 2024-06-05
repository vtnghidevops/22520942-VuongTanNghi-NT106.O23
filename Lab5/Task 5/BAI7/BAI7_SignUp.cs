using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB4.BAI7
{
    public partial class BAI7_SignUp : Form
    {
        private HttpClient httpClient;
        private Label lblStatus;
        public BAI7_SignUp(HttpClient httpClient, Label lblStatus)
        {
            InitializeComponent();
            this.httpClient = httpClient;
            this.lblStatus = lblStatus;

           
        }

        private async void btnSignUp_Click(object sender, EventArgs e)
        {
            if (tbPass.Text != tbCPass.Text)
            {
                MessageBox.Show("Confirm password mismatch!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            JObject jsonObject = new JObject();
            jsonObject.Add("username", tbUserN.Text);
            jsonObject.Add("email", tbEmail.Text);
            jsonObject.Add("password", tbPass.Text);
            jsonObject.Add("first_name", tbFirstname.Text);
            jsonObject.Add("last_name", tbLastname.Text);
            jsonObject.Add("sex", (rbMale.Checked) ? (0) : (1));
            jsonObject.Add("birthday", dtpBirthday.Value.ToString("yyyy-MM-dd"));
            jsonObject.Add("language", cbLanguage.Text);
            jsonObject.Add("phone", tbPhone.Text);

            
            string jsonString = jsonObject.ToString();

            
            StringContent httpContent = new StringContent(jsonString, Encoding.UTF8, "application/json");

           
            using HttpResponseMessage response = await httpClient.PostAsync("api/v1/user/signup", httpContent);

           
            if (response.IsSuccessStatusCode)
            {
                new Thread(() => Application.Run(new BAI7_Login(httpClient, lblStatus))).Start();

                this.Close();
                MessageBox.Show("Sign Up Susscess!", " Susscess", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var jsonResponse = await response.Content.ReadAsStringAsync();
                JObject data = JObject.Parse(jsonResponse);
                string detail = (string)data["detail"];
                MessageBox.Show(detail, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Thread(() => Application.Run(new BAI7_Login(httpClient, lblStatus))).Start();

            this.Close();
        }
    }
}
