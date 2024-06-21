namespace Lab6
{
    partial class Task2
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
            rtb_Decrypt = new RichTextBox();
            rtb_Encrypt = new RichTextBox();
            rtb_Input = new RichTextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            tb_Key = new TextBox();
            btn_Decrypt = new Button();
            btn_Encrypt = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // rtb_Decrypt
            // 
            rtb_Decrypt.Font = new Font("SF Mono", 12F);
            rtb_Decrypt.Location = new Point(11, 584);
            rtb_Decrypt.Margin = new Padding(3, 4, 3, 4);
            rtb_Decrypt.Name = "rtb_Decrypt";
            rtb_Decrypt.Size = new Size(823, 140);
            rtb_Decrypt.TabIndex = 21;
            rtb_Decrypt.Text = "";
            // 
            // rtb_Encrypt
            // 
            rtb_Encrypt.Font = new Font("SF Mono", 12F);
            rtb_Encrypt.Location = new Point(12, 386);
            rtb_Encrypt.Margin = new Padding(3, 4, 3, 4);
            rtb_Encrypt.Name = "rtb_Encrypt";
            rtb_Encrypt.Size = new Size(822, 138);
            rtb_Encrypt.TabIndex = 20;
            rtb_Encrypt.Text = "";
            // 
            // rtb_Input
            // 
            rtb_Input.Font = new Font("SF Mono", 12F);
            rtb_Input.Location = new Point(14, 200);
            rtb_Input.Margin = new Padding(3, 4, 3, 4);
            rtb_Input.Name = "rtb_Input";
            rtb_Input.Size = new Size(820, 120);
            rtb_Input.TabIndex = 19;
            rtb_Input.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("SF Mono", 12F);
            label5.Location = new Point(12, 546);
            label5.Name = "label5";
            label5.Size = new Size(94, 24);
            label5.TabIndex = 18;
            label5.Text = "Decrypt";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("SF Mono", 12F);
            label4.Location = new Point(15, 346);
            label4.Name = "label4";
            label4.Size = new Size(94, 24);
            label4.TabIndex = 17;
            label4.Text = "Encrypt";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SF Mono", 12F);
            label3.Location = new Point(14, 163);
            label3.Name = "label3";
            label3.Size = new Size(214, 24);
            label3.TabIndex = 16;
            label3.Text = "Dữ liệu ( Input )";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SF Mono", 12F);
            label2.Location = new Point(15, 86);
            label2.Name = "label2";
            label2.Size = new Size(46, 24);
            label2.TabIndex = 15;
            label2.Text = "Key";
            // 
            // tb_Key
            // 
            tb_Key.Font = new Font("SF Mono", 12F);
            tb_Key.Location = new Point(15, 119);
            tb_Key.Margin = new Padding(3, 4, 3, 4);
            tb_Key.Name = "tb_Key";
            tb_Key.Size = new Size(454, 31);
            tb_Key.TabIndex = 14;
            // 
            // btn_Decrypt
            // 
            btn_Decrypt.Cursor = Cursors.Hand;
            btn_Decrypt.Font = new Font("SF Mono", 12F);
            btn_Decrypt.Location = new Point(684, 107);
            btn_Decrypt.Margin = new Padding(3, 4, 3, 4);
            btn_Decrypt.Name = "btn_Decrypt";
            btn_Decrypt.Size = new Size(150, 46);
            btn_Decrypt.TabIndex = 13;
            btn_Decrypt.Text = "Decrypt";
            btn_Decrypt.UseVisualStyleBackColor = true;
            btn_Decrypt.Click += btn_Decrypt_Click;
            // 
            // btn_Encrypt
            // 
            btn_Encrypt.Cursor = Cursors.Hand;
            btn_Encrypt.Font = new Font("SF Mono", 12F);
            btn_Encrypt.Location = new Point(524, 105);
            btn_Encrypt.Margin = new Padding(3, 4, 3, 4);
            btn_Encrypt.Name = "btn_Encrypt";
            btn_Encrypt.Size = new Size(117, 50);
            btn_Encrypt.TabIndex = 12;
            btn_Encrypt.Text = "Encrypt";
            btn_Encrypt.UseVisualStyleBackColor = true;
            btn_Encrypt.Click += btn_Encrypt_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SF Mono", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(285, 33);
            label1.Name = "label1";
            label1.Size = new Size(270, 33);
            label1.TabIndex = 11;
            label1.Text = "Mã hóa Vigenère";
            // 
            // Task2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(868, 760);
            Controls.Add(rtb_Decrypt);
            Controls.Add(rtb_Encrypt);
            Controls.Add(rtb_Input);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tb_Key);
            Controls.Add(btn_Decrypt);
            Controls.Add(btn_Encrypt);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Task2";
            Text = "Ex_2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox rtb_Decrypt;
        private RichTextBox rtb_Encrypt;
        private RichTextBox rtb_Input;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox tb_Key;
        private Button btn_Decrypt;
        private Button btn_Encrypt;
        private Label label1;
    }
}