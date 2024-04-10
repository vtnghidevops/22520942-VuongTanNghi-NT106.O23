namespace Lab2
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
            textBox1 = new TextBox();
            btn_Exit = new Button();
            rtb_Result = new RichTextBox();
            textBox_FileName = new TextBox();
            textBox_Size = new TextBox();
            textBox_URL = new TextBox();
            textBox_LineCount = new TextBox();
            textBox_WordCount = new TextBox();
            textBox_CharCount = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btn_Read = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(385, 97);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 1;
            // 
            // btn_Exit
            // 
            btn_Exit.Font = new Font("SF Mono", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Exit.Location = new Point(26, 405);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(352, 33);
            btn_Exit.TabIndex = 29;
            btn_Exit.Text = "Exit";
            btn_Exit.UseVisualStyleBackColor = true;
            btn_Exit.Click += btn_Exit_Click;
            // 
            // rtb_Result
            // 
            rtb_Result.Location = new Point(384, 20);
            rtb_Result.Name = "rtb_Result";
            rtb_Result.Size = new Size(404, 418);
            rtb_Result.TabIndex = 28;
            rtb_Result.Text = "";
            // 
            // textBox_FileName
            // 
            textBox_FileName.Location = new Point(192, 91);
            textBox_FileName.Name = "textBox_FileName";
            textBox_FileName.Size = new Size(186, 27);
            textBox_FileName.TabIndex = 27;
            // 
            // textBox_Size
            // 
            textBox_Size.Location = new Point(192, 138);
            textBox_Size.Name = "textBox_Size";
            textBox_Size.Size = new Size(186, 27);
            textBox_Size.TabIndex = 26;
            // 
            // textBox_URL
            // 
            textBox_URL.Location = new Point(192, 191);
            textBox_URL.Name = "textBox_URL";
            textBox_URL.Size = new Size(186, 27);
            textBox_URL.TabIndex = 25;
            // 
            // textBox_LineCount
            // 
            textBox_LineCount.Location = new Point(192, 242);
            textBox_LineCount.Name = "textBox_LineCount";
            textBox_LineCount.Size = new Size(186, 27);
            textBox_LineCount.TabIndex = 24;
            // 
            // textBox_WordCount
            // 
            textBox_WordCount.Location = new Point(192, 288);
            textBox_WordCount.Name = "textBox_WordCount";
            textBox_WordCount.Size = new Size(186, 27);
            textBox_WordCount.TabIndex = 23;
            // 
            // textBox_CharCount
            // 
            textBox_CharCount.Location = new Point(192, 340);
            textBox_CharCount.Name = "textBox_CharCount";
            textBox_CharCount.Size = new Size(186, 27);
            textBox_CharCount.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("SF Mono", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.MediumBlue;
            label6.Location = new Point(20, 343);
            label6.Name = "label6";
            label6.Size = new Size(174, 20);
            label6.TabIndex = 21;
            label6.Text = "Character count";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("SF Mono", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.MediumBlue;
            label5.Location = new Point(20, 291);
            label5.Name = "label5";
            label5.Size = new Size(119, 20);
            label5.TabIndex = 20;
            label5.Text = "Word count";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("SF Mono", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.MediumBlue;
            label4.Location = new Point(20, 242);
            label4.Name = "label4";
            label4.Size = new Size(119, 20);
            label4.TabIndex = 19;
            label4.Text = "Line Count";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SF Mono", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.MediumBlue;
            label3.Location = new Point(20, 191);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 18;
            label3.Text = "URL";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SF Mono", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.MediumBlue;
            label2.Location = new Point(20, 138);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 17;
            label2.Text = "Size";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SF Mono", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MediumBlue;
            label1.Location = new Point(20, 91);
            label1.Name = "label1";
            label1.Size = new Size(108, 20);
            label1.TabIndex = 16;
            label1.Text = "File Name";
            // 
            // btn_Read
            // 
            btn_Read.Font = new Font("SF Mono", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Read.Location = new Point(20, 20);
            btn_Read.Name = "btn_Read";
            btn_Read.Size = new Size(358, 44);
            btn_Read.TabIndex = 15;
            btn_Read.Text = "Read From File";
            btn_Read.UseVisualStyleBackColor = true;
            btn_Read.Click += btn_Read_Click;
            // 
            // Ex2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Exit);
            Controls.Add(rtb_Result);
            Controls.Add(textBox_FileName);
            Controls.Add(textBox_Size);
            Controls.Add(textBox_URL);
            Controls.Add(textBox_LineCount);
            Controls.Add(textBox_WordCount);
            Controls.Add(textBox_CharCount);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_Read);
            Controls.Add(textBox1);
            Name = "Ex2";
            Text = "Ex2";
            FormClosed += Ex2_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button btn_Exit;
        private RichTextBox rtb_Result;
        private TextBox textBox_FileName;
        private TextBox textBox_Size;
        private TextBox textBox_URL;
        private TextBox textBox_LineCount;
        private TextBox textBox_WordCount;
        private TextBox textBox_CharCount;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btn_Read;
    }
}