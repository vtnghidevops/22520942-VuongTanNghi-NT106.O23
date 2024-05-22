using System;
using System.IO;
using System.Net;
using System.Windows.Forms;
using HtmlAgilityPack;

namespace Lab4
{
    public partial class Ex1 : Form
    {
        public Ex1()
        {
            InitializeComponent();
        }

        private void btn_getURL_Click(object sender, EventArgs e)
        {
            string htmlContent = getSource(tb_input.Text);
            if (htmlContent == "URL không tồn tại!")
            {
                MessageBox.Show("URL không tồn tại!");
            }
            else
            {
                rtb_res.Text = GetHTML(tb_input.Text); ; 
            }
        }

        private string GetHTML(string szURL)
        {
            try
            {
                // Create a request for the URL.
                WebRequest request = WebRequest.Create(szURL);
                // Get the response.
                WebResponse response = request.GetResponse();
                // Get the stream containing content returned by the server.
                Stream dataStream = response.GetResponseStream();
                // Open the stream using a StreamReader for easy access.
                StreamReader reader = new StreamReader(dataStream);
                // Read the content.
                string responseFromServer = reader.ReadToEnd();
                // Close the response.
                response.Close();
                return responseFromServer;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return "nothing";
            }

        }

        private string getSource(string URL)
        {
            try
            {
                HtmlWeb web = new HtmlWeb();
                HtmlAgilityPack.HtmlDocument content = web.Load(URL);
                return content.Text; // Return the text content of the HTML document
            }
            catch (WebException ex) // Catching WebException specifically for network errors
            {
                MessageBox.Show($"Failed to load URL: {ex.Message}");
                return "URL không tồn tại!";
            }
            catch (Exception ex) // General exception handling
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                return "An error occurred.";
            }
        }

        private void tb_input_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
