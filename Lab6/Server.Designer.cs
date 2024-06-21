namespace Lab3
{
    partial class Server
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
            lv_ListLog = new ListView();
            tb__msgToClient = new TextBox();
            btn__sendClient = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // lv_ListLog
            // 
            lv_ListLog.Location = new Point(12, 30);
            lv_ListLog.Name = "lv_ListLog";
            lv_ListLog.Size = new Size(848, 319);
            lv_ListLog.TabIndex = 2;
            lv_ListLog.UseCompatibleStateImageBehavior = false;
            lv_ListLog.View = View.List;
            // 
            // tb__msgToClient
            // 
            tb__msgToClient.Location = new Point(34, 410);
            tb__msgToClient.Name = "tb__msgToClient";
            tb__msgToClient.Size = new Size(437, 27);
            tb__msgToClient.TabIndex = 3;
            // 
            // btn__sendClient
            // 
            btn__sendClient.Location = new Point(502, 407);
            btn__sendClient.Name = "btn__sendClient";
            btn__sendClient.Size = new Size(107, 32);
            btn__sendClient.TabIndex = 4;
            btn__sendClient.Text = "Send ";
            btn__sendClient.UseVisualStyleBackColor = true;
            btn__sendClient.Click += btn__sendClient_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 379);
            label1.Name = "label1";
            label1.Size = new Size(102, 20);
            label1.TabIndex = 6;
            label1.Text = "Nhập tin nhắn";
            // 
            // Server
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(883, 461);
            Controls.Add(label1);
            Controls.Add(btn__sendClient);
            Controls.Add(tb__msgToClient);
            Controls.Add(lv_ListLog);
            Name = "Server";
            Text = "Task3_Server";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListView lv_ListLog;
        private TextBox tb__msgToClient;
        private Button btn__sendClient;
        private Label label1;
    }
}