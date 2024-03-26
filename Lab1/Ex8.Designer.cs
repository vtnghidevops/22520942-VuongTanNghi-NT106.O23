namespace Lab1
{
    partial class Ex8
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
            btn_add = new Button();
            btn_find = new Button();
            btn_del = new Button();
            btn_exit = new Button();
            textBoxInput = new TextBox();
            textBoxResult = new TextBox();
            panel1 = new Panel();
            listBoxFood = new ListBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SF Mono", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(18, 32);
            label1.Name = "label1";
            label1.Size = new Size(131, 21);
            label1.TabIndex = 0;
            label1.Text = "Nhập Món Ăn";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SF Mono", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(281, 400);
            label2.Name = "label2";
            label2.Size = new Size(214, 24);
            label2.TabIndex = 1;
            label2.Text = "Món Ăn Hôm Nay Là";
            // 
            // btn_add
            // 
            btn_add.Font = new Font("SF Mono", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_add.Location = new Point(267, 75);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(104, 48);
            btn_add.TabIndex = 2;
            btn_add.Text = "Thêm";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // btn_find
            // 
            btn_find.Font = new Font("SF Mono", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_find.Location = new Point(101, 313);
            btn_find.Name = "btn_find";
            btn_find.Size = new Size(170, 46);
            btn_find.TabIndex = 3;
            btn_find.Text = "Tìm Món Ăn";
            btn_find.UseVisualStyleBackColor = true;
            btn_find.Click += button2_Click;
            // 
            // btn_del
            // 
            btn_del.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_del.Location = new Point(557, 315);
            btn_del.Name = "btn_del";
            btn_del.Size = new Size(103, 46);
            btn_del.TabIndex = 4;
            btn_del.Text = "Xóa";
            btn_del.UseVisualStyleBackColor = true;
            btn_del.Click += btn_restore_Click;
            // 
            // btn_exit
            // 
            btn_exit.Font = new Font("SF Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_exit.Location = new Point(352, 315);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(94, 46);
            btn_exit.TabIndex = 5;
            btn_exit.Text = "Thoát";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // textBoxInput
            // 
            textBoxInput.Font = new Font("SF Mono", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxInput.Location = new Point(166, 26);
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(205, 29);
            textBoxInput.TabIndex = 6;
            // 
            // textBoxResult
            // 
            textBoxResult.BackColor = SystemColors.ButtonHighlight;
            textBoxResult.Font = new Font("SF Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxResult.ImeMode = ImeMode.NoControl;
            textBoxResult.Location = new Point(244, 446);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new Size(269, 31);
            textBoxResult.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.Controls.Add(listBoxFood);
            panel1.Controls.Add(textBoxInput);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btn_add);
            panel1.Location = new Point(32, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(738, 258);
            panel1.TabIndex = 9;
            // 
            // listBoxFood
            // 
            listBoxFood.FormattingEnabled = true;
            listBoxFood.Location = new Point(397, 23);
            listBoxFood.Name = "listBoxFood";
            listBoxFood.Size = new Size(324, 224);
            listBoxFood.TabIndex = 7;
            listBoxFood.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // Ex8
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 503);
            Controls.Add(panel1);
            Controls.Add(textBoxResult);
            Controls.Add(btn_del);
            Controls.Add(label2);
            Controls.Add(btn_find);
            Controls.Add(btn_exit);
            Name = "Ex8";
            Text = "Bài 8";
            FormClosed += Ex8_FormClosed;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btn_add;
        private Button btn_find;
        private Button btn_del;
        private Button btn_exit;
        private TextBox textBoxInput;
        private TextBox textBoxResult;
        private Panel panel1;
        private ListBox listBoxFood;
    }
}