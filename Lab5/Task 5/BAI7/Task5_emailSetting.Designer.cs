namespace LAB4.BAI7
{
    partial class Task5_emailSetting
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            groupBox1 = new GroupBox();
            domainUpDown2 = new DomainUpDown();
            domainUpDown1 = new DomainUpDown();
            checkBox2 = new CheckBox();
            cb_IMAP_requireSll = new CheckBox();
            tb_SMPT = new TextBox();
            tb_IMAP = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            tb_PassWord = new TextBox();
            tb_Username = new TextBox();
            tb_NickName = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            btn_TestConnect = new Button();
            btn_Save = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(34, 59);
            label1.Name = "label1";
            label1.Size = new Size(219, 46);
            label1.TabIndex = 0;
            label1.Text = "Email Config";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(domainUpDown2);
            groupBox1.Controls.Add(domainUpDown1);
            groupBox1.Controls.Add(checkBox2);
            groupBox1.Controls.Add(cb_IMAP_requireSll);
            groupBox1.Controls.Add(tb_SMPT);
            groupBox1.Controls.Add(tb_IMAP);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(34, 145);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(725, 189);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Email Server Configuration";
            // 
            // domainUpDown2
            // 
            domainUpDown2.Location = new Point(475, 76);
            domainUpDown2.Name = "domainUpDown2";
            domainUpDown2.Size = new Size(150, 27);
            domainUpDown2.TabIndex = 10;
            domainUpDown2.Text = "465";
            // 
            // domainUpDown1
            // 
            domainUpDown1.Location = new Point(86, 76);
            domainUpDown1.Name = "domainUpDown1";
            domainUpDown1.Size = new Size(150, 27);
            domainUpDown1.TabIndex = 9;
            domainUpDown1.Text = "993";
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Checked = true;
            checkBox2.CheckState = CheckState.Checked;
            checkBox2.Location = new Point(452, 128);
            checkBox2.Margin = new Padding(3, 4, 3, 4);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(96, 24);
            checkBox2.TabIndex = 8;
            checkBox2.Text = "require sll";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // cb_IMAP_requireSll
            // 
            cb_IMAP_requireSll.AutoSize = true;
            cb_IMAP_requireSll.Checked = true;
            cb_IMAP_requireSll.CheckState = CheckState.Checked;
            cb_IMAP_requireSll.Location = new Point(86, 128);
            cb_IMAP_requireSll.Margin = new Padding(3, 4, 3, 4);
            cb_IMAP_requireSll.Name = "cb_IMAP_requireSll";
            cb_IMAP_requireSll.Size = new Size(96, 24);
            cb_IMAP_requireSll.TabIndex = 3;
            cb_IMAP_requireSll.Text = "require sll";
            cb_IMAP_requireSll.UseVisualStyleBackColor = true;
            // 
            // tb_SMPT
            // 
            tb_SMPT.Location = new Point(475, 29);
            tb_SMPT.Margin = new Padding(3, 4, 3, 4);
            tb_SMPT.Name = "tb_SMPT";
            tb_SMPT.Size = new Size(244, 27);
            tb_SMPT.TabIndex = 5;
            tb_SMPT.Text = "smtp.gmail.com";
            // 
            // tb_IMAP
            // 
            tb_IMAP.Location = new Point(86, 29);
            tb_IMAP.Margin = new Padding(3, 4, 3, 4);
            tb_IMAP.Name = "tb_IMAP";
            tb_IMAP.Size = new Size(265, 27);
            tb_IMAP.TabIndex = 4;
            tb_IMAP.Text = "imap.gmail.com";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(378, 68);
            label5.Name = "label5";
            label5.Size = new Size(78, 20);
            label5.TabIndex = 3;
            label5.Text = "SMTP port";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(400, 32);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 2;
            label4.Text = "SMTP";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 83);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 1;
            label3.Text = "IMAP port";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 39);
            label2.Name = "label2";
            label2.Size = new Size(44, 20);
            label2.TabIndex = 0;
            label2.Text = "IMAP";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tb_PassWord);
            groupBox2.Controls.Add(tb_Username);
            groupBox2.Controls.Add(tb_NickName);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(34, 375);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(399, 172);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Account";
            // 
            // tb_PassWord
            // 
            tb_PassWord.Location = new Point(105, 125);
            tb_PassWord.Margin = new Padding(3, 4, 3, 4);
            tb_PassWord.Name = "tb_PassWord";
            tb_PassWord.Size = new Size(274, 27);
            tb_PassWord.TabIndex = 5;
            // 
            // tb_Username
            // 
            tb_Username.Location = new Point(105, 83);
            tb_Username.Margin = new Padding(3, 4, 3, 4);
            tb_Username.Name = "tb_Username";
            tb_Username.Size = new Size(274, 27);
            tb_Username.TabIndex = 4;
            // 
            // tb_NickName
            // 
            tb_NickName.Location = new Point(105, 37);
            tb_NickName.Margin = new Padding(3, 4, 3, 4);
            tb_NickName.Name = "tb_NickName";
            tb_NickName.Size = new Size(274, 27);
            tb_NickName.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(23, 125);
            label8.Name = "label8";
            label8.Size = new Size(70, 20);
            label8.TabIndex = 2;
            label8.Text = "Password";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(23, 83);
            label7.Name = "label7";
            label7.Size = new Size(75, 20);
            label7.TabIndex = 1;
            label7.Text = "Username";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 41);
            label6.Name = "label6";
            label6.Size = new Size(82, 20);
            label6.TabIndex = 0;
            label6.Text = "Nick Name";
            // 
            // btn_TestConnect
            // 
            btn_TestConnect.Location = new Point(459, 427);
            btn_TestConnect.Margin = new Padding(3, 4, 3, 4);
            btn_TestConnect.Name = "btn_TestConnect";
            btn_TestConnect.Size = new Size(123, 39);
            btn_TestConnect.TabIndex = 10;
            btn_TestConnect.Text = "test Connection";
            btn_TestConnect.UseVisualStyleBackColor = true;
            btn_TestConnect.Click += btn_TestConnect_Click;
            // 
            // btn_Save
            // 
            btn_Save.Location = new Point(459, 479);
            btn_Save.Margin = new Padding(3, 4, 3, 4);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(123, 61);
            btn_Save.TabIndex = 11;
            btn_Save.Text = "Save Config";
            btn_Save.UseVisualStyleBackColor = true;
            btn_Save.Click += btn_Save_Click;
            // 
            // Task5_emailSetting
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(833, 607);
            Controls.Add(btn_Save);
            Controls.Add(btn_TestConnect);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Task5_emailSetting";
            Text = "Email Setting";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ContextMenuStrip contextMenuStrip1;
        private GroupBox groupBox1;
        private CheckBox checkBox2;
        private CheckBox cb_IMAP_requireSll;
        private TextBox tb_SMPT;
        private TextBox tb_IMAP;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private GroupBox groupBox2;
        private Label label6;
        private TextBox tb_PassWord;
        private TextBox tb_Username;
        private TextBox tb_NickName;
        private Label label8;
        private Label label7;
        private Button btn_TestConnect;
        private Button btn_Save;
        private DomainUpDown domainUpDown2;
        private DomainUpDown domainUpDown1;
    }
}