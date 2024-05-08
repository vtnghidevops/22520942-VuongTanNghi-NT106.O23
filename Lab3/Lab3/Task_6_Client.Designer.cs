namespace Lab3
{
    partial class Task_6_Client
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
            tb_NameOfClient = new MaskedTextBox();
            label1 = new Label();
            btn_Connect = new Button();
            label2 = new Label();
            tb_Message = new TextBox();
            btn_SendMessage = new Button();
            lv_messageLog = new ListView();
            SuspendLayout();
            // 
            // tb_NameOfClient
            // 
            tb_NameOfClient.Location = new Point(12, 375);
            tb_NameOfClient.Name = "tb_NameOfClient";
            tb_NameOfClient.Size = new Size(160, 27);
            tb_NameOfClient.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 352);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 2;
            label1.Text = "Your name ";
            // 
            // btn_Connect
            // 
            btn_Connect.BackColor = Color.Silver;
            btn_Connect.Location = new Point(197, 373);
            btn_Connect.Name = "btn_Connect";
            btn_Connect.Size = new Size(94, 29);
            btn_Connect.TabIndex = 3;
            btn_Connect.Text = "Connect";
            btn_Connect.UseVisualStyleBackColor = false;
            btn_Connect.Click += btn_Connect_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 424);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 4;
            label2.Text = "Message";
            // 
            // tb_Message
            // 
            tb_Message.Location = new Point(12, 447);
            tb_Message.Name = "tb_Message";
            tb_Message.Size = new Size(490, 27);
            tb_Message.TabIndex = 5;
            // 
            // btn_SendMessage
            // 
            btn_SendMessage.BackColor = Color.Silver;
            btn_SendMessage.Location = new Point(527, 445);
            btn_SendMessage.Name = "btn_SendMessage";
            btn_SendMessage.Size = new Size(94, 29);
            btn_SendMessage.TabIndex = 6;
            btn_SendMessage.Text = "Send";
            btn_SendMessage.UseVisualStyleBackColor = false;
            btn_SendMessage.Click += btn_SendMessage_Click;
            // 
            // lv_messageLog
            // 
            lv_messageLog.Location = new Point(12, 12);
            lv_messageLog.Name = "lv_messageLog";
            lv_messageLog.Size = new Size(466, 337);
            lv_messageLog.TabIndex = 7;
            lv_messageLog.UseCompatibleStateImageBehavior = false;
            lv_messageLog.View = View.List;
            // 
            // Task_6_Client
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(676, 519);
            Controls.Add(lv_messageLog);
            Controls.Add(btn_SendMessage);
            Controls.Add(tb_Message);
            Controls.Add(label2);
            Controls.Add(btn_Connect);
            Controls.Add(label1);
            Controls.Add(tb_NameOfClient);
            Name = "Task_6_Client";
            Text = "Task_6_Client";
            FormClosing += Task_6_Client_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MaskedTextBox tb_NameOfClient;
        private Label label1;
        private Button btn_Connect;
        private Label label2;
        private TextBox tb_Message;
        private Button btn_SendMessage;
        private ListView lv_messageLog;
    }
}