using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class WebView : Form
    {
        public WebView()
        {
            InitializeComponent();
        }
        public WebView(string link)
        {
            InitializeComponent();
            InitBrowser(link);
        }
        private async Task initizated()
        {
            await webView21.EnsureCoreWebView2Async(null);
        }
        public async void InitBrowser(string s)
        {
            await initizated();
            webView21.CoreWebView2.Navigate(s);
        }

        private void webView21_Click(object sender, EventArgs e)
        {

        }
    }
}
