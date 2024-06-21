namespace Lab6
{
    partial class MainMenu
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
            Ex_1 = new Button();
            Ex_2 = new Button();
            Ex_3 = new Button();
            SuspendLayout();
            // 
            // Ex_1
            // 
            Ex_1.Cursor = Cursors.Hand;
            Ex_1.Font = new Font("SF Mono", 12F);
            Ex_1.Location = new Point(18, 74);
            Ex_1.Margin = new Padding(4, 4, 4, 4);
            Ex_1.Name = "Ex_1";
            Ex_1.Size = new Size(192, 52);
            Ex_1.TabIndex = 0;
            Ex_1.Text = "Bài 1";
            Ex_1.UseVisualStyleBackColor = true;
            Ex_1.Click += Ex_1_Click;
            // 
            // Ex_2
            // 
            Ex_2.Cursor = Cursors.Hand;
            Ex_2.Font = new Font("SF Mono", 12F);
            Ex_2.Location = new Point(219, 74);
            Ex_2.Margin = new Padding(4, 4, 4, 4);
            Ex_2.Name = "Ex_2";
            Ex_2.Size = new Size(184, 52);
            Ex_2.TabIndex = 1;
            Ex_2.Text = "Bài 2";
            Ex_2.UseVisualStyleBackColor = true;
            Ex_2.Click += Ex_2_Click;
            // 
            // Ex_3
            // 
            Ex_3.Cursor = Cursors.Hand;
            Ex_3.Font = new Font("SF Mono", 12F);
            Ex_3.Location = new Point(120, 171);
            Ex_3.Margin = new Padding(4, 4, 4, 4);
            Ex_3.Name = "Ex_3";
            Ex_3.Size = new Size(186, 44);
            Ex_3.TabIndex = 2;
            Ex_3.Text = "Bài 3";
            Ex_3.UseVisualStyleBackColor = true;
            Ex_3.Click += Ex_3_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(422, 278);
            Controls.Add(Ex_3);
            Controls.Add(Ex_2);
            Controls.Add(Ex_1);
            Font = new Font("SF Mono", 12F);
            Margin = new Padding(4, 4, 4, 4);
            Name = "MainMenu";
            Text = "MainMenu";
            Load += MainMenu_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button Ex_1;
        private Button Ex_2;
        private Button Ex_3;
    }
}
