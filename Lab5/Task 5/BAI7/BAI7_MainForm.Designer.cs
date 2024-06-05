namespace LAB4
{
    partial class BAI7_MainForm
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dgvAllDish = new DataGridView();
            dishId = new DataGridViewTextBoxColumn();
            dishImage = new DataGridViewImageColumn();
            dishName = new DataGridViewTextBoxColumn();
            dishPrice = new DataGridViewTextBoxColumn();
            dishAddress = new DataGridViewTextBoxColumn();
            dishOwner = new DataGridViewTextBoxColumn();
            dishDescription = new DataGridViewTextBoxColumn();
            tabPage2 = new TabPage();
            dgvMyDish = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewImageColumn1 = new DataGridViewImageColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            btnAdd = new Button();
            btnLogin = new Button();
            lblStatus = new Label();
            btnLogout = new Button();
            label3 = new Label();
            cbPageAllDish = new ComboBox();
            label2 = new Label();
            cbPageSize = new ComboBox();
            btnDelete = new Button();
            btnRandom = new Button();
            progressBar1 = new ProgressBar();
            cbPageMyDish = new ComboBox();
            pictureBox1 = new PictureBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAllDish).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMyDish).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Enabled = false;
            tabControl1.Location = new Point(1, 55);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(668, 420);
            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dgvAllDish);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(660, 392);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Tất cả";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvAllDish
            // 
            dgvAllDish.AllowUserToAddRows = false;
            dgvAllDish.AllowUserToDeleteRows = false;
            dgvAllDish.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvAllDish.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAllDish.Columns.AddRange(new DataGridViewColumn[] { dishId, dishImage, dishName, dishPrice, dishAddress, dishOwner, dishDescription });
            dgvAllDish.Location = new Point(0, 0);
            dgvAllDish.Name = "dgvAllDish";
            dgvAllDish.RowTemplate.Height = 25;
            dgvAllDish.Size = new Size(664, 392);
            dgvAllDish.TabIndex = 1;
            // 
            // dishId
            // 
            dishId.HeaderText = "ID";
            dishId.Name = "dishId";
            dishId.Width = 30;
            // 
            // dishImage
            // 
            dishImage.HeaderText = "Hình ảnh";
            dishImage.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dishImage.Name = "dishImage";
            // 
            // dishName
            // 
            dishName.HeaderText = "Tên món ăn";
            dishName.Name = "dishName";
            // 
            // dishPrice
            // 
            dishPrice.HeaderText = "Giá";
            dishPrice.Name = "dishPrice";
            dishPrice.Width = 70;
            // 
            // dishAddress
            // 
            dishAddress.HeaderText = "Địa chỉ";
            dishAddress.Name = "dishAddress";
            // 
            // dishOwner
            // 
            dishOwner.HeaderText = "Người đóng góp";
            dishOwner.Name = "dishOwner";
            // 
            // dishDescription
            // 
            dishDescription.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dishDescription.HeaderText = "Mô tả";
            dishDescription.Name = "dishDescription";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dgvMyDish);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(660, 392);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Của tôi ";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvMyDish
            // 
            dgvMyDish.AllowUserToAddRows = false;
            dgvMyDish.AllowUserToDeleteRows = false;
            dgvMyDish.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvMyDish.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMyDish.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewImageColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6 });
            dgvMyDish.Location = new Point(0, 0);
            dgvMyDish.Name = "dgvMyDish";
            dgvMyDish.RowTemplate.Height = 25;
            dgvMyDish.Size = new Size(660, 392);
            dgvMyDish.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "ID";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 30;
            // 
            // dataGridViewImageColumn1
            // 
            dataGridViewImageColumn1.HeaderText = "Hình ảnh";
            dataGridViewImageColumn1.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Tên món ăn";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Giá";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 50;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Địa chỉ";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Người đóng góp";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn6.HeaderText = "Mô tả";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(450, 12);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(115, 51);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Thêm món ăn";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.Location = new Point(141, 491);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(70, 23);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.ForeColor = Color.Red;
            lblStatus.Location = new Point(12, 495);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(97, 15);
            lblStatus.TabIndex = 5;
            lblStatus.Text = "Unauthenticated";
            lblStatus.TextChanged += lblStatus_TextChanged;
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogout.Location = new Point(141, 493);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(70, 23);
            btnLogout.TabIndex = 7;
            btnLogout.Text = "Log out";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(587, 495);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 10;
            label3.Text = "Page size";
            // 
            // cbPageAllDish
            // 
            cbPageAllDish.Enabled = false;
            cbPageAllDish.FormattingEnabled = true;
            cbPageAllDish.Items.AddRange(new object[] { "1" });
            cbPageAllDish.Location = new Point(531, 491);
            cbPageAllDish.Name = "cbPageAllDish";
            cbPageAllDish.Size = new Size(50, 23);
            cbPageAllDish.TabIndex = 12;
            cbPageAllDish.Text = "1";
            cbPageAllDish.SelectedIndexChanged += cbPageAllDish_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(490, 495);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 11;
            label2.Text = "Page";
            // 
            // cbPageSize
            // 
            cbPageSize.Enabled = false;
            cbPageSize.FormattingEnabled = true;
            cbPageSize.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            cbPageSize.Location = new Point(648, 491);
            cbPageSize.Name = "cbPageSize";
            cbPageSize.Size = new Size(43, 23);
            cbPageSize.TabIndex = 13;
            cbPageSize.Text = "5";
            cbPageSize.SelectedIndexChanged += cbPageSize_SelectedIndexChanged;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(571, 12);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(115, 51);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Xóa món ăn";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnRandom
            // 
            btnRandom.Location = new Point(329, 12);
            btnRandom.Name = "btnRandom";
            btnRandom.Size = new Size(115, 51);
            btnRandom.TabIndex = 15;
            btnRandom.Text = "Ăn gì đây ta?";
            btnRandom.UseVisualStyleBackColor = true;
            btnRandom.Click += btnRandom_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(228, 491);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(256, 23);
            progressBar1.TabIndex = 16;
            // 
            // cbPageMyDish
            // 
            cbPageMyDish.Enabled = false;
            cbPageMyDish.FormattingEnabled = true;
            cbPageMyDish.Items.AddRange(new object[] { "1" });
            cbPageMyDish.Location = new Point(531, 491);
            cbPageMyDish.Name = "cbPageMyDish";
            cbPageMyDish.Size = new Size(50, 23);
            cbPageMyDish.TabIndex = 17;
            cbPageMyDish.Text = "1";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Artboard_1_copy_3_100;
            pictureBox1.Location = new Point(131, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(109, 61);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // BAI7_MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 528);
            Controls.Add(pictureBox1);
            Controls.Add(progressBar1);
            Controls.Add(btnRandom);
            Controls.Add(btnDelete);
            Controls.Add(btnLogin);
            Controls.Add(cbPageSize);
            Controls.Add(btnLogout);
            Controls.Add(label3);
            Controls.Add(cbPageAllDish);
            Controls.Add(label2);
            Controls.Add(lblStatus);
            Controls.Add(btnAdd);
            Controls.Add(tabControl1);
            Controls.Add(cbPageMyDish);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "BAI7_MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BAI7_MainForm";
            Load += BAI7_MainForm_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAllDish).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMyDish).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button btnAdd;
        private Button btnLogin;
        private Label lblStatus;
        private Button btnLogout;
        private Label label3;
        private ComboBox cbPageAllDish;
        private Label label2;
        private ComboBox cbPageSize;
        private Button btnDelete;
        private Button btnRandom;
        private ProgressBar progressBar1;
        private DataGridView dgvAllDish;
        private DataGridView dgvMyDish;
        private ComboBox cbPageMyDish;
        private DataGridViewTextBoxColumn dishId;
        private DataGridViewImageColumn dishImage;
        private DataGridViewTextBoxColumn dishName;
        private DataGridViewTextBoxColumn dishPrice;
        private DataGridViewTextBoxColumn dishAddress;
        private DataGridViewTextBoxColumn dishOwner;
        private DataGridViewTextBoxColumn dishDescription;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewImageColumn dataGridViewImageColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private PictureBox pictureBox1;
    }
}