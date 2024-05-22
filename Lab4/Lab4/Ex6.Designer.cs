namespace Lab4
{
    partial class Ex6
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
            label2 = new Label();
            tb_URL = new TextBox();
            tb_Token = new TextBox();
            rtb_res = new RichTextBox();
            btn_Get = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label1.Location = new Point(53, 39);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(46, 25);
            label1.TabIndex = 0;
            label1.Text = "URL";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label2.Location = new Point(12, 83);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(106, 25);
            label2.TabIndex = 1;
            label2.Text = "Your Token";
            // 
            // tb_URL
            // 
            tb_URL.Location = new Point(126, 30);
            tb_URL.Margin = new Padding(4);
            tb_URL.Name = "tb_URL";
            tb_URL.Size = new Size(663, 31);
            tb_URL.TabIndex = 2;
            // 
            // tb_Token
            // 
            tb_Token.Location = new Point(126, 83);
            tb_Token.Margin = new Padding(4);
            tb_Token.Name = "tb_Token";
            tb_Token.Size = new Size(663, 31);
            tb_Token.TabIndex = 3;
            // 
            // rtb_res
            // 
            rtb_res.Location = new Point(13, 146);
            rtb_res.Margin = new Padding(4);
            rtb_res.Name = "rtb_res";
            rtb_res.ReadOnly = true;
            rtb_res.Size = new Size(939, 364);
            rtb_res.TabIndex = 4;
            rtb_res.Text = "";
            // 
            // btn_Get
            // 
            btn_Get.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btn_Get.Location = new Point(823, 60);
            btn_Get.Margin = new Padding(4);
            btn_Get.Name = "btn_Get";
            btn_Get.Size = new Size(129, 36);
            btn_Get.TabIndex = 5;
            btn_Get.Text = "GET";
            btn_Get.UseVisualStyleBackColor = true;
            btn_Get.Click += btn_Get_Click;
            // 
            // Ex6
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 530);
            Controls.Add(btn_Get);
            Controls.Add(rtb_res);
            Controls.Add(tb_Token);
            Controls.Add(tb_URL);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            Margin = new Padding(4);
            Name = "Ex6";
            Text = "Task6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tb_URL;
        private TextBox tb_Token;
        private RichTextBox rtb_res;
        private Button btn_Get;
    }
}