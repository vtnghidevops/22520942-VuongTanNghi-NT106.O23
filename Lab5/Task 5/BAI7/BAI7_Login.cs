using LAB4.BAI7;
using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB4
{
    public partial class BAI7_Login : Form
    {
        private HttpClient httpClient;
        private Label lblStatus;
        public bool LoginSuccess { get; private set; }

        public BAI7_Login(HttpClient httpClient, Label lblStatus)
        {
            InitializeComponent();
            this.httpClient = httpClient;
            this.lblStatus = lblStatus;
        }


        private async void btnLogin_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Please type Username and Password!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var formData = new FormUrlEncodedContent(new[]
            {
        new KeyValuePair<string, string>("username", textBox1.Text),
        new KeyValuePair<string, string>("password", textBox2.Text)
    });

            try
            {
                // Gửi yêu cầu POST để đăng nhập
                using HttpResponseMessage response = await httpClient.PostAsync("auth/token", formData);

                if (response.IsSuccessStatusCode)
                {
                    // Đăng nhập thành công
                    var jsonResponse = await response.Content.ReadAsStringAsync();
                    JObject data = JObject.Parse(jsonResponse);

                    string JWT = (string)data["access_token"];
                    httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", JWT);

                    // Đóng form đăng nhập và hiển thị thông báo đăng nhập thành công
                    MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdateLabelStatusThreadSafe($"Welcome, {textBox1.Text}");
                    LoginSuccess = true;
                    this.Close();
                }
                else
                {
                    // Đăng nhập thất bại
                    var jsonResponse = await response.Content.ReadAsStringAsync();
                    JObject data = JObject.Parse(jsonResponse);
                    string detail = (string)data["detail"];
                    MessageBox.Show(detail, "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LoginSuccess = false;
                }
            }
            catch (HttpRequestException ex)
            {
                // Xử lý lỗi khi gửi yêu cầu đến máy chủ
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoginSuccess = false;
            }
        }

        private delegate void SafeCallDelegate(string text);

        private void UpdateLabelStatusThreadSafe(string text)
        {
            if (lblStatus.InvokeRequired)
            {
                var d = new SafeCallDelegate(UpdateLabelStatusThreadSafe);
                lblStatus.Invoke(d, new object[] { text });
            }
            else
            {
                lblStatus.Text = text;
                lblStatus.ForeColor = Color.Orange;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Thread(() => Application.Run(new BAI7_SignUp(httpClient, lblStatus))).Start();

            this.Close();
        }
    }
}
