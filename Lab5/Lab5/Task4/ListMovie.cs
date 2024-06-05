using Lab5.Task4;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB4
{
    public partial class ListMovie : UserControl
    {
        public ListMovie()
        {
            InitializeComponent();
            _label = "";
            _link = "";
            _imagelink = "";
            this.Name = _label;
        }

        private string _label;
        private string _link;
        private string _imagelink;
        private List<string> seats;
        public Dictionary<int, List<string>> GheNgoi { get; set; }
        string[] listSeats = { "A1", "A2", "A3", "A4", "A5", "B1", "B2", "B3", "B4", "B5", "C1", "C2", "C3", "C4", "C5" };
        int[] listRoom = { 1, 2, 3 };

        private void lblPhim_Click(object sender, EventArgs e)
        {
            Task4_WebView web = new Task4_WebView(_link);
            web.Text = _label;
            web.Show();

        }
        private void btnBook_Click(object sender, EventArgs e)
        {
            Task4_DatVe book = new Task4_DatVe();
            book.Image = _imagelink;
            book.Label = _label;
            book.GheNgoi = GheNgoi;
            book.currentMovieListView = this;
            book.Text = $"Đặt vé cho phim: {_label}";
            book.Show();
        }

        private void ListMovie_Load(object sender, EventArgs e)
        {
            
            GheNgoi = new Dictionary<int, List<string>>();
            GheNgoi[1]= new List<string>(listSeats);
            GheNgoi[2] = new List<string>(listSeats);
            GheNgoi[3] = new List<string>(listSeats);


        }

        public string Label
        {
            get { return _label; }
            set { _label = value; lblPhim.Text = _label; }
        }
        public string Link
        {
            get { return _link; }
            set { _link = value; lblLink.Text = _link; }
        }

        public string Image
        {
            get { return _imagelink; }
            set { _imagelink = value; ptbPhim.Load(_imagelink); }
        }

        public List<string> Seats
        {
            get { return seats; }
            set {  seats = value; }
        }

        public bool CheckIfSeatAvailable(int room, string seat)
        {
            return (GheNgoi[room].Contains(seat));
        }

        public void RemoveSeat(int room, string seat)
        {
            try
            {
                if (GheNgoi[room].Contains(seat))
                {
                    GheNgoi[room].Remove(seat);
                }
                else
                {

                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"Lỗi xóa ghế RemoveSeat: {ex.Message}");
            }
                
        }

    }
}
