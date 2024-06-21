namespace Lab3
{
    partial class Client
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
            btn_Connect = new Button();
            lv_messageLog = new ListView();
            btn_SendMessage = new Button();
            tb_Message = new TextBox();
            label2 = new Label();
            label1 = new Label();
            tb_ipServer = new TextBox();
            tb_portServer = new TextBox();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // tb_NameOfClient
            // 
            tb_NameOfClient.Location = new Point(439, 539);
            tb_NameOfClient.Name = "tb_NameOfClient";
            tb_NameOfClient.Size = new Size(160, 27);
            tb_NameOfClient.TabIndex = 1;
            // 
            // btn_Connect
            // 
            btn_Connect.BackColor = Color.Silver;
            btn_Connect.Location = new Point(439, 457);
            btn_Connect.Name = "btn_Connect";
            btn_Connect.Size = new Size(208, 47);
            btn_Connect.TabIndex = 10;
            btn_Connect.Text = "Kết nối tới phòng chat";
            btn_Connect.UseVisualStyleBackColor = false;
            btn_Connect.Click += btn_Connect_Click;
            // 
            // lv_messageLog
            // 
            lv_messageLog.Location = new Point(27, 12);
            lv_messageLog.Name = "lv_messageLog";
            lv_messageLog.Size = new Size(620, 427);
            lv_messageLog.TabIndex = 7;
            lv_messageLog.UseCompatibleStateImageBehavior = false;
            lv_messageLog.View = View.List;
            lv_messageLog.SelectedIndexChanged += lv_messageLog_SelectedIndexChanged;
            // 
            // btn_SendMessage
            // 
            btn_SendMessage.BackColor = Color.Silver;
            btn_SendMessage.Location = new Point(553, 586);
            btn_SendMessage.Name = "btn_SendMessage";
            btn_SendMessage.Size = new Size(94, 29);
            btn_SendMessage.TabIndex = 6;
            btn_SendMessage.Text = "Send";
            btn_SendMessage.UseVisualStyleBackColor = false;
            btn_SendMessage.Click += btn_SendMessage_Click;
            // 
            // tb_Message
            // 
            tb_Message.Location = new Point(41, 586);
            tb_Message.Name = "tb_Message";
            tb_Message.Size = new Size(490, 27);
            tb_Message.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 563);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 4;
            label2.Text = "Message";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(439, 516);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 2;
            label1.Text = "Your name ";
            // 
            // tb_ipServer
            // 
            tb_ipServer.Location = new Point(130, 457);
            tb_ipServer.Name = "tb_ipServer";
            tb_ipServer.Size = new Size(137, 27);
            tb_ipServer.TabIndex = 24;
            // 
            // tb_portServer
            // 
            tb_portServer.Location = new Point(130, 511);
            tb_portServer.Name = "tb_portServer";
            tb_portServer.Size = new Size(137, 27);
            tb_portServer.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 460);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 26;
            label3.Text = "IP Server";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 518);
            label4.Name = "label4";
            label4.Size = new Size(80, 20);
            label4.TabIndex = 27;
            label4.Text = "Port Server";
            // 
            // Client
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(689, 640);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(tb_portServer);
            Controls.Add(tb_ipServer);
            Controls.Add(btn_Connect);
            Controls.Add(lv_messageLog);
            Controls.Add(btn_SendMessage);
            Controls.Add(tb_Message);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tb_NameOfClient);
            Name = "Client";
            Text = "Task3_Client";
            FormClosing += Task_6_Client_FormClosing;
            Load += Client_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox tb_NameOfClient;
        private Button btn_Connect;
        private ListView lv_messageLog;
        private Button btn_SendMessage;
        private TextBox tb_Message;
        private Label label2;
        private Label label1;
        private TextBox tb_ipServer;
        private TextBox tb_portServer;
        private Label label3;
        private Label label4;
    }
}