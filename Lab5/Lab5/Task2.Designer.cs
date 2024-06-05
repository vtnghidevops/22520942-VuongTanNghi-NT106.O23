namespace Lab5
{
    partial class Task2
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
            tb_username = new TextBox();
            tb_password = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            label3 = new Label();
            label4 = new Label();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            labelTotalEmails = new Label();
            labelRecentEmails = new Label();
            SuspendLayout();
            // 
            // tb_username
            // 
            tb_username.Location = new Point(146, 29);
            tb_username.Multiline = true;
            tb_username.Name = "tb_username";
            tb_username.Size = new Size(297, 27);
            tb_username.TabIndex = 1;
            // 
            // tb_password
            // 
            tb_password.Location = new Point(146, 62);
            tb_password.Multiline = true;
            tb_password.Name = "tb_password";
            tb_password.Size = new Size(297, 27);
            tb_password.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(62, 29);
            label1.Name = "label1";
            label1.Size = new Size(69, 28);
            label1.TabIndex = 6;
            label1.Text = "Email:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(25, 62);
            label2.Name = "label2";
            label2.Size = new Size(106, 28);
            label2.TabIndex = 7;
            label2.Text = "Password:";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(552, 48);
            button1.Name = "button1";
            button1.Size = new Size(201, 42);
            button1.TabIndex = 8;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(25, 128);
            label3.Name = "label3";
            label3.Size = new Size(64, 28);
            label3.TabIndex = 9;
            label3.Text = "Total:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(234, 128);
            label4.Name = "label4";
            label4.Size = new Size(82, 28);
            label4.TabIndex = 10;
            label4.Text = "Recent:";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listView1.Location = new Point(28, 180);
            listView1.Name = "listView1";
            listView1.Size = new Size(725, 247);
            listView1.TabIndex = 11;
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
            // labelTotalEmails
            // 
            labelTotalEmails.AutoSize = true;
            labelTotalEmails.Location = new Point(111, 135);
            labelTotalEmails.Name = "labelTotalEmails";
            labelTotalEmails.Size = new Size(0, 20);
            labelTotalEmails.TabIndex = 12;
            // 
            // labelRecentEmails
            // 
            labelRecentEmails.AutoSize = true;
            labelRecentEmails.Location = new Point(349, 135);
            labelRecentEmails.Name = "labelRecentEmails";
            labelRecentEmails.Size = new Size(0, 20);
            labelRecentEmails.TabIndex = 13;
            // 
            // Task2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(779, 450);
            Controls.Add(labelRecentEmails);
            Controls.Add(labelTotalEmails);
            Controls.Add(listView1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tb_password);
            Controls.Add(tb_username);
            Name = "Task2";
            Text = "Task2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_username;
        private TextBox tb_password;
        private Label label1;
        private Label label2;
        private Button button1;
        private Label label3;
        private Label label4;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Label labelTotalEmails;
        private Label labelRecentEmails;
    }
}