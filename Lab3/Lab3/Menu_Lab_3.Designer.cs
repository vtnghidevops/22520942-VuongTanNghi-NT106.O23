namespace Lab3
{
    partial class Menu_Lab_3
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_Task1 = new Button();
            btn_Task2 = new Button();
            btn_Task3 = new Button();
            btn_Task4 = new Button();
            btn_Task5 = new Button();
            btn_Task6 = new Button();
            SuspendLayout();
            // 
            // btn_Task1
            // 
            btn_Task1.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Task1.Location = new Point(115, 76);
            btn_Task1.Name = "btn_Task1";
            btn_Task1.Size = new Size(91, 43);
            btn_Task1.TabIndex = 0;
            btn_Task1.Text = "Task 1";
            btn_Task1.UseVisualStyleBackColor = true;
            btn_Task1.Click += btn_Task1_Click;
            // 
            // btn_Task2
            // 
            btn_Task2.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Task2.Location = new Point(115, 162);
            btn_Task2.Name = "btn_Task2";
            btn_Task2.Size = new Size(91, 43);
            btn_Task2.TabIndex = 1;
            btn_Task2.Text = "Task 2";
            btn_Task2.UseVisualStyleBackColor = true;
            btn_Task2.Click += btn_Task2_Click;
            // 
            // btn_Task3
            // 
            btn_Task3.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Task3.Location = new Point(115, 268);
            btn_Task3.Name = "btn_Task3";
            btn_Task3.Size = new Size(91, 43);
            btn_Task3.TabIndex = 2;
            btn_Task3.Text = "Task 3";
            btn_Task3.UseVisualStyleBackColor = true;
            btn_Task3.Click += btn_Task3_Click;
            // 
            // btn_Task4
            // 
            btn_Task4.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Task4.Location = new Point(326, 76);
            btn_Task4.Name = "btn_Task4";
            btn_Task4.Size = new Size(91, 43);
            btn_Task4.TabIndex = 3;
            btn_Task4.Text = "Task 4";
            btn_Task4.UseVisualStyleBackColor = true;
            // 
            // btn_Task5
            // 
            btn_Task5.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Task5.Location = new Point(326, 162);
            btn_Task5.Name = "btn_Task5";
            btn_Task5.Size = new Size(91, 43);
            btn_Task5.TabIndex = 4;
            btn_Task5.Text = "Task 5";
            btn_Task5.UseVisualStyleBackColor = true;
            btn_Task5.Click += btn_Task5_Click;
            // 
            // btn_Task6
            // 
            btn_Task6.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Task6.Location = new Point(326, 268);
            btn_Task6.Name = "btn_Task6";
            btn_Task6.Size = new Size(91, 43);
            btn_Task6.TabIndex = 5;
            btn_Task6.Text = "Task 6";
            btn_Task6.UseVisualStyleBackColor = true;
            btn_Task6.Click += btn_Task6_Click;
            // 
            // Menu_Lab_3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(570, 406);
            Controls.Add(btn_Task6);
            Controls.Add(btn_Task5);
            Controls.Add(btn_Task4);
            Controls.Add(btn_Task3);
            Controls.Add(btn_Task2);
            Controls.Add(btn_Task1);
            Name = "Menu_Lab_3";
            Text = "Menu Lab 3";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Task1;
        private Button btn_Task2;
        private Button btn_Task3;
        private Button btn_Task4;
        private Button btn_Task5;
        private Button btn_Task6;
    }
}
