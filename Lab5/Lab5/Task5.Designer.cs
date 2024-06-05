namespace Lab5
{
    partial class Task5
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
            grb_SignIn = new GroupBox();
            label1 = new Label();
            btn_Send = new Button();
            btn_Refresh = new Button();
            label2 = new Label();
            btn_SignIn = new Button();
            tbx_password = new TextBox();
            tbx_account = new TextBox();
            grb_Setting = new GroupBox();
            label6 = new Label();
            label5 = new Label();
            domainUpDown2 = new DomainUpDown();
            domainUpDown1 = new DomainUpDown();
            label4 = new Label();
            label3 = new Label();
            tbx_IMAP = new TextBox();
            tbx_SMTP = new TextBox();
            listView1 = new ListView();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            pn_readmail = new Panel();
            btn_Reply = new Button();
            richTextBox1 = new RichTextBox();
            pictureBox1 = new PictureBox();
            btn_Back = new Button();
            lblSubject = new Label();
            lblTo = new Label();
            lblFrom = new Label();
            pn_SendMail = new Panel();
            linkLabel1 = new LinkLabel();
            btn_attach = new Button();
            btn_Back2 = new Button();
            button1 = new Button();
            rtbBody = new RichTextBox();
            label8 = new Label();
            tbSubject = new TextBox();
            label7 = new Label();
            tbToMail = new TextBox();
            openFileDialog1 = new OpenFileDialog();
            grb_SignIn.SuspendLayout();
            grb_Setting.SuspendLayout();
            pn_readmail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pn_SendMail.SuspendLayout();
            SuspendLayout();
            // 
            // grb_SignIn
            // 
            grb_SignIn.Controls.Add(label1);
            grb_SignIn.Controls.Add(btn_Send);
            grb_SignIn.Controls.Add(btn_Refresh);
            grb_SignIn.Controls.Add(label2);
            grb_SignIn.Controls.Add(btn_SignIn);
            grb_SignIn.Controls.Add(tbx_password);
            grb_SignIn.Controls.Add(tbx_account);
            grb_SignIn.Location = new Point(21, 17);
            grb_SignIn.Name = "grb_SignIn";
            grb_SignIn.Size = new Size(328, 125);
            grb_SignIn.TabIndex = 0;
            grb_SignIn.TabStop = false;
            grb_SignIn.Text = "Đăng nhập";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 33);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 8;
            label1.Text = "Tài khoản";
            // 
            // btn_Send
            // 
            btn_Send.BackColor = SystemColors.ActiveCaption;
            btn_Send.Location = new Point(5, 90);
            btn_Send.Name = "btn_Send";
            btn_Send.Size = new Size(90, 29);
            btn_Send.TabIndex = 7;
            btn_Send.Text = "Gửi mail";
            btn_Send.UseVisualStyleBackColor = false;
            btn_Send.Visible = false;
            btn_Send.Click += btn_Send_Click_1;
            // 
            // btn_Refresh
            // 
            btn_Refresh.BackColor = SystemColors.ActiveCaption;
            btn_Refresh.Location = new Point(102, 90);
            btn_Refresh.Name = "btn_Refresh";
            btn_Refresh.Size = new Size(74, 29);
            btn_Refresh.TabIndex = 6;
            btn_Refresh.Text = "Refresh";
            btn_Refresh.UseVisualStyleBackColor = false;
            btn_Refresh.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 66);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 4;
            label2.Text = "Mật khẩu";
            // 
            // btn_SignIn
            // 
            btn_SignIn.BackColor = SystemColors.ActiveCaption;
            btn_SignIn.Location = new Point(182, 90);
            btn_SignIn.Name = "btn_SignIn";
            btn_SignIn.Size = new Size(130, 29);
            btn_SignIn.TabIndex = 2;
            btn_SignIn.Tag = "1";
            btn_SignIn.Text = "Đăng nhập";
            btn_SignIn.UseVisualStyleBackColor = false;
            btn_SignIn.Click += btn_SignIn_Click;
            // 
            // tbx_password
            // 
            tbx_password.Location = new Point(114, 59);
            tbx_password.Name = "tbx_password";
            tbx_password.Size = new Size(198, 27);
            tbx_password.TabIndex = 1;
            // 
            // tbx_account
            // 
            tbx_account.Location = new Point(114, 26);
            tbx_account.Name = "tbx_account";
            tbx_account.Size = new Size(198, 27);
            tbx_account.TabIndex = 0;
            // 
            // grb_Setting
            // 
            grb_Setting.Controls.Add(label6);
            grb_Setting.Controls.Add(label5);
            grb_Setting.Controls.Add(domainUpDown2);
            grb_Setting.Controls.Add(domainUpDown1);
            grb_Setting.Controls.Add(label4);
            grb_Setting.Controls.Add(label3);
            grb_Setting.Controls.Add(tbx_IMAP);
            grb_Setting.Controls.Add(tbx_SMTP);
            grb_Setting.Location = new Point(355, 17);
            grb_Setting.Name = "grb_Setting";
            grb_Setting.Size = new Size(543, 125);
            grb_Setting.TabIndex = 1;
            grb_Setting.TabStop = false;
            grb_Setting.Text = "Cài đặt";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(300, 87);
            label6.Name = "label6";
            label6.Size = new Size(35, 20);
            label6.TabIndex = 10;
            label6.Text = "Port";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 87);
            label5.Name = "label5";
            label5.Size = new Size(35, 20);
            label5.TabIndex = 9;
            label5.Text = "Port";
            // 
            // domainUpDown2
            // 
            domainUpDown2.Location = new Point(341, 80);
            domainUpDown2.Name = "domainUpDown2";
            domainUpDown2.Size = new Size(184, 27);
            domainUpDown2.TabIndex = 8;
            domainUpDown2.Text = "0";
            // 
            // domainUpDown1
            // 
            domainUpDown1.Location = new Point(67, 80);
            domainUpDown1.Name = "domainUpDown1";
            domainUpDown1.Size = new Size(184, 27);
            domainUpDown1.TabIndex = 7;
            domainUpDown1.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(289, 33);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 6;
            label4.Text = "SMTP";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 33);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 5;
            label3.Text = "IMAP";
            // 
            // tbx_IMAP
            // 
            tbx_IMAP.Location = new Point(67, 26);
            tbx_IMAP.Name = "tbx_IMAP";
            tbx_IMAP.Size = new Size(184, 27);
            tbx_IMAP.TabIndex = 3;
            // 
            // tbx_SMTP
            // 
            tbx_SMTP.Location = new Point(341, 26);
            tbx_SMTP.Name = "tbx_SMTP";
            tbx_SMTP.Size = new Size(184, 27);
            tbx_SMTP.TabIndex = 2;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader2, columnHeader3, columnHeader4 });
            listView1.Location = new Point(21, 163);
            listView1.Name = "listView1";
            listView1.Size = new Size(877, 429);
            listView1.TabIndex = 2;
            listView1.TileSize = new Size(300, 44);
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "From";
            columnHeader2.Width = 250;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Subject";
            columnHeader3.Width = 400;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Datetime";
            columnHeader4.Width = 170;
            // 
            // pn_readmail
            // 
            pn_readmail.Controls.Add(btn_Reply);
            pn_readmail.Controls.Add(richTextBox1);
            pn_readmail.Controls.Add(pictureBox1);
            pn_readmail.Controls.Add(btn_Back);
            pn_readmail.Controls.Add(lblSubject);
            pn_readmail.Controls.Add(lblTo);
            pn_readmail.Controls.Add(lblFrom);
            pn_readmail.Location = new Point(21, 160);
            pn_readmail.Name = "pn_readmail";
            pn_readmail.Size = new Size(877, 440);
            pn_readmail.TabIndex = 3;
            pn_readmail.Tag = "";
            pn_readmail.Visible = false;
            // 
            // btn_Reply
            // 
            btn_Reply.BackColor = Color.IndianRed;
            btn_Reply.Location = new Point(769, 8);
            btn_Reply.Name = "btn_Reply";
            btn_Reply.Size = new Size(90, 68);
            btn_Reply.TabIndex = 11;
            btn_Reply.Text = "Trả lời";
            btn_Reply.UseVisualStyleBackColor = false;
            btn_Reply.Click += btn_Reply_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(21, 117);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(838, 301);
            richTextBox1.TabIndex = 7;
            richTextBox1.Text = "";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(334, 127);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(232, 62);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // btn_Back
            // 
            btn_Back.BackColor = SystemColors.ActiveCaption;
            btn_Back.Location = new Point(769, 82);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new Size(90, 29);
            btn_Back.TabIndex = 9;
            btn_Back.Text = "Trở lại";
            btn_Back.UseVisualStyleBackColor = false;
            btn_Back.Click += btn_Back_Click;
            // 
            // lblSubject
            // 
            lblSubject.AutoSize = true;
            lblSubject.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubject.Location = new Point(24, 62);
            lblSubject.Name = "lblSubject";
            lblSubject.Size = new Size(60, 28);
            lblSubject.TabIndex = 6;
            lblSubject.Text = "Title:";
            // 
            // lblTo
            // 
            lblTo.AutoSize = true;
            lblTo.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTo.Location = new Point(25, 39);
            lblTo.Name = "lblTo";
            lblTo.Size = new Size(33, 23);
            lblTo.TabIndex = 5;
            lblTo.Text = "To:";
            // 
            // lblFrom
            // 
            lblFrom.AutoSize = true;
            lblFrom.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFrom.Location = new Point(24, 16);
            lblFrom.Name = "lblFrom";
            lblFrom.Size = new Size(52, 23);
            lblFrom.TabIndex = 4;
            lblFrom.Text = "From";
            // 
            // pn_SendMail
            // 
            pn_SendMail.Controls.Add(linkLabel1);
            pn_SendMail.Controls.Add(btn_attach);
            pn_SendMail.Controls.Add(btn_Back2);
            pn_SendMail.Controls.Add(button1);
            pn_SendMail.Controls.Add(rtbBody);
            pn_SendMail.Controls.Add(label8);
            pn_SendMail.Controls.Add(tbSubject);
            pn_SendMail.Controls.Add(label7);
            pn_SendMail.Controls.Add(tbToMail);
            pn_SendMail.Location = new Point(21, 163);
            pn_SendMail.Name = "pn_SendMail";
            pn_SendMail.Size = new Size(877, 440);
            pn_SendMail.TabIndex = 11;
            pn_SendMail.Visible = false;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(88, 357);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(0, 20);
            linkLabel1.TabIndex = 17;
            // 
            // btn_attach
            // 
            btn_attach.BackColor = SystemColors.ActiveCaption;
            btn_attach.Location = new Point(736, 353);
            btn_attach.Name = "btn_attach";
            btn_attach.Size = new Size(90, 29);
            btn_attach.TabIndex = 16;
            btn_attach.Text = "Đính kèm";
            btn_attach.UseVisualStyleBackColor = false;
            btn_attach.Click += btn_attach_Click;
            // 
            // btn_Back2
            // 
            btn_Back2.BackColor = SystemColors.ActiveCaption;
            btn_Back2.Location = new Point(749, 14);
            btn_Back2.Name = "btn_Back2";
            btn_Back2.Size = new Size(90, 29);
            btn_Back2.TabIndex = 12;
            btn_Back2.Text = "Trở lại";
            btn_Back2.UseVisualStyleBackColor = false;
            btn_Back2.Click += btn_Back2_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(79, 400);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 14;
            button1.Text = "SEND";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // rtbBody
            // 
            rtbBody.Location = new Point(79, 117);
            rtbBody.Name = "rtbBody";
            rtbBody.Size = new Size(760, 277);
            rtbBody.TabIndex = 13;
            rtbBody.Text = "";
            rtbBody.TextChanged += rtbBody_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(6, 67);
            label8.Name = "label8";
            label8.Size = new Size(66, 23);
            label8.TabIndex = 12;
            label8.Text = "Subject";
            // 
            // tbSubject
            // 
            tbSubject.Location = new Point(79, 62);
            tbSubject.Name = "tbSubject";
            tbSubject.Size = new Size(760, 27);
            tbSubject.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(46, 16);
            label7.Name = "label7";
            label7.Size = new Size(27, 23);
            label7.TabIndex = 10;
            label7.Text = "To";
            // 
            // tbToMail
            // 
            tbToMail.Location = new Point(79, 12);
            tbToMail.Name = "tbToMail";
            tbToMail.Size = new Size(411, 27);
            tbToMail.TabIndex = 3;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Task5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(924, 615);
            Controls.Add(grb_Setting);
            Controls.Add(grb_SignIn);
            Controls.Add(pn_SendMail);
            Controls.Add(listView1);
            Controls.Add(pn_readmail);
            Name = "Task5";
            Text = "Task5";
            grb_SignIn.ResumeLayout(false);
            grb_SignIn.PerformLayout();
            grb_Setting.ResumeLayout(false);
            grb_Setting.PerformLayout();
            pn_readmail.ResumeLayout(false);
            pn_readmail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pn_SendMail.ResumeLayout(false);
            pn_SendMail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grb_SignIn;
        private Button btn_SignIn;
        private TextBox tbx_password;
        private TextBox tbx_account;
        private GroupBox grb_Setting;
        private TextBox tbx_SMTP;
        private TextBox tbx_IMAP;
        private Label label2;
        private Label label6;
        private Label label5;
        private DomainUpDown domainUpDown2;
        private DomainUpDown domainUpDown1;
        private Label label4;
        private Label label3;
        private ListView listView1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Button btn_Refresh;
        private Panel pn_readmail;
        private Label lblFrom;
        private Label lblTo;
        private Label lblSubject;
        private RichTextBox richTextBox1;
        private Button btn_Back;
        private PictureBox pictureBox1;
        private Panel pn_SendMail;
        private Label label7;
        private TextBox tbToMail;
        private TextBox tbSubject;
        private Label label8;
        private RichTextBox rtbBody;
        private Button button1;
        private Button btn_Send;
        private Label label1;
        private Button btn_Back2;
        private Button btn_Reply;
        private OpenFileDialog openFileDialog1;
        private Button btn_attach;
        private LinkLabel linkLabel1;
    }
}