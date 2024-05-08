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
    public partial class Task5 : Form
    {
        public Task5()
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

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void InserDataMonAn(SQLiteConnection conn, string IDMA, string TenMonAn, string IDNCC)
        {
            byte[] imageBt = null;
            FileStream fstream = new FileStream(this.tbPath.Text, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fstream);
            imageBt = br.ReadBytes((int)fstream.Length);

            var sql = "INSERT INTO MonAn(IDMA, TenMonAn, IDNCC, HinhAnh) "
                + "VALUES(@IDMA, @TenMonAn, @IDNCC, @IMG)";
            var cmd = new SQLiteCommand(sql, conn);
            cmd.Parameters.AddWithValue("@IDMA", IDMA);
            cmd.Parameters.AddWithValue("@TenMonAn", TenMonAn);
            cmd.Parameters.AddWithValue("@IDNCC", IDNCC);
            cmd.Parameters.AddWithValue("@IMG", imageBt);
            cmd.ExecuteNonQuery();
        }

        private void btn_themMonAn_Click(object sender, EventArgs e)
        {
            var sql = "Data Source=Lab3_Bai5.db";
            SQLiteConnection conn = new SQLiteConnection(sql);
            try
            {
                if (tbIDMA.Text == null || tbTenMonAn.Text == null || tbIDNCC1 == null)
                {
                    MessageBox.Show("Thông tin món ăn còn thiếu. Yêu cầu bổ sung!!");
                }
                else
                {
                    conn.Open();
                    InserDataMonAn(conn, tbIDMA.Text, tbTenMonAn.Text, tbIDNCC1.Text);
                    MessageBox.Show("Thêm thành công");
                    tbIDMA.Text = null;
                    tbIDNCC1.Text = null;
                    tbTenMonAn.Text = null;
                    PictureBox.Image = null;
                    tbPath.Text = null;
                }
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

        private static void InserDataNguoiDung(SQLiteConnection conn, string IDNCC, string HoVaTen, string QuyenHan)
        {
            var sql = "INSERT INTO NguoiDung(IDNCC, HoVaTen, QuyenHan) "
                + "VALUES(@IDNCC, @HoVaTen, @QuyenHan)";
            var cmd = new SQLiteCommand(sql, conn);
            cmd.Parameters.AddWithValue("@IDNCC", IDNCC);
            cmd.Parameters.AddWithValue("@HoVaTen", HoVaTen);
            cmd.Parameters.AddWithValue("@QuyenHan", QuyenHan);
            cmd.ExecuteNonQuery();
        }

        private void btn_themNCC_Click(object sender, EventArgs e)
        {
            var sql = "Data Source=Lab3_Bai5.db";
            SQLiteConnection conn = new SQLiteConnection(sql);
            try
            {
                if (tbIDNCC.Text == null || tbHoTen.Text == null || tbPath.Text == null)
                {
                    MessageBox.Show("Thông tin của người cung cấp bị thiếu sót. Yêu cầu bổ sung!!");
                }
                else
                {
                    conn.Open();
                    InserDataNguoiDung(conn, tbIDNCC.Text, tbHoTen.Text, tbQuyenHan.Text);
                    MessageBox.Show("Thêm thành công");
                    tbIDNCC.Text = null;
                    tbHoTen.Text = null;
                    tbQuyenHan.Text = null;
                }
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

        private void btn_Next_Click(object sender, EventArgs e)
        {
            this.Hide();
            Task5_1 task5 = new Task5_1();
            task5.Show();
        }

        private void btn_LoadPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|All Files(*.*)|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string pic = dlg.FileName.ToString();
                tbPath.Text = pic;
                PictureBox.ImageLocation = pic;
            }
        }
    }
}
