namespace Lab5.Task4
{
    partial class Task4_DatVe
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
            ptbMovie = new PictureBox();
            txtEmail = new TextBox();
            label2 = new Label();
            label3 = new Label();
            cbRoom = new ComboBox();
            label1 = new Label();
            clbSeat = new CheckedListBox();
            btnBook = new Button();
            labelPhim = new Label();
            ((System.ComponentModel.ISupportInitialize)ptbMovie).BeginInit();
            SuspendLayout();
            // 
            // ptbMovie
            // 
            ptbMovie.BackgroundImageLayout = ImageLayout.Zoom;
            ptbMovie.Location = new Point(30, 12);
            ptbMovie.Name = "ptbMovie";
            ptbMovie.Size = new Size(249, 375);
            ptbMovie.SizeMode = PictureBoxSizeMode.Zoom;
            ptbMovie.TabIndex = 1;
            ptbMovie.TabStop = false;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(357, 12);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(413, 27);
            txtEmail.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(302, 19);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 6;
            label2.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(324, 83);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 8;
            label3.Text = "Chọn phòng";
            // 
            // cbRoom
            // 
            cbRoom.FormattingEnabled = true;
            cbRoom.Items.AddRange(new object[] { "1", "2", "3" });
            cbRoom.Location = new Point(324, 123);
            cbRoom.Name = "cbRoom";
            cbRoom.Size = new Size(151, 28);
            cbRoom.TabIndex = 9;
            cbRoom.SelectedIndexChanged += cbRoom_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(494, 83);
            label1.Name = "label1";
            label1.Size = new Size(109, 20);
            label1.TabIndex = 10;
            label1.Text = "Chọn ghế ngồi:";
            // 
            // clbSeat
            // 
            clbSeat.FormattingEnabled = true;
            clbSeat.Items.AddRange(new object[] { "A1", "A2", "A3", "A4", "A5", "B1", "B2", "B3", "B4", "B5", "C1", "C2", "C3", "C4", "C5" });
            clbSeat.Location = new Point(494, 123);
            clbSeat.Name = "clbSeat";
            clbSeat.Size = new Size(150, 312);
            clbSeat.TabIndex = 11;
            clbSeat.SelectedIndexChanged += clbSeat_SelectedIndexChanged;
            // 
            // btnBook
            // 
            btnBook.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBook.Location = new Point(694, 366);
            btnBook.Name = "btnBook";
            btnBook.Size = new Size(94, 69);
            btnBook.TabIndex = 12;
            btnBook.Text = "ĐẶT VÉ";
            btnBook.UseVisualStyleBackColor = true;
            btnBook.Click += btnBook_Click;
            // 
            // labelPhim
            // 
            labelPhim.AutoSize = true;
            labelPhim.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPhim.Location = new Point(44, 390);
            labelPhim.Name = "labelPhim";
            labelPhim.Size = new Size(51, 20);
            labelPhim.TabIndex = 13;
            labelPhim.Text = "label4";
            // 
            // Task4_DatVe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelPhim);
            Controls.Add(btnBook);
            Controls.Add(clbSeat);
            Controls.Add(label1);
            Controls.Add(cbRoom);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtEmail);
            Controls.Add(ptbMovie);
            Name = "Task4_DatVe";
            Text = "Task4_DatVe";
            ((System.ComponentModel.ISupportInitialize)ptbMovie).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox ptbMovie;
        private TextBox txtEmail;
        private Label label2;
        private Label label3;
        private ComboBox cbRoom;
        private Label label1;
        private CheckedListBox clbSeat;
        private Button btnBook;
        private Label labelPhim;
    }
}