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
    public partial class BAI7_Add : Form
    {
        private HttpClient httpClient;

        public BAI7_Add(HttpClient httpClient)
        {
            InitializeComponent();
            this.httpClient = httpClient;
        }

        private async void btnAddDish_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbAddress.Text) ||
               string.IsNullOrWhiteSpace(tbDishName.Text) ||
               string.IsNullOrWhiteSpace(rtbDescription.Text) ||
               string.IsNullOrWhiteSpace(tbImageUrl.Text) ||
               string.IsNullOrWhiteSpace(tbPrice.Text))
            {
                MessageBox.Show("Please fill in all the information", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            JObject jsonObject = new JObject();
            jsonObject.Add("ten_mon_an", tbDishName.Text.Trim());
            jsonObject.Add("gia", int.Parse(tbPrice.Text.Trim()));
            jsonObject.Add("mo_ta", rtbDescription.Text.Trim());
            jsonObject.Add("hinh_anh", tbImageUrl.Text.Trim());
            jsonObject.Add("dia_chi", tbAddress.Text.Trim());



            string jsonString = jsonObject.ToString();


            StringContent httpContent = new StringContent(jsonString, Encoding.UTF8, "application/json");


            using HttpResponseMessage response = await httpClient.PostAsync("api/v1/monan/add", httpContent);

            // receive the response from server
            if (response.IsSuccessStatusCode)
            {

                this.Close();
                MessageBox.Show("Add dish Success!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                var jsonResponse = await response.Content.ReadAsStringAsync();
                JObject data = JObject.Parse(jsonResponse);
                string detail = (string)data["detail"];
                MessageBox.Show(detail, "Fail", MessageBoxButtons.OK);
            }
        }
    }
}

