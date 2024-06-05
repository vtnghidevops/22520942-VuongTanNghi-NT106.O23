using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;

namespace Lab5.Task4
{
    public partial class Task4 : Form
    {
        public Task4()
        {
            InitializeComponent();
        }
        public class Movie
        {
            public string Title { get; set; }
            public string ImageUrl { get; set; }
            public string MovieUrl { get; set; }
        }
        List<Movie> movies = new List<Movie>();

        private async void Task4_Load(object sender, EventArgs e)
        {
            string url = "https://betacinemas.vn/phim.htm";
            HtmlWeb web = new HtmlWeb();
            HtmlAgilityPack.HtmlDocument document = await web.LoadFromWebAsync(url);
            HtmlNode MainNode = document.DocumentNode.SelectSingleNode(@"//div[@class='tab-pane fade in active']");
            HtmlNodeCollection movieNodes = MainNode.SelectNodes("//div[@class='col-lg-4 col-md-4 col-sm-8 col-xs-16 padding-right-30 padding-left-30 padding-bottom-30']");
            foreach (var movieNode in movieNodes)
            {
                var titleNode = movieNode.SelectSingleNode(".//h3/a");
                var imageNode = movieNode.SelectSingleNode(".//img[@class='img-responsive border-radius-20']");
                var movieUrlNode = movieNode.SelectSingleNode(".//h3/a");

                if (titleNode != null && imageNode != null && movieUrlNode != null)
                {
                    var movie = new Movie
                    {
                        Title = titleNode.InnerText.Trim(),
                        ImageUrl = imageNode.GetAttributeValue("src", string.Empty),
                        MovieUrl = "https://betacinemas.vn" + movieUrlNode.GetAttributeValue("href", string.Empty)
                    };

                    movies.Add(movie);
                }

            }

            foreach (Movie movie in movies)
            {
                LAB4.ListMovie newMovie = new LAB4.ListMovie();
                newMovie.Label = movie.Title;
                newMovie.Link = movie.MovieUrl;
                newMovie.Image = movie.ImageUrl;
                newMovie.Width = flpMovies.Width;
                flpMovies.Controls.Add(newMovie);

            }
        }

        //private void Lab04_Bai04_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //  MainForm main = new MainForm();
        //  main.Show();
        //}
    }
}
