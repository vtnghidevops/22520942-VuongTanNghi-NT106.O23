using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Runtime.InteropServices.JavaScript;




namespace Lab4
{
    public partial class Ex5 : Form
    {
        public Ex5()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            rtb_res.Text = string.Empty; 
            try
            {
                var url = "https://nt106.uitiot.vn/auth/token";
                var username = tb_userName.Text;
                var pwd = tb_password.Text;

                using (var client = new HttpClient())
                {
                    var content = new MultipartFormDataContent
                    {
                         {new StringContent (username), "username" },
                          {new StringContent (pwd), "password"}
                     };



                    var response = await client.PostAsync(url, content);
                    var resposeString = await response.Content.ReadAsStringAsync();
                    var responseObj = JsonObject.Parse(resposeString);

                    if (!response.IsSuccessStatusCode)
                    {
                        var detail = responseObj["detail"].ToString();
                        rtb_res.Text = detail;
                       
                        return;
                    }

                    var tokenType = responseObj["token_type"].ToString();
                    var accessToken = responseObj["access_token"].ToString();
                    string token = $"Token type: {tokenType}";
                    string access = $"AccessToken: {accessToken}";
                    string tokenInfo = $"Token type: {tokenType}\nAccess Token: {accessToken}";

                    rtb_res.AppendText(tokenInfo + "\nĐăng nhập thành công\n");


                    // get info user from server
                    // Use the access toen to authen a get request
                    //client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);

                    //var getUserURl = "https://nt106.uitiot.vn/api/v1/user/me";
                    //var getUserResponse = await client.GetAsync(getUserURl);
                    //if (getUserResponse.IsSuccessStatusCode)
                    //{
                    //    var getUserResponseString = await getUserResponse.Content.ReadAsStringAsync();
                    //    rtb_res.AppendText(getUserResponseString + Environment.NewLine);
                    //}
                    //else
                    //{
                    //    var errorDetail = await getUserResponse.Content.ReadAsStringAsync();
                    //    MessageBox.Show($"Failed to get user info: {errorDetail}");
                    //}
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

    }
}
