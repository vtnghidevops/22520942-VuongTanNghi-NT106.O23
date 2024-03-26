namespace Lab1
{
    partial class Ex5
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
            label3 = new Label();
            btn_Cal = new Button();
            btn_Exit = new Button();
            btn_Restore = new Button();
            groupBox1 = new GroupBox();
            textBoxResult = new TextBox();
            textBoxInput1 = new TextBox();
            textBoxInput2 = new TextBox();
            comboBox1 = new ComboBox();
            panel1 = new Panel();
            label4 = new Label();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(114, 9);
            label1.Name = "label1";
            label1.Size = new Size(572, 38);
            label1.TabIndex = 0;
            label1.Text = "Tính Giá Trị Biểu Thức | Bảng Cửu Chương";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SF Mono", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(37, 13);
            label2.Name = "label2";
            label2.Size = new Size(96, 27);
            label2.TabIndex = 1;
            label2.Text = "Nhập A";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SF Mono", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(367, 8);
            label3.Name = "label3";
            label3.Size = new Size(96, 27);
            label3.TabIndex = 2;
            label3.Text = "Nhập B";
            // 
            // btn_Cal
            // 
            btn_Cal.Font = new Font("SF Mono", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Cal.Location = new Point(180, 242);
            btn_Cal.Name = "btn_Cal";
            btn_Cal.Size = new Size(108, 48);
            btn_Cal.TabIndex = 3;
            btn_Cal.Text = "Tính";
            btn_Cal.UseVisualStyleBackColor = true;
            btn_Cal.Click += btn_Cal_Click;
            // 
            // btn_Exit
            // 
            btn_Exit.Font = new Font("SF Mono", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Exit.Location = new Point(357, 243);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(102, 47);
            btn_Exit.TabIndex = 4;
            btn_Exit.Text = "Thoát";
            btn_Exit.UseVisualStyleBackColor = true;
            btn_Exit.Click += btn_Exit_Click;
            // 
            // btn_Restore
            // 
            btn_Restore.Font = new Font("SF Mono", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Restore.Location = new Point(534, 242);
            btn_Restore.Name = "btn_Restore";
            btn_Restore.Size = new Size(122, 48);
            btn_Restore.TabIndex = 5;
            btn_Restore.Text = "Đặt Lại";
            btn_Restore.UseVisualStyleBackColor = true;
            btn_Restore.Click += btn_Restore_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxResult);
            groupBox1.Font = new Font("SF Mono", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(80, 296);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(658, 142);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kết Quả";
            // 
            // textBoxResult
            // 
            textBoxResult.Font = new Font("SF Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxResult.Location = new Point(48, 30);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.ScrollBars = ScrollBars.Vertical;
            textBoxResult.Size = new Size(570, 106);
            textBoxResult.TabIndex = 0;
            // 
            // textBoxInput1
            // 
            textBoxInput1.Font = new Font("SF Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxInput1.Location = new Point(194, 10);
            textBoxInput1.Name = "textBoxInput1";
            textBoxInput1.Size = new Size(125, 31);
            textBoxInput1.TabIndex = 8;
            textBoxInput1.TextChanged += textBox1_TextChanged;
            // 
            // textBoxInput2
            // 
            textBoxInput2.Font = new Font("SF Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxInput2.Location = new Point(481, 10);
            textBoxInput2.Name = "textBoxInput2";
            textBoxInput2.Size = new Size(125, 31);
            textBoxInput2.TabIndex = 9;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("SF Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Bảng Cửu Chương ( B - A )", "Tính Toán Giá Trị" });
            comboBox1.Location = new Point(194, 75);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(294, 32);
            comboBox1.TabIndex = 11;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBoxInput2);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBoxInput1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(80, 81);
            panel1.Name = "panel1";
            panel1.Size = new Size(688, 139);
            panel1.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("SF Mono", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(37, 75);
            label4.Name = "label4";
            label4.Size = new Size(124, 27);
            label4.TabIndex = 12;
            label4.Text = "Lựa Chọn";
            // 
            // Ex5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Controls.Add(btn_Restore);
            Controls.Add(btn_Exit);
            Controls.Add(btn_Cal);
            Controls.Add(label1);
            Name = "Ex5";
            Text = "Bài 5";
            FormClosed += Ex5_FormClosed;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btn_Cal;
        private Button btn_Exit;
        private Button btn_Restore;
        private GroupBox groupBox1;
        private TextBox textBoxInput1;
        private TextBox textBoxInput2;
        private ComboBox comboBox1;
        private Panel panel1;
        private Label label4;
        private TextBox textBoxResult;
    }
}