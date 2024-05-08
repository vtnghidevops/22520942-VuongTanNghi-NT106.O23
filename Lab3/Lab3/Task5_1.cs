using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Lab3
{
    public partial class Task5_1 : Form
    {
        public Task5_1()
        {
            InitializeComponent();
            var sql = "Data Source=Lab3_Bai5.db";
            SQLiteConnection conn = new SQLiteConnection(sql);
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btn_Random_Click(object sender, EventArgs e)
        {
            if (lvList.Items.Count == 0)
            {
                MessageBox.Show("Chưa có món ăn nào được nhập!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var sql = "Data Source = Lab3_Bai5.db";
            SQLiteConnection conn = new SQLiteConnection(sql);
            conn.Open();
            sql = "SELECT MonAn.*, NguoiDung.HoVaTen FROM MonAn INNER JOIN NguoiDung ON MonAn.IDNCC = NguoiDung.IDNCC ORDER BY RANDOM() LIMIT 1";
            var cmd = new SQLiteCommand(sql, conn);
            SQLiteDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                groupBoxAn.Text = "Món ăn: " + rd["TenMonAn"].ToString() + "         Tên: " + rd["HoVaTen"].ToString();
                byte[] ImageData = (byte[])rd["HinhAnh"];
                using (MemoryStream ms = new MemoryStream(ImageData))
                {
                    Image image = Image.FromStream(ms);
                    PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    PictureBox.Image = image;
                }
            }
        }

        private void btn_ListMonAn_Click(object sender, EventArgs e)
        {
            try
            {
                var sql = "Data Source = Lab3_Bai5.db";
                SQLiteConnection conn = new SQLiteConnection(sql);
                conn.Open();
                sql = "SELECT * FROM MonAn";
                var cmd = new SQLiteCommand(sql, conn);
                SQLiteDataReader rd = cmd.ExecuteReader();
                lvList.Items.Clear();
                while (rd.Read())
                {
                    ListViewItem item = new ListViewItem(rd["IDMA"].ToString());
                    item.SubItems.Add(rd["TenMonAn"].ToString());
                    lvList.Items.Add(item);
                }
                cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
