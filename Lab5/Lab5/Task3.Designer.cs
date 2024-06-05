namespace Lab5
{
    partial class Task3
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
            label2 = new Label();
            label3 = new Label();
            labelTotalEmails = new Label();
            label5 = new Label();
            labelRecentEmails = new Label();
            tb_username = new TextBox();
            tb_password = new TextBox();
            btn_login = new Button();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 28);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Email:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 71);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 1;
            label2.Text = "Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(82, 151);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 2;
            label3.Text = "Total:";
            // 
            // labelTotalEmails
            // 
            labelTotalEmails.AutoSize = true;
            labelTotalEmails.Location = new Point(154, 151);
            labelTotalEmails.Name = "labelTotalEmails";
            labelTotalEmails.Size = new Size(0, 20);
            labelTotalEmails.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(258, 151);
            label5.Name = "label5";
            label5.Size = new Size(57, 20);
            label5.TabIndex = 4;
            label5.Text = "Recent:";
            // 
            // labelRecentEmails
            // 
            labelRecentEmails.AutoSize = true;
            labelRecentEmails.Location = new Point(339, 151);
            labelRecentEmails.Name = "labelRecentEmails";
            labelRecentEmails.Size = new Size(0, 20);
            labelRecentEmails.TabIndex = 5;
            // 
            // tb_username
            // 
            tb_username.Location = new Point(154, 21);
            tb_username.Name = "tb_username";
            tb_username.Size = new Size(308, 27);
            tb_username.TabIndex = 6;
            // 
            // tb_password
            // 
            tb_password.Location = new Point(154, 64);
            tb_password.Name = "tb_password";
            tb_password.Size = new Size(308, 27);
            tb_password.TabIndex = 7;
            // 
            // btn_login
            // 
            btn_login.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_login.Location = new Point(588, 53);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(111, 29);
            btn_login.TabIndex = 8;
            btn_login.Text = "LOGIN";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listView1.Location = new Point(54, 193);
            listView1.Name = "listView1";
            listView1.Size = new Size(645, 245);
            listView1.TabIndex = 9;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Email";
            columnHeader1.Width = 250;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "From";
            columnHeader2.Width = 250;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Thời gian";
            columnHeader3.Width = 200;
            // 
            // Task3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listView1);
            Controls.Add(btn_login);
            Controls.Add(tb_password);
            Controls.Add(tb_username);
            Controls.Add(labelRecentEmails);
            Controls.Add(label5);
            Controls.Add(labelTotalEmails);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Task3";
            Text = "Task3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label labelTotalEmails;
        private Label label5;
        private Label labelRecentEmails;
        private TextBox tb_username;
        private TextBox tb_password;
        private Button btn_login;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
    }
}