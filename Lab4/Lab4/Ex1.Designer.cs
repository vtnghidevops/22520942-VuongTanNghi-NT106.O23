namespace Lab4
{
    partial class Ex1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_getURL = new Button();
            tb_input = new TextBox();
            rtb_res = new RichTextBox();
            SuspendLayout();
            // 
            // btn_getURL
            // 
            btn_getURL.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_getURL.Location = new Point(647, 29);
            btn_getURL.Name = "btn_getURL";
            btn_getURL.Size = new Size(116, 41);
            btn_getURL.TabIndex = 0;
            btn_getURL.Text = "Get";
            btn_getURL.UseVisualStyleBackColor = true;
            btn_getURL.Click += btn_getURL_Click;
            // 
            // tb_input
            // 
            tb_input.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_input.Location = new Point(26, 36);
            tb_input.Name = "tb_input";
            tb_input.Size = new Size(595, 34);
            tb_input.TabIndex = 1;
            tb_input.Text = "https://";
            tb_input.TextChanged += tb_input_TextChanged;
            // 
            // rtb_res
            // 
            rtb_res.Location = new Point(26, 81);
            rtb_res.Name = "rtb_res";
            rtb_res.ReadOnly = true;
            rtb_res.Size = new Size(737, 347);
            rtb_res.TabIndex = 2;
            rtb_res.Text = "";
            // 
            // Ex1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rtb_res);
            Controls.Add(tb_input);
            Controls.Add(btn_getURL);
            Name = "Ex1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_getURL;
        private TextBox tb_input;
        private RichTextBox rtb_res;
    }
}
