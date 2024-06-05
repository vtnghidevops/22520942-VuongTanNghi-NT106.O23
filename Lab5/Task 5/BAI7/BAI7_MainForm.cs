using LAB4.BAI7;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB4
{
    public partial class BAI7_MainForm : Form
    {
        private HttpClient httpClient = new HttpClient
        {
            BaseAddress = new Uri(@"https://nt106.uitiot.vn")
        };

        public BAI7_MainForm()
        {
            InitializeComponent();
            btnLogout.Visible = false;
            btnAdd.Enabled = false;
            btnRandom.Enabled = false;
            btnDelete.Enabled = false;
            tabControl1.Enabled = false;

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            BAI7_Login loginForm = new BAI7_Login(httpClient, lblStatus);
            loginForm.ShowDialog();
            if (loginForm.LoginSuccess)
            {

                btnLogin.Visible = false;
                btnLogout.Visible = true;
            }
        }

        private void ResetForm()
        {
            // Đóng tất cả các form trừ form hiện tại
            foreach (Form form in Application.OpenForms)
            {
                if (form != this)
                {
                    form.Close();
                }
            }

            // Khởi động lại ứng dụng
            Application.Restart();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void cbPageAllDish_SelectedIndexChanged(object sender, EventArgs e)
        {
            assignDishesToDGV(int.Parse(cbPageAllDish.Text), int.Parse(cbPageSize.Text), dgvAllDish, "api/v1/monan/all", true);
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                int numberOfDish = dgvAllDish.Rows.Count;
                int randomDishIdx = new Random().Next(0, numberOfDish);

                BAI7_Random radomForm = new BAI7_Random(dgvAllDish.Rows[randomDishIdx]);
                radomForm.ShowDialog();
            }
            else
            {
                int numberOfDish = dgvMyDish.Rows.Count;
                int randomDishIdx = new Random().Next(0, numberOfDish);

                BAI7_Random randomForm = new BAI7_Random(dgvMyDish.Rows[randomDishIdx]);
                randomForm.ShowDialog();
            }
        }


        private async void lblStatus_TextChanged(object sender, EventArgs e)
        {
            if (lblStatus.Text.IndexOf("Welcome") != -1)
            {
                btnAdd.Enabled = true;
                btnDelete.Enabled = true;
                btnRandom.Enabled = true;
                cbPageAllDish.Enabled = true;
                cbPageSize.Enabled = true;
                tabControl1.Enabled = true;

                assignDishesToDGV(1, int.Parse(cbPageSize.Text), dgvAllDish, "api/v1/monan/all", true);


                assignDishesToDGV(1, int.Parse(cbPageSize.Text), dgvMyDish, "api/v1/monan/my-dishes", false);
            }
        }

        private async void assignDishesToDGV(int currentPage, int pageSize, DataGridView dgv, string ApiPath, bool isAllDishTab)
        {

            progressBar1.Value = 0;


            JObject jsonObject = new JObject();
            jsonObject.Add("current", currentPage);
            jsonObject.Add("pageSize", pageSize);

            // convert JSON Object to jsonString
            string jsonString = jsonObject.ToString();


            StringContent httpContent = new StringContent(jsonString, Encoding.UTF8, "application/json");


            using HttpResponseMessage response = await httpClient.PostAsync(ApiPath, httpContent);
            progressBar1.Value = 25;


            if (response.IsSuccessStatusCode)
            {

                var jsonResponse = await response.Content.ReadAsStringAsync();
                JObject data = JObject.Parse(jsonResponse);


                JArray listMonAn = (JArray)data["data"];


                dgv.Rows.Clear();
                foreach (JObject jObject in listMonAn)
                {
                    WebRequest request = WebRequest.Create((string)jObject["hinh_anh"]);
                    WebResponse _response = request.GetResponse();
                    Stream responseStream = _response.GetResponseStream();
                    Bitmap bitmap = new Bitmap(responseStream);


                    dgv.Rows.Add((string)jObject["id"], bitmap, (string)jObject["ten_mon_an"], (string)jObject["gia"], (string)jObject["dia_chi"], (string)jObject["nguoi_dong_gop"], (string)jObject["mo_ta"]);
                }
                progressBar1.Value = 75;


                if (isAllDishTab)
                {
                    cbPageAllDish.Items.Clear();
                }
                else
                {
                    //tabPage1.Items.Clear();
                }
                int numberOfPage = (int)data["pagination"]["total"];
                for (int i = 1; i <= numberOfPage; i++)
                {
                    if (isAllDishTab)
                    {
                        cbPageAllDish.Items.Add(i.ToString());
                    }
                    else
                    {
                        cbPageMyDish.Items.Add(i.ToString());
                    }
                }
                progressBar1.Value = 100;
            }
            else
            {
                var jsonResponse = await response.Content.ReadAsStringAsync();
                JObject data = JObject.Parse(jsonResponse);
                string detail = (string)data["detail"];
                MessageBox.Show(detail, "Fail", MessageBoxButtons.OK);
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                cbPageAllDish.Visible = true;
                cbPageMyDish.Visible = false;
                assignDishesToDGV(int.Parse(cbPageAllDish.Text), int.Parse(cbPageSize.Text), dgvAllDish, "api/v1/monan/all", true);
            }
            else
            {
                cbPageAllDish.Visible = false;
                cbPageMyDish.Visible = true;
                assignDishesToDGV(int.Parse(cbPageMyDish.Text), int.Parse(cbPageSize.Text), dgvMyDish, "api/v1/monan/my-dishes", false);
            }
        }

        private void cbPageSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            assignDishesToDGV(int.Parse(cbPageAllDish.Text), int.Parse(cbPageSize.Text), dgvAllDish, "api/v1/monan/all", true);
            assignDishesToDGV(int.Parse(cbPageMyDish.Text), int.Parse(cbPageSize.Text), dgvMyDish, "api/v1/monan/my-dishes", false);
        }

        private void BAI7_MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            BAI7_Add addDishForm = new BAI7_Add(httpClient);
            addDishForm.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            BAI7_Delete addDishForm = new BAI7_Delete(httpClient);
            addDishForm.ShowDialog();
        }
    }
}
