namespace Lab2
{
    partial class Ex5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            tb_CustomerName = new TextBox();
            btn_ReadFromFile = new Button();
            A1 = new CheckedListBox();
            clb_B = new CheckedListBox();
            clb_C = new CheckedListBox();
            label2 = new Label();
            label3 = new Label();
            cb_NameofFilm = new ComboBox();
            label4 = new Label();
            cb_Room = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            btn_DatVe = new Button();
            btn_XuatThongKe = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SF Mono", 12F, FontStyle.Bold);
            label1.Location = new Point(61, 128);
            label1.Name = "label1";
            label1.Size = new Size(178, 24);
            label1.TabIndex = 0;
            label1.Text = "Tên khách hàng";
            // 
            // tb_CustomerName
            // 
            tb_CustomerName.Font = new Font("SF Mono", 10.2F);
            tb_CustomerName.Location = new Point(245, 128);
            tb_CustomerName.Name = "tb_CustomerName";
            tb_CustomerName.Size = new Size(231, 28);
            tb_CustomerName.TabIndex = 1;
            // 
            // btn_ReadFromFile
            // 
            btn_ReadFromFile.BackColor = SystemColors.ButtonShadow;
            btn_ReadFromFile.Font = new Font("SF Mono", 12F, FontStyle.Bold);
            btn_ReadFromFile.ForeColor = SystemColors.ControlText;
            btn_ReadFromFile.Location = new Point(171, 33);
            btn_ReadFromFile.Name = "btn_ReadFromFile";
            btn_ReadFromFile.Size = new Size(276, 60);
            btn_ReadFromFile.TabIndex = 2;
            btn_ReadFromFile.Text = "Tải dữ liệu từ file";
            btn_ReadFromFile.UseVisualStyleBackColor = false;
            btn_ReadFromFile.Click += btn_ReadFromFile_Click;
            // 
            // A1
            // 
            A1.Font = new Font("SF Mono", 10.2F);
            A1.FormattingEnabled = true;
            A1.Items.AddRange(new object[] { "A1", "A2", "A3", "A4", "A5" });
            A1.Location = new Point(100, 355);
            A1.Name = "A1";
            A1.Size = new Size(103, 96);
            A1.TabIndex = 3;
            // 
            // clb_B
            // 
            clb_B.Font = new Font("SF Mono", 10.2F);
            clb_B.FormattingEnabled = true;
            clb_B.Items.AddRange(new object[] { "", "B2", "B3", "B4", "" });
            clb_B.Location = new Point(266, 355);
            clb_B.Name = "clb_B";
            clb_B.Size = new Size(106, 96);
            clb_B.TabIndex = 4;
            // 
            // clb_C
            // 
            clb_C.Font = new Font("SF Mono", 10.2F);
            clb_C.FormattingEnabled = true;
            clb_C.Items.AddRange(new object[] { "C1", "C2", "C3", "C4", "C5" });
            clb_C.Location = new Point(436, 355);
            clb_C.Name = "clb_C";
            clb_C.Size = new Size(102, 96);
            clb_C.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SF Mono", 12F, FontStyle.Bold);
            label2.Location = new Point(30, 198);
            label2.Name = "label2";
            label2.Size = new Size(106, 24);
            label2.TabIndex = 6;
            label2.Text = "Tên phim";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SF Mono", 12F, FontStyle.Bold);
            label3.Location = new Point(316, 198);
            label3.Name = "label3";
            label3.Size = new Size(142, 24);
            label3.TabIndex = 7;
            label3.Text = "Phòng chiếu";
            // 
            // cb_NameofFilm
            // 
            cb_NameofFilm.Font = new Font("SF Mono", 10.2F);
            cb_NameofFilm.FormattingEnabled = true;
            cb_NameofFilm.Location = new Point(142, 196);
            cb_NameofFilm.Name = "cb_NameofFilm";
            cb_NameofFilm.Size = new Size(151, 28);
            cb_NameofFilm.TabIndex = 8;
            cb_NameofFilm.SelectedIndexChanged += cb_NameofFilm_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("SF Mono", 12F, FontStyle.Bold);
            label4.Location = new Point(436, 196);
            label4.Name = "label4";
            label4.Size = new Size(0, 24);
            label4.TabIndex = 9;
            // 
            // cb_Room
            // 
            cb_Room.Font = new Font("SF Mono", 10.2F);
            cb_Room.FormattingEnabled = true;
            cb_Room.Location = new Point(461, 196);
            cb_Room.Name = "cb_Room";
            cb_Room.Size = new Size(151, 28);
            cb_Room.TabIndex = 10;
            cb_Room.SelectedIndexChanged += cb_Room_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("SF Mono", 12F, FontStyle.Bold);
            label5.Location = new Point(266, 249);
            label5.Name = "label5";
            label5.Size = new Size(106, 24);
            label5.TabIndex = 11;
            label5.Text = "Chọn ghế";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("SF Mono", 12F, FontStyle.Bold);
            label6.Location = new Point(119, 297);
            label6.Name = "label6";
            label6.Size = new Size(0, 24);
            label6.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("SF Mono", 12F, FontStyle.Bold);
            label7.Location = new Point(100, 321);
            label7.Name = "label7";
            label7.Size = new Size(82, 24);
            label7.TabIndex = 13;
            label7.Text = "Hàng 1";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("SF Mono", 12F, FontStyle.Bold);
            label8.Location = new Point(266, 319);
            label8.Name = "label8";
            label8.Size = new Size(82, 24);
            label8.TabIndex = 14;
            label8.Text = "Hàng 2";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("SF Mono", 12F, FontStyle.Bold);
            label9.Location = new Point(436, 321);
            label9.Name = "label9";
            label9.Size = new Size(82, 24);
            label9.TabIndex = 15;
            label9.Text = "Hàng 3";
            // 
            // btn_DatVe
            // 
            btn_DatVe.BackColor = SystemColors.AppWorkspace;
            btn_DatVe.Font = new Font("SF Mono", 12F, FontStyle.Bold);
            btn_DatVe.Location = new Point(100, 525);
            btn_DatVe.Name = "btn_DatVe";
            btn_DatVe.Size = new Size(135, 46);
            btn_DatVe.TabIndex = 16;
            btn_DatVe.Text = "Đặt vé";
            btn_DatVe.UseVisualStyleBackColor = false;
            btn_DatVe.Click += btn_DatVe_Click;
            // 
            // btn_XuatThongKe
            // 
            btn_XuatThongKe.BackColor = SystemColors.AppWorkspace;
            btn_XuatThongKe.Font = new Font("SF Mono", 12F, FontStyle.Bold);
            btn_XuatThongKe.Location = new Point(335, 525);
            btn_XuatThongKe.Name = "btn_XuatThongKe";
            btn_XuatThongKe.Size = new Size(220, 46);
            btn_XuatThongKe.TabIndex = 17;
            btn_XuatThongKe.Text = "Xuất thống kê";
            btn_XuatThongKe.UseVisualStyleBackColor = false;
            btn_XuatThongKe.Click += btn_XuatThongKe_Click;
            // 
            // Ex5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 611);
            Controls.Add(btn_XuatThongKe);
            Controls.Add(btn_DatVe);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(cb_Room);
            Controls.Add(label4);
            Controls.Add(cb_NameofFilm);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(clb_C);
            Controls.Add(clb_B);
            Controls.Add(A1);
            Controls.Add(btn_ReadFromFile);
            Controls.Add(tb_CustomerName);
            Controls.Add(label1);
            Name = "Ex5";
            Text = "Ex5";
            FormClosed += Ex5_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tb_CustomerName;
        private Button btn_ReadFromFile;
        private CheckedListBox A1;
        private CheckedListBox clb_B;
        private CheckedListBox clb_C;
        private Label label2;
        private Label label3;
        private ComboBox cb_NameofFilm;
        private Label label4;
        private ComboBox cb_Room;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button btn_DatVe;
        private Button btn_XuatThongKe;
    }
}