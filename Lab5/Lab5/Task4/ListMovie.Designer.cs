namespace LAB4
{
    partial class ListMovie
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ptbPhim = new PictureBox();
            lblPhim = new Label();
            lblLink = new Label();
            btnDatVe = new Button();
            ((System.ComponentModel.ISupportInitialize)ptbPhim).BeginInit();
            SuspendLayout();
            // 
            // ptbPhim
            // 
            ptbPhim.Location = new Point(3, 3);
            ptbPhim.Name = "ptbPhim";
            ptbPhim.Size = new Size(125, 151);
            ptbPhim.SizeMode = PictureBoxSizeMode.Zoom;
            ptbPhim.TabIndex = 0;
            ptbPhim.TabStop = false;
            // 
            // lblPhim
            // 
            lblPhim.AutoSize = true;
            lblPhim.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPhim.ForeColor = Color.Black;
            lblPhim.Location = new Point(134, 3);
            lblPhim.Name = "lblPhim";
            lblPhim.Size = new Size(159, 41);
            lblPhim.TabIndex = 1;
            lblPhim.Text = "labelPhim";
            lblPhim.Click += lblPhim_Click;
            // 
            // lblLink
            // 
            lblLink.AutoSize = true;
            lblLink.Location = new Point(140, 53);
            lblLink.Name = "lblLink";
            lblLink.Size = new Size(50, 20);
            lblLink.TabIndex = 2;
            lblLink.Text = "label1";
            // 
            // btnDatVe
            // 
            btnDatVe.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDatVe.Location = new Point(535, 125);
            btnDatVe.Name = "btnDatVe";
            btnDatVe.Size = new Size(138, 29);
            btnDatVe.TabIndex = 3;
            btnDatVe.Text = "ĐẶT VÉ";
            btnDatVe.UseVisualStyleBackColor = true;
            btnDatVe.Click += btnBook_Click;
            // 
            // ListMovie
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnDatVe);
            Controls.Add(lblLink);
            Controls.Add(lblPhim);
            Controls.Add(ptbPhim);
            Name = "ListMovie";
            Size = new Size(676, 157);
            Load += ListMovie_Load;
            ((System.ComponentModel.ISupportInitialize)ptbPhim).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox ptbPhim;
        private Label lblPhim;
        private Label lblLink;
        private Button btnDatVe;
    }
}
