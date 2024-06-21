namespace Chat_P2P
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
            CreateClient = new Button();
            CreateServer = new Button();
            SuspendLayout();
            // 
            // CreateClient
            // 
            CreateClient.Location = new Point(109, 73);
            CreateClient.Name = "CreateClient";
            CreateClient.Size = new Size(145, 66);
            CreateClient.TabIndex = 0;
            CreateClient.Text = "Client";
            CreateClient.UseVisualStyleBackColor = true;
            CreateClient.Click += CreateClient_Click;
            // 
            // CreateServer
            // 
            CreateServer.Location = new Point(314, 73);
            CreateServer.Name = "CreateServer";
            CreateServer.Size = new Size(145, 66);
            CreateServer.TabIndex = 1;
            CreateServer.Text = "Server";
            CreateServer.UseVisualStyleBackColor = true;
            CreateServer.Click += CreateServer_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(608, 211);
            Controls.Add(CreateServer);
            Controls.Add(CreateClient);
            Name = "Dashboard";
            Text = "Dashboard";
            ResumeLayout(false);
        }

        #endregion

        private Button CreateClient;
        private Button CreateServer;
    }
}