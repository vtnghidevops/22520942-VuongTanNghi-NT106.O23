namespace Lab3
{
    partial class Task1_Server
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
            tb_PortListen = new TextBox();
            label2 = new Label();
            rtb_ReceivedMessage = new RichTextBox();
            btn_ServerListen = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 36);
            label1.Name = "label1";
            label1.Size = new Size(35, 20);
            label1.TabIndex = 0;
            label1.Text = "Port";
            // 
            // tb_PortListen
            // 
            tb_PortListen.Location = new Point(47, 59);
            tb_PortListen.Name = "tb_PortListen";
            tb_PortListen.Size = new Size(131, 27);
            tb_PortListen.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 111);
            label2.Name = "label2";
            label2.Size = new Size(131, 20);
            label2.TabIndex = 2;
            label2.Text = "Received Message";
            // 
            // rtb_ReceivedMessage
            // 
            rtb_ReceivedMessage.BackColor = Color.FromArgb(224, 224, 224);
            rtb_ReceivedMessage.Location = new Point(47, 134);
            rtb_ReceivedMessage.Name = "rtb_ReceivedMessage";
            rtb_ReceivedMessage.Size = new Size(502, 247);
            rtb_ReceivedMessage.TabIndex = 3;
            rtb_ReceivedMessage.Text = "";
            // 
            // btn_ServerListen
            // 
            btn_ServerListen.Location = new Point(428, 53);
            btn_ServerListen.Name = "btn_ServerListen";
            btn_ServerListen.Size = new Size(121, 39);
            btn_ServerListen.TabIndex = 4;
            btn_ServerListen.Text = "Listen";
            btn_ServerListen.UseVisualStyleBackColor = true;
            btn_ServerListen.Click += btn_ServerListen_Click;
            // 
            // Task1_Server
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(633, 424);
            Controls.Add(btn_ServerListen);
            Controls.Add(rtb_ReceivedMessage);
            Controls.Add(label2);
            Controls.Add(tb_PortListen);
            Controls.Add(label1);
            Name = "Task1_Server";
            Text = "Task1_Server";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tb_PortListen;
        private Label label2;
        private RichTextBox rtb_ReceivedMessage;
        private Button btn_ServerListen;
    }
}