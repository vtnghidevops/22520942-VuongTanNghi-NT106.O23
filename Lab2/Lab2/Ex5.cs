using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Lab2.Ex5;

namespace Lab2
{
    public partial class Ex5 : Form
    {
        public Ex5()
        {
            InitializeComponent();
        }

        public class Phim
        {
            public string Name { get; set; }
            public List<int> Phong { get; set; }
            public int GiaVe { get; set; }
            public Phim(string Name, List<int> Phong, int GiaVe)
            {
                this.Name = Name;
                this.Phong = Phong;
                this.GiaVe = GiaVe;
            }
            public Phim()
            {
                this.Name = string.Empty;
                this.Phong = new List<int>();
                this.GiaVe = 0;
            }
            public override string ToString()
            {
                string result = string.Empty;
                result += this.Name + " " + this.GiaVe.ToString() + " ";
                foreach (int i in this.Phong)
                {
                    result += i.ToString();
                }
                return result;
            }
        }

        List<Phim> dsPhim = new List<Phim>();

        public class HoaDon
        {
            public string tenKH { get; set; }
            public string tenPhim { get; set; }
            public int giaVeCB { get; set; }
            public int soVeVip { get; set; }
            public int soVeThuong { get; set; }
            public int soVeVot { get; set; }
            public HoaDon()
            {
                this.tenKH = string.Empty;
                this.tenPhim = string.Empty;
                this.soVeVot = 0;
                this.soVeVip = 0;
                this.soVeThuong = 0;
                this.giaVeCB = 0;
            }
            public double giaTien()
            {
                double kq = this.giaVeCB * (this.soVeThuong + this.soVeVip * 2 + this.soVeVot * 0.25);
                return Math.Round(kq, 2);
            }
            public override string ToString()
            {
                string result = string.Empty;
                string ketqua = string.Empty;
                ketqua += "Họ tên khách hàng: " + this.tenKH + "\n"
                    + "Tên phim: " + this.tenPhim + "\n"
                    + "Số vé thường: " + this.soVeThuong + "\n"
                    + "Số vé VIP: " + this.soVeVip + "\n"
                    + "Số vé vớt: " + this.soVeVot + "\n"
                    + "Số tiền cần thanh toán: " + giaTien().ToString();
                return ketqua;
            }
        }
        List<HoaDon> dsHoaDon = new List<HoaDon>();

        private void LoadPhim(string info)
        {

            string[] detail = info.Split("\n");
            int index = 0;
            if (detail.Length > 4)
            {
                index++;
            }
            string name = detail[index++];
            int giaVe = int.Parse(detail[index++]);
            List<int> phong = new List<int>();
            string[] string_phong = detail[index].Split(",");
            foreach (string sophong in string_phong)
            {
                phong.Add(int.Parse(sophong));
            }
            Phim phim = new Phim(name, phong, giaVe);
            dsPhim.Add(phim);
        }

        private void btn_ReadFromFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string content = File.ReadAllText(openFileDialog.FileName);
                string[] NameOfFilm = content.Split('_');
                foreach (string info in NameOfFilm)
                {
                    LoadPhim(info);
                }
            }
            cb_NameofFilm.Enabled = true;
            cb_NameofFilm.Items.Clear();
            foreach (Phim phim in dsPhim)
            {
                cb_NameofFilm.Items.Add(phim.Name);
            }
        }
        Phim selectedFilm = new Phim();

        private void cb_NameofFilm_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_Room.Items.Clear();
            foreach (Phim phim in dsPhim)
            {
                if (phim.Name == cb_NameofFilm.Text)
                {
                    selectedFilm = phim;
                    foreach (int i in phim.Phong)
                    {
                        cb_Room.Items.Add(i);
                    }
                }
            }
            cb_Room.Enabled = true;
        }

        private void cb_Room_SelectedIndexChanged(object sender, EventArgs e)
        {
            A1.Enabled = true;
            clb_B.Enabled = true;
            clb_C.Enabled = true;

            btn_DatVe.Enabled = true;
        }
        public static int soLuongVeBanDau = 100;
        private void btn_XuatThongKe_Click(object sender, EventArgs e)
        {
            if (dsHoaDon.Count <= 0)
            {
                MessageBox.Show("Chưa có hóa đơn");
                return;
            }
            Dictionary<string, int> soLuongVeBan = new Dictionary<string, int>();
            Dictionary<string, double> doanhthu = new Dictionary<string, double>();
            foreach (Phim phim in dsPhim)
            {
                soLuongVeBan.Add(phim.Name, 0);
                doanhthu.Add(phim.Name, 0);
            }
            string result = string.Empty;
            foreach (Phim phim in dsPhim)
            {
                result += "Tên phim: " + phim.Name + "\n"
                    + "Số lượng vé bán ra: " + soLuongVeBan[phim.Name] + "\n"
                    + "Số lượng vé tồn: " + (soLuongVeBanDau - soLuongVeBan[phim.Name]).ToString() + "\n"
                    + "Tỷ lệ vé bán ra: " + (soLuongVeBan[phim.Name] * 1.0 / soLuongVeBanDau) * 100 + "%\n"
                    + "Doanh thu: " + doanhthu[phim.Name] + "\n"
                    + "----------------------------------------------------------------------------------\n";
            }
            result += "\n-------------Top doanh thu-------------------\n";
            foreach (KeyValuePair<string, double> top in doanhthu.OrderByDescending(key => key.Value))
            {
                result += top.Key + ": " + top.Value + "\n";
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text File|*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream fs1 = new FileStream(saveFileDialog.FileName, FileMode.OpenOrCreate);
                StreamWriter sw = new StreamWriter(fs1);
                sw.Write(result);
                sw.Flush();
                fs1.Close();
            }
            doanhthu.Clear();
            soLuongVeBan.Clear();
        }

        private void btn_DatVe_Click(object sender, EventArgs e)
        {
            HoaDon hd = new HoaDon();
            if (tb_CustomerName.Text == null || tb_CustomerName.Text == "")
            {
                MessageBox.Show("Nhập tên khách hàng");
                return;
            }
            hd.tenKH = tb_CustomerName.Text;
            hd.tenPhim = selectedFilm.Name;
            hd.giaVeCB = selectedFilm.GiaVe;
            foreach (var seat in A1.CheckedItems)
            {
                if (seat.ToString() == "A2" || seat.ToString() == "A3" || seat.ToString() == "A4")
                {
                    hd.soVeThuong++;
                }
                else
                {
                    hd.soVeVot++;
                }
            }
            foreach (var seat in clb_B.CheckedItems)
            {
                if (string.IsNullOrEmpty(seat.ToString()))
                {
                    continue;
                }
                hd.soVeVip++;
            }
            foreach (var seat in clb_C.CheckedItems)
            {
                if (seat.ToString() == "C2" || seat.ToString() == "C3" || seat.ToString() == "C4")
                {
                    hd.soVeThuong++;
                }
                else
                {
                    hd.soVeVot++;
                }
            }
            if (hd.soVeThuong == 0 && hd.soVeVip == 0 && hd.soVeVot == 0)
            {
                MessageBox.Show("Hãy chọn ghế");
            }
            dsHoaDon.Add(hd);
            MessageBox.Show(hd.ToString());
            tb_CustomerName.Clear();
            for (int i = 0; i < A1.Items.Count; i++)
            {
                A1.SetItemChecked(i, false);
                clb_B.SetItemChecked(i, false);
                clb_C.SetItemChecked(i, false);
            }
            A1.ClearSelected();
            clb_B.ClearSelected();
            clb_C.ClearSelected();

            btn_DatVe.Enabled = false;
        }

        private void Ex5_FormClosed(object sender, FormClosedEventArgs e)
        {
            var MainForm = new MainForm();
            MainForm.Show();
        }
    }
}
