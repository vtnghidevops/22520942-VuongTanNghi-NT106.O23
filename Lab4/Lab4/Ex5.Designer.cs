namespace Lab4
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
            tb_URL = new TextBox();
            tb_password = new TextBox();
            tb_userName = new TextBox();
            rtb_res = new RichTextBox();
            btn_login = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // tb_URL
            // 
            tb_URL.Location = new Point(154, 29);
            tb_URL.Margin = new Padding(4);
            tb_URL.Name = "tb_URL";
            tb_URL.Size = new Size(510, 31);
            tb_URL.TabIndex = 0;
            // 
            // tb_password
            // 
            tb_password.Location = new Point(154, 169);
            tb_password.Margin = new Padding(4);
            tb_password.Name = "tb_password";
            tb_password.Size = new Size(389, 31);
            tb_password.TabIndex = 1;
            // 
            // tb_userName
            // 
            tb_userName.Location = new Point(154, 101);
            tb_userName.Margin = new Padding(4);
            tb_userName.Name = "tb_userName";
            tb_userName.Size = new Size(389, 31);
            tb_userName.TabIndex = 2;
            // 
            // rtb_res
            // 
            rtb_res.Location = new Point(43, 239);
            rtb_res.Margin = new Padding(4);
            rtb_res.Name = "rtb_res";
            rtb_res.Size = new Size(653, 230);
            rtb_res.TabIndex = 3;
            rtb_res.Text = "";
            // 
            // btn_login
            // 
            btn_login.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btn_login.Location = new Point(586, 147);
            btn_login.Margin = new Padding(4);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(110, 53);
            btn_login.TabIndex = 4;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label1.Location = new Point(36, 29);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(46, 25);
            label1.TabIndex = 5;
            label1.Text = "URL";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label2.Location = new Point(36, 98);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(97, 25);
            label2.TabIndex = 6;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label3.Location = new Point(36, 169);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(92, 25);
            label3.TabIndex = 7;
            label3.Text = "Password";
            // 
            // Ex4
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(734, 488);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_login);
            Controls.Add(rtb_res);
            Controls.Add(tb_userName);
            Controls.Add(tb_password);
            Controls.Add(tb_URL);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            Margin = new Padding(4);
            Name = "Ex4";
            Text = "Ex4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_URL;
        private TextBox tb_password;
        private TextBox tb_userName;
        private RichTextBox rtb_res;
        private Button btn_login;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}