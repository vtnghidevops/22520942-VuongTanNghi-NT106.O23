namespace Lab1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            textBoxResult = new TextBox();
            textBoxInput = new TextBox();
            btn_Read = new Button();
            btn_Exit = new Button();
            btn_Restore = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SF Mono", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(148, 48);
            label1.Name = "label1";
            label1.Size = new Size(508, 33);
            label1.TabIndex = 0;
            label1.Text = "Đọc Số Thành Chữ Số Tương Ứng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SF Mono", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(16, 31);
            label2.Name = "label2";
            label2.Size = new Size(358, 24);
            label2.TabIndex = 1;
            label2.Text = "Nhập Vào Số Nguyên Từ 0 Đến 9";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SF Mono", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(16, 97);
            label3.Name = "label3";
            label3.Size = new Size(142, 24);
            label3.TabIndex = 2;
            label3.Text = "Kết Quả Đọc";
            // 
            // panel1
            // 
            panel1.Controls.Add(textBoxResult);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBoxInput);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(132, 115);
            panel1.Name = "panel1";
            panel1.Size = new Size(539, 157);
            panel1.TabIndex = 3;
            // 
            // textBoxResult
            // 
            textBoxResult.Font = new Font("SF Mono", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxResult.Location = new Point(185, 97);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new Size(125, 31);
            textBoxResult.TabIndex = 8;
            // 
            // textBoxInput
            // 
            textBoxInput.Font = new Font("SF Mono", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxInput.Location = new Point(388, 28);
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(123, 31);
            textBoxInput.TabIndex = 7;
            textBoxInput.TextChanged += textBox1_TextChanged;
            // 
            // btn_Read
            // 
            btn_Read.Font = new Font("SF Mono", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Read.Location = new Point(170, 316);
            btn_Read.Name = "btn_Read";
            btn_Read.Size = new Size(94, 50);
            btn_Read.TabIndex = 4;
            btn_Read.Text = "Đọc";
            btn_Read.UseVisualStyleBackColor = true;
            btn_Read.Click += btn_Read_Click;
            // 
            // btn_Exit
            // 
            btn_Exit.Font = new Font("SF Mono", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Exit.Location = new Point(348, 316);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(94, 50);
            btn_Exit.TabIndex = 5;
            btn_Exit.Text = "Thoát";
            btn_Exit.UseVisualStyleBackColor = true;
            btn_Exit.Click += button2_Click;
            // 
            // btn_Restore
            // 
            btn_Restore.Font = new Font("SF Mono", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Restore.Location = new Point(517, 316);
            btn_Restore.Name = "btn_Restore";
            btn_Restore.Size = new Size(115, 50);
            btn_Restore.TabIndex = 6;
            btn_Restore.Text = "Đặt Lại";
            btn_Restore.UseVisualStyleBackColor = true;
            btn_Restore.Click += btn_Restore_Click;
            // 
            // Ex3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(783, 466);
            Controls.Add(btn_Restore);
            Controls.Add(btn_Exit);
            Controls.Add(btn_Read);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "Ex3";
            Text = "Bài3";
            FormClosed += Ex3_FormClosed;

            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private TextBox textBoxResult;
        private TextBox textBoxInput;
        private Button btn_Read;
        private Button btn_Exit;
        private Button btn_Restore;
    }
}