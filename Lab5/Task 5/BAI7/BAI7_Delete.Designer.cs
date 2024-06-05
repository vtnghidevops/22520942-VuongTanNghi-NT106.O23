namespace LAB4.BAI7
{
    partial class BAI7_Delete
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
            btnDeleteDish = new Button();
            tbDishId = new TextBox();
            label4 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnDeleteDish
            // 
            btnDeleteDish.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeleteDish.ForeColor = Color.FromArgb(255, 128, 0);
            btnDeleteDish.Location = new Point(28, 114);
            btnDeleteDish.Name = "btnDeleteDish";
            btnDeleteDish.Size = new Size(342, 35);
            btnDeleteDish.TabIndex = 22;
            btnDeleteDish.Text = "Xóa";
            btnDeleteDish.UseVisualStyleBackColor = true;
            btnDeleteDish.Click += btnDeleteDish_Click;
            // 
            // tbDishId
            // 
            tbDishId.Location = new Point(105, 76);
            tbDishId.Name = "tbDishId";
            tbDishId.Size = new Size(264, 23);
            tbDishId.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(255, 128, 0);
            label4.Location = new Point(37, 84);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 23;
            label4.Text = "ID món ăn";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(255, 128, 0);
            label1.Location = new Point(119, 29);
            label1.Name = "label1";
            label1.Size = new Size(146, 28);
            label1.TabIndex = 21;
            label1.Text = "XÓA MÓN ĂN";
            // 
            // BAI7_Delete
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 243);
            Controls.Add(btnDeleteDish);
            Controls.Add(tbDishId);
            Controls.Add(label4);
            Controls.Add(label1);
            Name = "BAI7_Delete";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BAI7_Delete";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDeleteDish;
        private TextBox tbDishId;
        private Label label4;
        private Label label1;
    }
}