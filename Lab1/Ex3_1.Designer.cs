namespace Lab1
{
    partial class Ex3_1
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
            button_Read = new Button();
            button2 = new Button();
            btn_Restore = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SF Mono", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(273, 26);
            label1.Name = "label1";
            label1.Size = new Size(270, 33);
            label1.TabIndex = 0;
            label1.Text = "Đọc Số Nâng Cao";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SF Mono", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(10, 44);
            label2.Name = "label2";
            label2.Size = new Size(292, 27);
            label2.TabIndex = 1;
            label2.Text = "Nhập Số Có 12 Chữ Số";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SF Mono", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(10, 125);
            label3.Name = "label3";
            label3.Size = new Size(110, 27);
            label3.TabIndex = 2;
            label3.Text = "Kết Quả";
            label3.Click += label3_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(textBoxResult);
            panel1.Controls.Add(textBoxInput);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(62, 79);
            panel1.Name = "panel1";
            panel1.Size = new Size(726, 222);
            panel1.TabIndex = 3;
            // 
            // textBoxResult
            // 
            textBoxResult.Font = new Font("SF Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxResult.Location = new Point(148, 97);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new Size(562, 88);
            textBoxResult.TabIndex = 4;
            // 
            // textBoxInput
            // 
            textBoxInput.Font = new Font("SF Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxInput.Location = new Point(344, 40);
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(287, 31);
            textBoxInput.TabIndex = 3;
            textBoxInput.TextChanged += textBoxInput_TextChanged;
            // 
            // button_Read
            // 
            button_Read.Font = new Font("SF Mono", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_Read.Location = new Point(200, 332);
            button_Read.Name = "button_Read";
            button_Read.Size = new Size(94, 58);
            button_Read.TabIndex = 4;
            button_Read.Text = "Đọc";
            button_Read.UseVisualStyleBackColor = true;
            button_Read.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("SF Mono", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(391, 332);
            button2.Name = "button2";
            button2.Size = new Size(94, 58);
            button2.TabIndex = 5;
            button2.Text = "Thoát";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btn_Restore
            // 
            btn_Restore.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Restore.Location = new Point(580, 332);
            btn_Restore.Name = "btn_Restore";
            btn_Restore.Size = new Size(113, 58);
            btn_Restore.TabIndex = 6;
            btn_Restore.Text = "Đặt Lại";
            btn_Restore.UseVisualStyleBackColor = true;
            btn_Restore.Click += btn_Restore_Click;
            // 
            // Ex3_1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Restore);
            Controls.Add(button2);
            Controls.Add(button_Read);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "Ex3_1";
            Text = "Bài 3.1";
            FormClosed += Ex3_1_FormClosed;
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
        private Button button_Read;
        private Button button2;
        private Button btn_Restore;
    }
}