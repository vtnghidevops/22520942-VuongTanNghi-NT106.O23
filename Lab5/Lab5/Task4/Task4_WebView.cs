using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5.Task4
{
    public partial class Task4_WebView : Form
    {
        public Task4_WebView()
        {
            InitializeComponent();
        }

        public Task4_WebView(string link)
        {
            InitializeComponent();
            RunBrowser(link);
        }

        private async Task Init()
        {
            await webView21.EnsureCoreWebView2Async(null);
        }
        public async void RunBrowser(string link)
        {
            await Init();
            webView21.CoreWebView2.Navigate(link);
        }
    }
}
