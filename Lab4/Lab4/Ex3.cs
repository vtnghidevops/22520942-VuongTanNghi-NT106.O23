using HtmlAgilityPack;
using System.Net;
using System.Text.RegularExpressions;

namespace Lab4
{
    public partial class Ex3 : Form
    {
        public Ex3()
        {
            InitializeComponent();
        }

        private async void Ex03_Load(object sender, EventArgs e)
        {
            await webView2.EnsureCoreWebView2Async(null);
        }

        private void Lab4_txtURL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btn_loadURL.PerformClick();
            }
        }

        private void webView2_NavigationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs e)
        {
            Invoke(new Action(() => Text = webView2.CoreWebView2.DocumentTitle?.ToString()));
        }

        private void btn_loadURL_Click(object sender, EventArgs e)
        {
            string url = tb_inputURL.Text;
            if (string.IsNullOrWhiteSpace(url))
            {
                MessageBox.Show("Lỗi", "Vui lòng điền URL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            webView2.CoreWebView2.Navigate(url);
        }

        private async void btn_downSrc_Click(object sender, EventArgs e)
        {
            if (webView2.Source == null)
            {
                MessageBox.Show("Lỗi", "Vui lòng load web trước khi tải", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (var dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string downloadDirectory = dialog.SelectedPath;

                    await DownloadResourcesFromWebView(downloadDirectory);

                }
            }
        }


        private async void btn_downHTML_Click(object sender, EventArgs e)
        {
            if (webView2.Source == null)
            {
                MessageBox.Show("Lỗi", "Vui lòng load web trước khi tải", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var html = await DownloadHTML();
            if (!string.IsNullOrEmpty(html))
            {
                using (var saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "HTML files (*.html)|*.html";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllText(saveFileDialog.FileName, html);
                        MessageBox.Show("Thành công", "Download HTML thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
            }
        }

        private async Task<string> DownloadHTML()
        {
            var html = await webView2.CoreWebView2.ExecuteScriptAsync("document.documentElement.outerHTML");
            html = Regex.Unescape(html);
            html = html.Remove(0, 1);
            html = html.Remove(html.Length - 1, 1);
            return html;
        }

        private async Task DownloadResourcesFromWebView(string downloadDirectory)
        {
            string html = await DownloadHTML();

            // Sử dụng HTMLAgilityPack để phân tích HTML
            var htmlDocument = new HtmlAgilityPack.HtmlDocument();
            htmlDocument.LoadHtml(html);

            var htmlFileName = "Lab4_Ex3.html";
            File.WriteAllText(Path.Combine(downloadDirectory, htmlFileName), html);

            Directory.CreateDirectory(downloadDirectory);

            using (WebClient webClient = new WebClient())
            {
                var imageNodes = htmlDocument.DocumentNode.Descendants("img");
                foreach (var imageNode in imageNodes)
                {
                    string imageUrl = imageNode.GetAttributeValue("src", "");
                    imageUrl = webView2.Source.ToString() + imageUrl;

                    string fileName = Path.GetFileName(imageUrl);
                    string filePath = Path.Combine(downloadDirectory, fileName);

                    try
                    {
                        // Tiến hành tải xuống hình ảnh
                        await webClient.DownloadFileTaskAsync(imageUrl, filePath);
                        Console.WriteLine("Download file: " + fileName);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Lỗi down hình ảnh: " + fileName);
                        Console.WriteLine("Error: " + ex.Message);
                    }
                }

                var linkNodes = htmlDocument.DocumentNode.Descendants("a");

                // Lặp qua tất cả các thẻ <a> và tải xuống các liên kết
                foreach (var linkNode in linkNodes)
                {
                    string linkUrl = linkNode.GetAttributeValue("href", "");
                    linkUrl = webView2.Source.ToString() + linkUrl;

                    string fileName = Path.GetFileName(linkUrl);
                    string filePath = Path.Combine(downloadDirectory, fileName);

                    try
                    {
                        // Tiến hành tải xuống liên kết
                        await webClient.DownloadFileTaskAsync(linkUrl, filePath);
                        Console.WriteLine("Downloaded file: " + fileName);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Failed to download file: " + fileName);
                        Console.WriteLine("Error: " + ex.Message);
                    }
                }
            }

            MessageBox.Show("Completed", "Tải xuống hoàn tất.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void webView2_Click(object sender, EventArgs e)
        {

        }

        private void btn_reload_Click(object sender, EventArgs e)
        {
            if (webView2.CoreWebView2 != null)
            {
                MessageBox.Show("Reload thành công", "Thành công.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                webView2.CoreWebView2.Reload(); // Reloads the current page
            }
            else
            {
                MessageBox.Show("Error", "WebView2 is not ready.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}
