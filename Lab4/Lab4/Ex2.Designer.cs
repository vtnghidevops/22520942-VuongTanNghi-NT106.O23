namespace Lab4
{
    partial class Ex2
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
            tb_url = new TextBox();
            tb_filePath = new TextBox();
            btn_down = new Button();
            label1 = new Label();
            label2 = new Label();
            rtb_res = new RichTextBox();
            SuspendLayout();
            // 
            // tb_url
            // 
            tb_url.Location = new Point(16, 74);
            tb_url.Margin = new Padding(4);
            tb_url.Name = "tb_url";
            tb_url.Size = new Size(868, 34);
            tb_url.TabIndex = 0;
            // 
            // tb_filePath
            // 
            tb_filePath.Location = new Point(13, 150);
            tb_filePath.Margin = new Padding(4);
            tb_filePath.Name = "tb_filePath";
            tb_filePath.Size = new Size(868, 34);
            tb_filePath.TabIndex = 1;
            // 
            // btn_down
            // 
            btn_down.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_down.Location = new Point(894, 60);
            btn_down.Margin = new Padding(4);
            btn_down.Name = "btn_down";
            btn_down.Size = new Size(193, 62);
            btn_down.TabIndex = 2;
            btn_down.Text = "Download here";
            btn_down.UseVisualStyleBackColor = true;
            btn_down.Click += btn_down_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(16, 27);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(142, 28);
            label1.TabIndex = 3;
            label1.Text = "Enter your URL";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(16, 118);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(130, 28);
            label2.TabIndex = 4;
            label2.Text = "File save path";
            // 
            // rtb_res
            // 
            rtb_res.Location = new Point(13, 201);
            rtb_res.Name = "rtb_res";
            rtb_res.ReadOnly = true;
            rtb_res.Size = new Size(1074, 388);
            rtb_res.TabIndex = 5;
            rtb_res.Text = "";
            // 
            // Ex2
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 630);
            Controls.Add(rtb_res);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_down);
            Controls.Add(tb_filePath);
            Controls.Add(tb_url);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "Ex2";
            Text = "Ex2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_url;
        private TextBox tb_filePath;
        private Button btn_down;
        private Label label1;
        private Label label2;
        private RichTextBox rtb_res;
    }
}