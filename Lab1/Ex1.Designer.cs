namespace Lab1
{
    partial class Ex1
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
            panel1 = new Panel();
            lb_EnterNum2 = new Label();
            lb_enterNum1 = new Label();
            textBoxNum2 = new TextBox();
            textBoxNum1 = new TextBox();
            btn_Cal = new Button();
            btn_Exit = new Button();
            btn_Restore = new Button();
            label4 = new Label();
            textBoxSum = new TextBox();
            lb_res = new Label();
            groupBox1 = new GroupBox();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lb_EnterNum2);
            panel1.Controls.Add(lb_enterNum1);
            panel1.Controls.Add(textBoxNum2);
            panel1.Controls.Add(textBoxNum1);
            panel1.Location = new Point(8, 34);
            panel1.Name = "panel1";
            panel1.Size = new Size(535, 165);
            panel1.TabIndex = 0;
            // 
            // lb_EnterNum2
            // 
            lb_EnterNum2.AutoSize = true;
            lb_EnterNum2.Font = new Font("SF Mono", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_EnterNum2.Location = new Point(15, 109);
            lb_EnterNum2.Name = "lb_EnterNum2";
            lb_EnterNum2.Size = new Size(222, 27);
            lb_EnterNum2.TabIndex = 3;
            lb_EnterNum2.Text = "Nhập Số Thứ Hai";
            // 
            // lb_enterNum1
            // 
            lb_enterNum1.AutoSize = true;
            lb_enterNum1.Font = new Font("SF Mono", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_enterNum1.Location = new Point(15, 40);
            lb_enterNum1.Name = "lb_enterNum1";
            lb_enterNum1.Size = new Size(236, 27);
            lb_enterNum1.TabIndex = 2;
            lb_enterNum1.Text = "Nhập Số Thứ Nhất";
            // 
            // textBoxNum2
            // 
            textBoxNum2.Font = new Font("SF Mono", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxNum2.Location = new Point(286, 111);
            textBoxNum2.Name = "textBoxNum2";
            textBoxNum2.Size = new Size(202, 35);
            textBoxNum2.TabIndex = 1;
            // 
            // textBoxNum1
            // 
            textBoxNum1.Font = new Font("SF Mono", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxNum1.Location = new Point(286, 42);
            textBoxNum1.Name = "textBoxNum1";
            textBoxNum1.Size = new Size(202, 35);
            textBoxNum1.TabIndex = 0;
            textBoxNum1.TextChanged += textBox1Num_TextChanged;
            // 
            // btn_Cal
            // 
            btn_Cal.Font = new Font("SF Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Cal.Location = new Point(150, 320);
            btn_Cal.Name = "btn_Cal";
            btn_Cal.Size = new Size(102, 41);
            btn_Cal.TabIndex = 1;
            btn_Cal.Text = "Tính";
            btn_Cal.UseVisualStyleBackColor = true;
            btn_Cal.Click += btn_Cal_Click;
            // 
            // btn_Exit
            // 
            btn_Exit.Font = new Font("SF Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Exit.Location = new Point(330, 320);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(110, 41);
            btn_Exit.TabIndex = 2;
            btn_Exit.Text = "Thoát";
            btn_Exit.UseVisualStyleBackColor = true;
            btn_Exit.Click += btn_Exit_Click;
            // 
            // btn_Restore
            // 
            btn_Restore.Font = new Font("SF Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Restore.Location = new Point(507, 322);
            btn_Restore.Name = "btn_Restore";
            btn_Restore.Size = new Size(127, 37);
            btn_Restore.TabIndex = 3;
            btn_Restore.Text = "Đặt Lại";
            btn_Restore.UseVisualStyleBackColor = true;
            btn_Restore.Click += btn_Restore_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("SF Mono", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(23, 19);
            label4.Name = "label4";
            label4.Size = new Size(452, 36);
            label4.TabIndex = 5;
            label4.Text = "Tính Tổng Hai Số Nguyên";
            // 
            // textBoxSum
            // 
            textBoxSum.Font = new Font("SF Mono", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxSum.Location = new Point(241, 406);
            textBoxSum.Name = "textBoxSum";
            textBoxSum.ReadOnly = true;
            textBoxSum.Size = new Size(347, 35);
            textBoxSum.TabIndex = 6;
            textBoxSum.TextChanged += textBoxRes_TextChanged;
            // 
            // lb_res
            // 
            lb_res.AutoSize = true;
            lb_res.Font = new Font("SF Mono", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_res.Location = new Point(112, 404);
            lb_res.Name = "lb_res";
            lb_res.Size = new Size(110, 27);
            lb_res.TabIndex = 7;
            lb_res.Text = "Kết Quả";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panel1);
            groupBox1.Font = new Font("SF Mono", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(122, 71);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(549, 205);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nhập";
            // 
            // Ex1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(lb_res);
            Controls.Add(textBoxSum);
            Controls.Add(label4);
            Controls.Add(btn_Restore);
            Controls.Add(btn_Exit);
            Controls.Add(btn_Cal);
            Name = "Ex1";
            Text = "Bài1";
            FormClosed += Ex1_FormClosed;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lb_EnterNum2;
        private Label lb_enterNum1;
        private TextBox textBoxNum2;
        private TextBox textBoxNum1;
        private Button btn_Cal;
        private Button btn_Exit;
        private Button btn_Restore;
        private Label label4;
        private TextBox textBoxSum;
        private Label lb_res;
        private GroupBox groupBox1;
    }
}