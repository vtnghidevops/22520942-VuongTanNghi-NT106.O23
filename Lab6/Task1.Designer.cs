namespace Lab6
{
    partial class Task1
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
            btn_Encrypt = new Button();
            btn_Decrypt = new Button();
            tb_Shift = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            rtb_Input = new RichTextBox();
            rtb_Encrypt = new RichTextBox();
            rtb_Decrypt = new RichTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SF Mono", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(214, 41);
            label1.Name = "label1";
            label1.Size = new Size(236, 33);
            label1.TabIndex = 0;
            label1.Text = "Mã hóa CAESAR";
            // 
            // btn_Encrypt
            // 
            btn_Encrypt.Cursor = Cursors.Hand;
            btn_Encrypt.Font = new Font("SF Mono", 12F);
            btn_Encrypt.Location = new Point(367, 120);
            btn_Encrypt.Margin = new Padding(3, 4, 3, 4);
            btn_Encrypt.Name = "btn_Encrypt";
            btn_Encrypt.Size = new Size(127, 47);
            btn_Encrypt.TabIndex = 1;
            btn_Encrypt.Text = "Encrypt";
            btn_Encrypt.UseVisualStyleBackColor = true;
            btn_Encrypt.Click += btn_Encrypt_Click;
            // 
            // btn_Decrypt
            // 
            btn_Decrypt.Cursor = Cursors.Hand;
            btn_Decrypt.Font = new Font("SF Mono", 12F);
            btn_Decrypt.Location = new Point(528, 120);
            btn_Decrypt.Margin = new Padding(3, 4, 3, 4);
            btn_Decrypt.Name = "btn_Decrypt";
            btn_Decrypt.Size = new Size(128, 47);
            btn_Decrypt.TabIndex = 2;
            btn_Decrypt.Text = "Decrypt";
            btn_Decrypt.UseVisualStyleBackColor = true;
            btn_Decrypt.Click += btn_Decrypt_Click;
            // 
            // tb_Shift
            // 
            tb_Shift.Font = new Font("Microsoft Sans Serif", 12F);
            tb_Shift.Location = new Point(14, 128);
            tb_Shift.Margin = new Padding(3, 4, 3, 4);
            tb_Shift.Name = "tb_Shift";
            tb_Shift.Size = new Size(129, 30);
            tb_Shift.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SF Mono", 12F);
            label2.Location = new Point(14, 95);
            label2.Name = "label2";
            label2.Size = new Size(178, 24);
            label2.TabIndex = 4;
            label2.Text = "Dịch ( Shift )";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SF Mono", 12F);
            label3.Location = new Point(12, 174);
            label3.Name = "label3";
            label3.Size = new Size(214, 24);
            label3.TabIndex = 5;
            label3.Text = "Dữ liệu ( Input )";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("SF Mono", 12F);
            label4.Location = new Point(12, 374);
            label4.Name = "label4";
            label4.Size = new Size(94, 24);
            label4.TabIndex = 6;
            label4.Text = "Encrypt";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("SF Mono", 12F);
            label5.Location = new Point(12, 599);
            label5.Name = "label5";
            label5.Size = new Size(94, 24);
            label5.TabIndex = 7;
            label5.Text = "Decrypt";
            // 
            // rtb_Input
            // 
            rtb_Input.Font = new Font("SF Mono", 12F);
            rtb_Input.Location = new Point(12, 216);
            rtb_Input.Margin = new Padding(3, 4, 3, 4);
            rtb_Input.Name = "rtb_Input";
            rtb_Input.Size = new Size(641, 135);
            rtb_Input.TabIndex = 8;
            rtb_Input.Text = "";
            // 
            // rtb_Encrypt
            // 
            rtb_Encrypt.Font = new Font("SF Mono", 12F);
            rtb_Encrypt.Location = new Point(12, 407);
            rtb_Encrypt.Margin = new Padding(3, 4, 3, 4);
            rtb_Encrypt.Name = "rtb_Encrypt";
            rtb_Encrypt.Size = new Size(644, 176);
            rtb_Encrypt.TabIndex = 9;
            rtb_Encrypt.Text = "";
            // 
            // rtb_Decrypt
            // 
            rtb_Decrypt.Font = new Font("SF Mono", 12F);
            rtb_Decrypt.Location = new Point(12, 646);
            rtb_Decrypt.Margin = new Padding(3, 4, 3, 4);
            rtb_Decrypt.Name = "rtb_Decrypt";
            rtb_Decrypt.Size = new Size(644, 172);
            rtb_Decrypt.TabIndex = 10;
            rtb_Decrypt.Text = "";
            // 
            // Task1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 832);
            Controls.Add(rtb_Decrypt);
            Controls.Add(rtb_Encrypt);
            Controls.Add(rtb_Input);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tb_Shift);
            Controls.Add(btn_Decrypt);
            Controls.Add(btn_Encrypt);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Task1";
            Text = "Ex_1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_Encrypt;
        private Button btn_Decrypt;
        private TextBox tb_Shift;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private RichTextBox rtb_Input;
        private RichTextBox rtb_Encrypt;
        private RichTextBox rtb_Decrypt;
    }
}