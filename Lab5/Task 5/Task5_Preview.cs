using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;

namespace LAB4
{
    public partial class Task5_Preview : Form
    {
        private DataGridViewRow dgvr;
        public Task5_Preview(DataGridViewRow dgvr)
        {
            InitializeComponent();
            this.dgvr = dgvr;
            this.dgvr = dgvr;
        }

        private async void Task5_Preview_Load(object sender, EventArgs e)
        {
            string foodname, price, address;
            foodname = dgvr.Cells[2].Value?.ToString();
            price = dgvr.Cells[3].Value?.ToString();
            address = dgvr.Cells[4].Value?.ToString();
            string img = dgvr.Cells[1].Value?.ToString();

            string html = "<!DOCTYPE html>" +
                 "<html>" +
                "<head>" +
                "<title> Món ăn </title>" +
                "<style>" +
                "body {" +
                "text-align: center;" +
                "font-family: Arial, sans-serif;" +
                "}" +
                "h1 {" +
                "font-size: 36px;" +
                "margin-bottom: 10px;" +
                "color: red" +
                "}" +
                "p {" +
                "font-size: 18px;" +
                "margin-bottom: 5px;" +
                "}" +
                "small {" +
                "font-size: 14px;" +
                "color: gray;" +
                "}" +
                "</style>" +
                "</head>" +
                "<body>" +
                $"<img src={img} width=300 height=300>" +
                $"<h1>{foodname}</h1>" +
                $"<p>{price}</p>" +
                $"<small>{address}</small>" +
                "</body>" +
                "</html>";
            await webView21.EnsureCoreWebView2Async();
            webView21.NavigateToString(html);
        }

    }
}
