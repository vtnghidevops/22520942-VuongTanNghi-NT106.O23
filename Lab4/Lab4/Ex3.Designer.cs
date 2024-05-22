
namespace Lab4
{
	partial class Ex3
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
            tb_inputURL = new TextBox();
            btn_loadURL = new Button();
            btn_downSrc = new Button();
            webView2 = new Microsoft.Web.WebView2.WinForms.WebView2();
            btn_downHTML = new Button();
            btn_reload = new Button();
            ((System.ComponentModel.ISupportInitialize)webView2).BeginInit();
            SuspendLayout();
            // 
            // tb_inputURL
            // 
            tb_inputURL.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_inputURL.Location = new Point(156, 30);
            tb_inputURL.Margin = new Padding(3, 4, 3, 4);
            tb_inputURL.Name = "tb_inputURL";
            tb_inputURL.Size = new Size(693, 28);
            tb_inputURL.TabIndex = 1;
            tb_inputURL.Text = "https://";
            tb_inputURL.KeyPress += Lab4_txtURL_KeyPress;
            // 
            // btn_loadURL
            // 
            btn_loadURL.BackgroundImageLayout = ImageLayout.Stretch;
            btn_loadURL.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_loadURL.Location = new Point(24, 21);
            btn_loadURL.Margin = new Padding(3, 4, 3, 4);
            btn_loadURL.Name = "btn_loadURL";
            btn_loadURL.Size = new Size(114, 47);
            btn_loadURL.TabIndex = 2;
            btn_loadURL.Text = "Load";
            btn_loadURL.UseVisualStyleBackColor = true;
            btn_loadURL.Click += btn_loadURL_Click;
            // 
            // btn_downSrc
            // 
            btn_downSrc.BackgroundImageLayout = ImageLayout.Stretch;
            btn_downSrc.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            btn_downSrc.Location = new Point(737, 80);
            btn_downSrc.Margin = new Padding(3, 4, 3, 4);
            btn_downSrc.Name = "btn_downSrc";
            btn_downSrc.Size = new Size(248, 45);
            btn_downSrc.TabIndex = 6;
            btn_downSrc.Text = "Download Resource";
            btn_downSrc.UseVisualStyleBackColor = true;
            btn_downSrc.Click += btn_downSrc_Click;
            // 
            // webView2
            // 
            webView2.AllowExternalDrop = true;
            webView2.CreationProperties = null;
            webView2.DefaultBackgroundColor = Color.White;
            webView2.Location = new Point(24, 130);
            webView2.Margin = new Padding(2);
            webView2.Name = "webView2";
            webView2.Size = new Size(961, 472);
            webView2.TabIndex = 7;
            webView2.ZoomFactor = 1D;
            webView2.NavigationCompleted += webView2_NavigationCompleted;
            webView2.Click += webView2_Click;
            // 
            // btn_downHTML
            // 
            btn_downHTML.BackgroundImageLayout = ImageLayout.Stretch;
            btn_downHTML.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            btn_downHTML.Location = new Point(511, 80);
            btn_downHTML.Margin = new Padding(3, 4, 3, 4);
            btn_downHTML.Name = "btn_downHTML";
            btn_downHTML.Size = new Size(204, 44);
            btn_downHTML.TabIndex = 9;
            btn_downHTML.Text = "Download HTML";
            btn_downHTML.UseVisualStyleBackColor = true;
            btn_downHTML.Click += btn_downHTML_Click;
            // 
            // btn_reload
            // 
            btn_reload.BackgroundImageLayout = ImageLayout.Stretch;
            btn_reload.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            btn_reload.Location = new Point(870, 21);
            btn_reload.Margin = new Padding(3, 4, 3, 4);
            btn_reload.Name = "btn_reload";
            btn_reload.Size = new Size(115, 47);
            btn_reload.TabIndex = 10;
            btn_reload.Text = "Reload";
            btn_reload.UseVisualStyleBackColor = true;
            btn_reload.Click += btn_reload_Click;
            // 
            // Ex03
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1010, 623);
            Controls.Add(btn_reload);
            Controls.Add(btn_downHTML);
            Controls.Add(webView2);
            Controls.Add(btn_downSrc);
            Controls.Add(btn_loadURL);
            Controls.Add(tb_inputURL);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Ex03";
            Load += Ex03_Load;
            ((System.ComponentModel.ISupportInitialize)webView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox tb_inputURL;
		private System.Windows.Forms.Button btn_loadURL;
		private System.Windows.Forms.Button btn_downSrc;
		private Microsoft.Web.WebView2.WinForms.WebView2 webView2;
		private Button btn_downHTML;
        private Button btn_reload;
    }
}

