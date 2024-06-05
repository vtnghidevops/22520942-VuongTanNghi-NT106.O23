using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5.Task4
{
    public partial class Task4_DatVe : Form
    {
        public Task4_DatVe()
        {
            InitializeComponent();
        }
        private string _label;
        private string _image;
        public LAB4.ListMovie currentMovieListView;
        public Dictionary<int, List<string>> GheNgoi { get; set; }

        public string Label
        {
            get { return _label; }
            set { _label = value; labelPhim.Text = value; }
        }

        public string Image
        {
            get { return _image; }
            set { _image = value; ptbMovie.Load(_image); }
        }
        private void btnBook_Click(object sender, EventArgs e)
        {
            try
            {
                int selectRoom;
                string selectSeat = "";
                // Lấy phòng đã book
                if (cbRoom.SelectedIndex != -1)
                {
                    selectRoom = cbRoom.SelectedIndex + 1;
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn phòng trước khi đặt vé.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
                // Lấy ghế đã book
                if (clbSeat.SelectedIndex != -1)
                {
                    selectSeat = clbSeat.Items[clbSeat.SelectedIndex].ToString();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn ghế trước khi đặt vé.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("hieuthuthu2004@gmail.com");
                if (txtEmail.Text == null && !IsValidEmail(txtEmail.Text))
                {
                    MessageBox.Show("Email của bạn không hợp lệ, hãy nhập lại !");
                    return;
                }
                // Phần mail
                mail.To.Add(txtEmail.Text);
                mail.Subject = "Vé phim đã đặt của bạn";
                mail.Body = "<!DOCTYPE html>" +
                    "<html lang=\"en\">" +
                    "<head>" +
                    "<meta charset=\"UTF-8\">" +
                    "<meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">" +
                    "<title>Thông tin đặt vé</title>" +
                    "<style>" +
                    "body {" +
                    "font-family: Arial, sans-serif;" +
                    "text-align: center;" +
                    "background-image: url('https://betacinemas.vn/Assets/Common/logo/logo.png');" +
                    "background-repeat: no-repeat;" +
                    "background-position: center;" +
                    "background-size: 300px;" +
                    "background-color: rgba(255, 255, 255, 0.6);" +
                    "backdrop-filter: blur(5px);" +
                    "}" +
                    "img {" +
                    "max-width: 300px;" +
                    "height: auto;" +
                    "}" +
                    "</style>" +
                    "</head>" +
                    "<body>" +
                    "<h1>Cảm ơn bạn đã đặt vé!</h1>" +
                    $"<img src=\"{_image}\" alt=\"Poster phim\">" +
                    $"<p>Ghế ngồi: {selectSeat}</p>" +
                    $"<p>Phòng: {selectRoom}</p>" +
                    $"<p>Tên phim: {_label}</p>" +
                    "<p><em>\"Hãy đến rạp để trải nghiệm những giây phút tuyệt vời nhất!\"</em></p>" +
                    "</body>" +
                    "</html>";
                mail.IsBodyHtml = true;

                //

                // Phần SMTP

                var client = new SmtpClient("smtp.gmail.com");
                client.Port = 587;
                client.EnableSsl = true;
                client.Credentials = new System.Net.NetworkCredential("hieuthuthu2004@gmail.com", "xwqsgjxxisizvwrw");
                client.Send(mail);

                //


                MessageBox.Show("Vui lòng kiểm tra email để nhận thông tin về vé ", "Đã đặt vé thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Xử lý xóa ghế đã đặt
                currentMovieListView.RemoveSeat(selectRoom, selectSeat);
                clbSeat.Items.Clear();
                foreach (string ghe in GheNgoi[selectRoom])
                {
                    clbSeat.Items.Add(ghe);

                }
                //
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi ở button Book: {ex.Message} ");
            }
        }
        private bool IsValidEmail(string emailAddress)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(emailAddress);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void clbSeat_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectRoom = cbRoom.SelectedIndex + 1;
            string selectSeat = clbSeat.Items[clbSeat.SelectedIndex].ToString();
            if (!currentMovieListView.CheckIfSeatAvailable(selectRoom, selectSeat))
            {
                MessageBox.Show("Ghế ngồi này đã được đặt, vui lòng chọn ghế khác !");
                return;
            }
        }

        private void cbRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Thêm ghế ngồi đang có ở phòng đã chọn
            clbSeat.Items.Clear();
            int index = cbRoom.SelectedIndex + 1;
            foreach (string ghe in GheNgoi[index])
            {
                clbSeat.Items.Add(ghe);

            }
        }
    }
}
