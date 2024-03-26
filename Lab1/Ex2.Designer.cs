namespace Lab1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBoxNum1 = new TextBox();
            textBoxNum2 = new TextBox();
            textBoxNum3 = new TextBox();
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            btn_Find = new Button();
            btn_Exit = new Button();
            btn_Restore = new Button();
            textBoxMax = new TextBox();
            textBoxMin = new TextBox();
            label5 = new Label();
            label6 = new Label();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SF Mono", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(29, 0);
            label1.Name = "label1";
            label1.Size = new Size(406, 33);
            label1.TabIndex = 0;
            label1.Text = "Tìm Max, Min Của Các Số";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 34);
            label2.Name = "label2";
            label2.Size = new Size(236, 27);
            label2.TabIndex = 1;
            label2.Text = "Nhập Số Thứ Nhất";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 91);
            label3.Name = "label3";
            label3.Size = new Size(222, 27);
            label3.TabIndex = 2;
            label3.Text = "Nhập Số Thứ Hai";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 152);
            label4.Name = "label4";
            label4.Size = new Size(208, 27);
            label4.TabIndex = 3;
            label4.Text = "Nhập Số Thứ Ba";
            // 
            // textBoxNum1
            // 
            textBoxNum1.Location = new Point(273, 26);
            textBoxNum1.Name = "textBoxNum1";
            textBoxNum1.Size = new Size(317, 35);
            textBoxNum1.TabIndex = 4;
            // 
            // textBoxNum2
            // 
            textBoxNum2.Location = new Point(273, 88);
            textBoxNum2.Name = "textBoxNum2";
            textBoxNum2.Size = new Size(317, 35);
            textBoxNum2.TabIndex = 5;
            textBoxNum2.TextChanged += textBox2_TextChanged;
            // 
            // textBoxNum3
            // 
            textBoxNum3.Location = new Point(273, 144);
            textBoxNum3.Name = "textBoxNum3";
            textBoxNum3.Size = new Size(317, 35);
            textBoxNum3.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBoxNum3);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBoxNum2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBoxNum1);
            panel1.Location = new Point(36, 32);
            panel1.Name = "panel1";
            panel1.Size = new Size(616, 213);
            panel1.TabIndex = 7;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panel1);
            groupBox1.Font = new Font("SF Mono", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(73, 46);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(691, 251);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nhập";
            // 
            // btn_Find
            // 
            btn_Find.Font = new Font("SF Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Find.Location = new Point(179, 303);
            btn_Find.Name = "btn_Find";
            btn_Find.Size = new Size(94, 44);
            btn_Find.TabIndex = 8;
            btn_Find.Text = "Tìm";
            btn_Find.UseVisualStyleBackColor = true;
            btn_Find.Click += btn_Find_Click;
            // 
            // btn_Exit
            // 
            btn_Exit.Font = new Font("SF Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Exit.Location = new Point(369, 303);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(94, 44);
            btn_Exit.TabIndex = 9;
            btn_Exit.Text = "Thoát";
            btn_Exit.UseVisualStyleBackColor = true;
            btn_Exit.Click += btn_Exit_Click;
            // 
            // btn_Restore
            // 
            btn_Restore.Font = new Font("SF Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Restore.Location = new Point(551, 303);
            btn_Restore.Name = "btn_Restore";
            btn_Restore.Size = new Size(132, 44);
            btn_Restore.TabIndex = 10;
            btn_Restore.Text = "Đăt Lại";
            btn_Restore.UseVisualStyleBackColor = true;
            btn_Restore.Click += btn_Restore_Click;
            // 
            // textBoxMax
            // 
            textBoxMax.Font = new Font("SF Mono", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxMax.Location = new Point(151, 407);
            textBoxMax.Name = "textBoxMax";
            textBoxMax.ReadOnly = true;
            textBoxMax.Size = new Size(172, 29);
            textBoxMax.TabIndex = 11;
            textBoxMax.TextChanged += textBoxMax_TextChanged;
            // 
            // textBoxMin
            // 
            textBoxMin.Font = new Font("SF Mono", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxMin.Location = new Point(503, 407);
            textBoxMin.Name = "textBoxMin";
            textBoxMin.ReadOnly = true;
            textBoxMin.Size = new Size(190, 29);
            textBoxMin.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("SF Mono", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(90, 407);
            label5.Name = "label5";
            label5.Size = new Size(46, 24);
            label5.TabIndex = 13;
            label5.Text = "Max";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("SF Mono", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(451, 407);
            label6.Name = "label6";
            label6.Size = new Size(46, 24);
            label6.TabIndex = 14;
            label6.Text = "Min";
            // 
            // Ex2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBoxMin);
            Controls.Add(textBoxMax);
            Controls.Add(btn_Restore);
            Controls.Add(btn_Exit);
            Controls.Add(btn_Find);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Ex2";
            Text = "Bài2";
            FormClosed += Ex2_FormClosed;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxNum1;
        private TextBox textBoxNum2;
        private TextBox textBoxNum3;
        private Panel panel1;
        private GroupBox groupBox1;
        private Button btn_Find;
        private Button btn_Exit;
        private Button btn_Restore;
        private TextBox textBoxMax;
        private TextBox textBoxMin;
        private Label label5;
        private Label label6;
    }
}