namespace Lab3
{
    partial class Task1_Client
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
            tb_IPHost = new TextBox();
            label2 = new Label();
            tb_HostPort = new TextBox();
            rtb_Message = new RichTextBox();
            label3 = new Label();
            btn_ClientSend = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 50);
            label1.Name = "label1";
            label1.Size = new Size(105, 20);
            label1.TabIndex = 0;
            label1.Text = "IP remote host";
            // 
            // tb_IPHost
            // 
            tb_IPHost.Location = new Point(61, 73);
            tb_IPHost.Name = "tb_IPHost";
            tb_IPHost.Size = new Size(354, 27);
            tb_IPHost.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(460, 50);
            label2.Name = "label2";
            label2.Size = new Size(35, 20);
            label2.TabIndex = 2;
            label2.Text = "Port";
            // 
            // tb_HostPort
            // 
            tb_HostPort.Location = new Point(460, 73);
            tb_HostPort.Name = "tb_HostPort";
            tb_HostPort.Size = new Size(125, 27);
            tb_HostPort.TabIndex = 3;
            // 
            // rtb_Message
            // 
            rtb_Message.BackColor = Color.FromArgb(224, 224, 224);
            rtb_Message.Location = new Point(61, 159);
            rtb_Message.Name = "rtb_Message";
            rtb_Message.Size = new Size(524, 225);
            rtb_Message.TabIndex = 4;
            rtb_Message.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 127);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 5;
            label3.Text = "Message";
            // 
            // btn_ClientSend
            // 
            btn_ClientSend.Location = new Point(606, 355);
            btn_ClientSend.Name = "btn_ClientSend";
            btn_ClientSend.Size = new Size(94, 29);
            btn_ClientSend.TabIndex = 6;
            btn_ClientSend.Text = "Send";
            btn_ClientSend.UseVisualStyleBackColor = true;
            btn_ClientSend.Click += btn_ClientSend_Click;
            // 
            // Task1_Client
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_ClientSend);
            Controls.Add(label3);
            Controls.Add(rtb_Message);
            Controls.Add(tb_HostPort);
            Controls.Add(label2);
            Controls.Add(tb_IPHost);
            Controls.Add(label1);
            Name = "Task1_Client";
            Text = "Task1_Client";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tb_IPHost;
        private Label label2;
        private TextBox tb_HostPort;
        private RichTextBox rtb_Message;
        private Label label3;
        private Button btn_ClientSend;
    }
}