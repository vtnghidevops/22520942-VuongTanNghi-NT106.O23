namespace LAB4.BAI7
{
    partial class BAI7_Add
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
            label3 = new Label();
            label8 = new Label();
            tbImageUrl = new TextBox();
            btnAddDish = new Button();
            rtbDescription = new RichTextBox();
            label2 = new Label();
            tbAddress = new TextBox();
            label7 = new Label();
            tbPrice = new TextBox();
            label6 = new Label();
            tbDishName = new TextBox();
            label5 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(255, 128, 0);
            label1.Location = new Point(139, 39);
            label1.Name = "label1";
            label1.Size = new Size(154, 30);
            label1.TabIndex = 0;
            label1.Text = "Thêm Món Ăn";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 184);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 42;
            label3.Text = "Hình ảnh";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(38, 97);
            label8.Name = "label8";
            label8.Size = new Size(69, 15);
            label8.TabIndex = 43;
            label8.Text = "Tên món ăn";
            // 
            // tbImageUrl
            // 
            tbImageUrl.BorderStyle = BorderStyle.FixedSingle;
            tbImageUrl.Location = new Point(116, 179);
            tbImageUrl.Name = "tbImageUrl";
            tbImageUrl.Size = new Size(264, 23);
            tbImageUrl.TabIndex = 36;
            // 
            // btnAddDish
            // 
            btnAddDish.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddDish.Location = new Point(38, 372);
            btnAddDish.Name = "btnAddDish";
            btnAddDish.Size = new Size(342, 35);
            btnAddDish.TabIndex = 30;
            btnAddDish.Text = "Thêm";
            btnAddDish.UseVisualStyleBackColor = true;
            btnAddDish.Click += btnAddDish_Click;
            // 
            // rtbDescription
            // 
            rtbDescription.Location = new Point(116, 208);
            rtbDescription.Name = "rtbDescription";
            rtbDescription.Size = new Size(264, 136);
            rtbDescription.TabIndex = 29;
            rtbDescription.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 212);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 32;
            label2.Text = "Mô tả";
            // 
            // tbAddress
            // 
            tbAddress.BorderStyle = BorderStyle.FixedSingle;
            tbAddress.Location = new Point(116, 150);
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(264, 23);
            tbAddress.TabIndex = 28;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(38, 183);
            label7.Name = "label7";
            label7.Size = new Size(56, 15);
            label7.TabIndex = 31;
            label7.Text = "Hình ảnh";
            // 
            // tbPrice
            // 
            tbPrice.BorderStyle = BorderStyle.FixedSingle;
            tbPrice.Location = new Point(116, 121);
            tbPrice.Name = "tbPrice";
            tbPrice.Size = new Size(264, 23);
            tbPrice.TabIndex = 27;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(38, 154);
            label6.Name = "label6";
            label6.Size = new Size(43, 15);
            label6.TabIndex = 33;
            label6.Text = "Địa chỉ";
            // 
            // tbDishName
            // 
            tbDishName.BorderStyle = BorderStyle.FixedSingle;
            tbDishName.Location = new Point(116, 92);
            tbDishName.Name = "tbDishName";
            tbDishName.Size = new Size(264, 23);
            tbDishName.TabIndex = 26;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(38, 125);
            label5.Name = "label5";
            label5.Size = new Size(24, 15);
            label5.TabIndex = 34;
            label5.Text = "Giá";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 96);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 35;
            label4.Text = "Tên món ăn";
            // 
            // BAI7_Add
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(443, 450);
            Controls.Add(label3);
            Controls.Add(label8);
            Controls.Add(tbImageUrl);
            Controls.Add(btnAddDish);
            Controls.Add(rtbDescription);
            Controls.Add(label2);
            Controls.Add(tbAddress);
            Controls.Add(label7);
            Controls.Add(tbPrice);
            Controls.Add(label6);
            Controls.Add(tbDishName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Name = "BAI7_Add";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BAI7_Add";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label8;
        private TextBox tbImageUrl;
        private Button btnAddDish;
        private RichTextBox rtbDescription;
        private Label label2;
        private TextBox tbAddress;
        private Label label7;
        private TextBox tbPrice;
        private Label label6;
        private TextBox tbDishName;
        private Label label5;
        private Label label4;
    }
}