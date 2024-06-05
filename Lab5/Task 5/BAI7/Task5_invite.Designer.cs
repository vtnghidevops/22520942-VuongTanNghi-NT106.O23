namespace LAB4.BAI7
{
    partial class Task5_invite
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label1 = new Label();
            tb_MailAddress = new TextBox();
            btn_addMailAddr = new Button();
            btn_Preview = new Button();
            btn_Send = new Button();
            rtb_ListEmail = new RichTextBox();
            panel1 = new Panel();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            btn_CheckConnect = new Button();
            label_connectStatus = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 287);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 0;
            label1.Text = "Email";
            // 
            // tb_MailAddress
            // 
            tb_MailAddress.Location = new Point(118, 287);
            tb_MailAddress.Margin = new Padding(3, 4, 3, 4);
            tb_MailAddress.Name = "tb_MailAddress";
            tb_MailAddress.Size = new Size(405, 27);
            tb_MailAddress.TabIndex = 1;
            // 
            // btn_addMailAddr
            // 
            btn_addMailAddr.Location = new Point(554, 287);
            btn_addMailAddr.Margin = new Padding(3, 4, 3, 4);
            btn_addMailAddr.Name = "btn_addMailAddr";
            btn_addMailAddr.Size = new Size(86, 31);
            btn_addMailAddr.TabIndex = 3;
            btn_addMailAddr.Text = "add";
            btn_addMailAddr.UseVisualStyleBackColor = true;
            btn_addMailAddr.Click += btn_addMailAddr_Click;
            // 
            // btn_Preview
            // 
            btn_Preview.Location = new Point(583, 524);
            btn_Preview.Margin = new Padding(3, 4, 3, 4);
            btn_Preview.Name = "btn_Preview";
            btn_Preview.Size = new Size(86, 31);
            btn_Preview.TabIndex = 4;
            btn_Preview.Text = "Preview";
            btn_Preview.UseVisualStyleBackColor = true;
            btn_Preview.Click += btn_Preview_Click;
            // 
            // btn_Send
            // 
            btn_Send.Location = new Point(688, 524);
            btn_Send.Margin = new Padding(3, 4, 3, 4);
            btn_Send.Name = "btn_Send";
            btn_Send.Size = new Size(86, 31);
            btn_Send.TabIndex = 5;
            btn_Send.Text = "Send";
            btn_Send.UseVisualStyleBackColor = true;
            btn_Send.Click += btn_Send_Click;
            // 
            // rtb_ListEmail
            // 
            rtb_ListEmail.Location = new Point(118, 321);
            rtb_ListEmail.Name = "rtb_ListEmail";
            rtb_ListEmail.Size = new Size(514, 167);
            rtb_ListEmail.TabIndex = 0;
            rtb_ListEmail.Text = "";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 224, 192);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(43, 11);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(759, 245);
            panel1.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.IndianRed;
            label7.Location = new Point(391, 181);
            label7.Name = "label7";
            label7.Size = new Size(65, 25);
            label7.TabIndex = 7;
            label7.Text = "label7";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.IndianRed;
            label6.Location = new Point(391, 129);
            label6.Name = "label6";
            label6.Size = new Size(65, 25);
            label6.TabIndex = 6;
            label6.Text = "label6";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.IndianRed;
            label5.Location = new Point(391, 77);
            label5.Name = "label5";
            label5.Size = new Size(65, 25);
            label5.TabIndex = 5;
            label5.Text = "label5";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(243, 188);
            label4.Name = "label4";
            label4.Size = new Size(132, 20);
            label4.TabIndex = 4;
            label4.Text = "Người đóng góp: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(243, 136);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 3;
            label3.Text = "Địa Chỉ: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(243, 84);
            label2.Name = "label2";
            label2.Size = new Size(40, 20);
            label2.TabIndex = 2;
            label2.Text = "Giá: ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Firebrick;
            label8.Location = new Point(243, 19);
            label8.Name = "label8";
            label8.Size = new Size(96, 37);
            label8.TabIndex = 1;
            label8.Text = "label8";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(22, 19);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(191, 201);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btn_CheckConnect
            // 
            btn_CheckConnect.Location = new Point(414, 526);
            btn_CheckConnect.Name = "btn_CheckConnect";
            btn_CheckConnect.Size = new Size(141, 29);
            btn_CheckConnect.TabIndex = 7;
            btn_CheckConnect.Text = "Check Connection";
            btn_CheckConnect.UseVisualStyleBackColor = true;
            btn_CheckConnect.Click += btn_CheckConnect_Click;
            // 
            // label_connectStatus
            // 
            label_connectStatus.AutoSize = true;
            label_connectStatus.Location = new Point(43, 524);
            label_connectStatus.Name = "label_connectStatus";
            label_connectStatus.Size = new Size(50, 20);
            label_connectStatus.TabIndex = 8;
            label_connectStatus.Text = "label9";
            // 
            // Task5_invite
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(885, 590);
            Controls.Add(label_connectStatus);
            Controls.Add(btn_CheckConnect);
            Controls.Add(panel1);
            Controls.Add(rtb_ListEmail);
            Controls.Add(btn_Send);
            Controls.Add(btn_Preview);
            Controls.Add(btn_addMailAddr);
            Controls.Add(tb_MailAddress);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Task5_invite";
            Text = "Invite";
            Load += Task5_invite_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label1;
        private TextBox tb_MailAddress;
        private Button btn_addMailAddr;
        private Button btn_Preview;
        private Button btn_Send;
        private RichTextBox rtb_ListEmail;
        private Panel panel1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label8;
        private PictureBox pictureBox1;
        private Button btn_CheckConnect;
        private Label label_connectStatus;
    }
}