namespace Lab5
{
    partial class Task1
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
            tbFromMail = new TextBox();
            tbPassword = new TextBox();
            tbToMail = new TextBox();
            tbSubject = new TextBox();
            rtbBody = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btn_SEND = new Button();
            SuspendLayout();
            // 
            // tbFromMail
            // 
            tbFromMail.Location = new Point(219, 52);
            tbFromMail.Name = "tbFromMail";
            tbFromMail.Size = new Size(224, 27);
            tbFromMail.TabIndex = 0;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(549, 52);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(213, 27);
            tbPassword.TabIndex = 1;
            // 
            // tbToMail
            // 
            tbToMail.Location = new Point(219, 135);
            tbToMail.Name = "tbToMail";
            tbToMail.Size = new Size(224, 27);
            tbToMail.TabIndex = 2;
            // 
            // tbSubject
            // 
            tbSubject.Location = new Point(167, 191);
            tbSubject.Name = "tbSubject";
            tbSubject.Size = new Size(595, 27);
            tbSubject.TabIndex = 3;
            // 
            // rtbBody
            // 
            rtbBody.Location = new Point(167, 240);
            rtbBody.Name = "rtbBody";
            rtbBody.Size = new Size(595, 208);
            rtbBody.TabIndex = 4;
            rtbBody.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(167, 59);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 5;
            label1.Text = "From:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(470, 59);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 6;
            label2.Text = "Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(167, 142);
            label3.Name = "label3";
            label3.Size = new Size(28, 20);
            label3.TabIndex = 7;
            label3.Text = "To:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(47, 194);
            label4.Name = "label4";
            label4.Size = new Size(61, 20);
            label4.TabIndex = 8;
            label4.Text = "Subject:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(47, 240);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 9;
            label5.Text = "Body:";
            // 
            // btn_SEND
            // 
            btn_SEND.Location = new Point(31, 83);
            btn_SEND.Name = "btn_SEND";
            btn_SEND.Size = new Size(94, 29);
            btn_SEND.TabIndex = 10;
            btn_SEND.Text = "SEND";
            btn_SEND.UseVisualStyleBackColor = true;
            btn_SEND.Click += btn_SEND_Click;
            // 
            // Task1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_SEND);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(rtbBody);
            Controls.Add(tbSubject);
            Controls.Add(tbToMail);
            Controls.Add(tbPassword);
            Controls.Add(tbFromMail);
            Name = "Task1";
            Text = "Task2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbFromMail;
        private TextBox tbPassword;
        private TextBox tbToMail;
        private TextBox tbSubject;
        private RichTextBox rtbBody;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btn_SEND;
    }
}