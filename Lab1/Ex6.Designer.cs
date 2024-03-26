namespace Lab1
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
            label3 = new Label();
            textBoxResult = new TextBox();
            textBoxDay = new TextBox();
            textBoxMonth = new TextBox();
            label4 = new Label();
            panel1 = new Panel();
            label5 = new Label();
            btn_Find = new Button();
            btn_Exit = new Button();
            btn_Restore = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SF Mono", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(254, 37);
            label1.Name = "label1";
            label1.Size = new Size(270, 33);
            label1.TabIndex = 0;
            label1.Text = "Cung Hoàng Đạo ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SF Mono", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(39, 29);
            label2.Name = "label2";
            label2.Size = new Size(208, 27);
            label2.TabIndex = 1;
            label2.Text = "Nhập Ngày Sinh";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SF Mono", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(157, 372);
            label3.Name = "label3";
            label3.Size = new Size(236, 27);
            label3.TabIndex = 2;
            label3.Text = "Cung Của Bạn Là ";
            // 
            // textBoxResult
            // 
            textBoxResult.Font = new Font("SF Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxResult.Location = new Point(417, 371);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new Size(209, 31);
            textBoxResult.TabIndex = 3;
            textBoxResult.TextChanged += textBoxResult_TextChanged;
            // 
            // textBoxDay
            // 
            textBoxDay.Font = new Font("SF Mono", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxDay.Location = new Point(285, 29);
            textBoxDay.Name = "textBoxDay";
            textBoxDay.Size = new Size(125, 29);
            textBoxDay.TabIndex = 4;
            // 
            // textBoxMonth
            // 
            textBoxMonth.Font = new Font("SF Mono", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxMonth.Location = new Point(285, 87);
            textBoxMonth.Name = "textBoxMonth";
            textBoxMonth.Size = new Size(125, 29);
            textBoxMonth.TabIndex = 6;
            textBoxMonth.TextChanged += textBox3_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("SF Mono", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(39, 87);
            label4.Name = "label4";
            label4.Size = new Size(222, 27);
            label4.TabIndex = 5;
            label4.Text = "Nhập Tháng Sinh";
            // 
            // panel1
            // 
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBoxMonth);
            panel1.Controls.Add(textBoxDay);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(173, 94);
            panel1.Name = "panel1";
            panel1.Size = new Size(503, 183);
            panel1.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("SF Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(39, 132);
            label5.Name = "label5";
            label5.Size = new Size(310, 24);
            label5.TabIndex = 8;
            label5.Text = "Lưu ý : Nhập Dưới Dạng Số";
            // 
            // btn_Find
            // 
            btn_Find.Font = new Font("SF Mono", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Find.Location = new Point(194, 296);
            btn_Find.Name = "btn_Find";
            btn_Find.Size = new Size(94, 45);
            btn_Find.TabIndex = 8;
            btn_Find.Text = "Tìm";
            btn_Find.UseVisualStyleBackColor = true;
            btn_Find.Click += btn_Find_Click;
            // 
            // btn_Exit
            // 
            btn_Exit.Font = new Font("SF Mono", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Exit.Location = new Point(371, 296);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(94, 45);
            btn_Exit.TabIndex = 9;
            btn_Exit.Text = "Thoát";
            btn_Exit.UseVisualStyleBackColor = true;
            btn_Exit.Click += btn_Exit_Click;
            // 
            // btn_Restore
            // 
            btn_Restore.Font = new Font("SF Mono", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Restore.Location = new Point(523, 296);
            btn_Restore.Name = "btn_Restore";
            btn_Restore.Size = new Size(136, 45);
            btn_Restore.TabIndex = 10;
            btn_Restore.Text = "Đặt Lại";
            btn_Restore.UseVisualStyleBackColor = true;
            btn_Restore.Click += button3_Click;
            // 
            // Ex6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Restore);
            Controls.Add(btn_Exit);
            Controls.Add(btn_Find);
            Controls.Add(panel1);
            Controls.Add(textBoxResult);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "Ex6";
            Text = "Bài 6";
            FormClosed += Ex6_FormClosed;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxResult;
        private TextBox textBoxDay;
        private TextBox textBoxMonth;
        private Label label4;
        private Panel panel1;
        private Label label5;
        private Button btn_Find;
        private Button btn_Exit;
        private Button btn_Restore;
    }
}