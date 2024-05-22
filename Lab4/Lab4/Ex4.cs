using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using HtmlAgilityPack;
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;
using System.IO;
using static Lab4.Ex4;
using static System.Windows.Forms.LinkLabel;
using System.Security.Policy;
using System.Net;
using System.Runtime.CompilerServices;
using System.Reflection.Emit;


namespace Lab4
{
    public partial class Ex4 : Form
    {
        public class Movie
        {
            public string Name;
            public string Link;
            public string Image;
        }
        public Ex4()
        {
            InitializeComponent();
            panel1.AutoScroll = true;
            panel1.AutoScrollMinSize = new Size(panel1.Width / 2, 0); // Chỉnh sửa giá trị này theo nhu cầu

        }
        List<Movie> Movies = new List<Movie> { };

        void AddMovie(string imageUrl, string link, string NameMovie)
        {
            Movie movie = new Movie();
            movie.Name = NameMovie;
            movie.Link = "https://betacinemas.vn" + link;
            movie.Image = imageUrl;
            Movies.Add(movie);
        }

        string Absolute(string imageUrl)
        {
            string url = "https://betacinemas.vn/phim.htm";
            Uri uri = new Uri(imageUrl, UriKind.RelativeOrAbsolute);
            if (!uri.IsAbsoluteUri)
            {
                imageUrl = new Uri(new Uri(url), uri).AbsoluteUri;
            }
            string s = imageUrl;
            return s;
        }

        string path = "";
        void Serialize()
        {
            string json = JsonConvert.SerializeObject(Movies, Formatting.Indented);

            using (var folderBrowserDialog = new FolderBrowserDialog())
            {
                DialogResult result = folderBrowserDialog.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrEmpty(folderBrowserDialog.SelectedPath))
                {
                    string selectedFolder = folderBrowserDialog.SelectedPath;
                    string fileName = "Movie.json";
                    string filePath = Path.Combine(selectedFolder, fileName);
                    path = selectedFolder;
                    File.WriteAllText(filePath, json);
                    MessageBox.Show("Chuyển thành công!!");
                }
            }
        }

        List<string> imgPath = new List<string> { };
        private void DownloadImage(string imageUrl)
        {

            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(imageUrl);
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    using (System.IO.Stream stream = response.GetResponseStream())
                    {
                        string fileName = System.IO.Path.GetFileName(new Uri(imageUrl).LocalPath);
                        string filePath = System.IO.Path.Combine(path, fileName);
                        using (System.IO.Stream outputStream = System.IO.File.OpenWrite(filePath))
                        {
                            stream.CopyTo(outputStream);
                        }
                        Console.WriteLine($"Downloaded image: {fileName}");
                        //imgPath = Path.Combine(filePath,fileName);
                        imgPath.Add(filePath);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void Created()
        {
            int i = 0;
            int groupBoxX = 12;
            int spacing = 20;
            int groupBoxY = 31;
            int groupBoxWidth = 776;
            int groupBoxHeight = 178;
            foreach (Movie movie in Movies)
            {


                GroupBox groupBox = new GroupBox();
                panel1.Controls.Add(groupBox);
                groupBox.Location = new System.Drawing.Point(groupBoxX, groupBoxY);
                groupBox.Size = new System.Drawing.Size(groupBoxWidth, groupBoxHeight);


                PictureBox pictureBox = new PictureBox();
                groupBox.Controls.Add(pictureBox);
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Location = new System.Drawing.Point(6, 20);
                pictureBox.Size = new Size(130, 170);

                try
                {
                    if (!string.IsNullOrEmpty(imgPath[i]) && System.IO.File.Exists(imgPath[i]))
                    {
                        Image image = Image.FromFile(imgPath[i]);
                        pictureBox.Image = image;
                    }
                    else
                    {
                        MessageBox.Show("Lỗi: Không thể tìm thấy hình ảnh.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }

                // Create a container for the movie name and link
                Panel movieInfoContainer = new Panel();

                groupBox.Controls.Add(movieInfoContainer);
                movieInfoContainer.Dock = DockStyle.Fill; // Fill the remaining space
                movieInfoContainer.BackColor = Color.Transparent; // Optional: Set background color to match the GroupBox

                System.Windows.Forms.Label nameLabel = new System.Windows.Forms.Label();
                movieInfoContainer.Controls.Add(nameLabel);
                nameLabel.Location = new Point(150, 20); // Adjust as needed
                nameLabel.Text = movie.Name;
                nameLabel.AutoSize = true;
                nameLabel.Font = new Font("Arial", 12, FontStyle.Bold);
                nameLabel.ForeColor = Color.Orange;

                System.Windows.Forms.Label linkLabel = new System.Windows.Forms.Label();
                movieInfoContainer.Controls.Add(linkLabel);
                linkLabel.Location = new Point(150, 60); // Adjust as needed
                linkLabel.Text = movie.Link;
                linkLabel.AutoSize = true;



                // Center-align the labels within the container
                nameLabel.TextAlign = ContentAlignment.TopRight;
                linkLabel.TextAlign = ContentAlignment.TopRight;

                // Optionally, adjust the size and appearance of the container to better fit your needs
                movieInfoContainer.Size = new Size(groupBox.Width - 150, groupBox.Height - 40); // Adjust sizes as needed

                groupBoxY += groupBoxHeight + spacing;
                i++;
                progressBar1.Value += 10;


                linkLabel.Click += (sender, e) =>
                {
                    try
                    {
                        WebView w = new WebView(linkLabel.Text);
                        w.ShowDialog();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                };

            }
            if (progressBar1.Value == progressBar1.Maximum)
            {
                progressBar1.Visible = false;
            }
        }

        private void LinkLabel_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private async void Ex4_Load(object sender, EventArgs e)
        {
            string url = "https://betacinemas.vn/phim.htm";
            HtmlWeb web = new HtmlWeb();
            HtmlAgilityPack.HtmlDocument document = await web.LoadFromWebAsync(url);
            HtmlNode _nodeChinh = document.DocumentNode.SelectSingleNode(@"//div[@class='tab-pane fade in active']");

            HtmlNodeCollection arrNodThread = _nodeChinh.SelectNodes(@"//div[@class='col-lg-4 col-md-4 col-sm-8 col-xs-16 padding-right-30 padding-left-30 padding-bottom-30']");
            foreach (var n in arrNodThread)
            {
                string _imageUrl = n.SelectSingleNode(@"div/div[1]/div/div[1]/img").Attributes["src"].Value;
                string _imageUrlU = Absolute(_imageUrl);
                string _link = n.SelectSingleNode(@"div/div[2]/div[1]/h3/a").Attributes["href"].Value;
                string _NameMovie = n.SelectSingleNode(@"div/div[2]/div[1]/h3/a").InnerText;

                AddMovie(_imageUrlU, _link, _NameMovie);
            }
            Serialize();
            foreach (Movie m in Movies)
            {
                DownloadImage(m.Image);
            }
            Created();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
