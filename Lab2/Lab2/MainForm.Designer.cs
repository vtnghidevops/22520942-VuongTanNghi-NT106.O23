namespace Lab2
{
    partial class MainForm
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
            btn_Ex7 = new Button();
            buttonExit = new Button();
            button6 = new Button();
            buttonEx2 = new Button();
            buttonEx6 = new Button();
            buttonEx5 = new Button();
            buttonEx3 = new Button();
            buttonEx1 = new Button();
            SuspendLayout();
            // 
            // btn_Ex7
            // 
            btn_Ex7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btn_Ex7.Location = new Point(344, 246);
            btn_Ex7.Margin = new Padding(2);
            btn_Ex7.Name = "btn_Ex7";
            btn_Ex7.Size = new Size(103, 42);
            btn_Ex7.TabIndex = 19;
            btn_Ex7.Text = "Bài 7";
            btn_Ex7.UseVisualStyleBackColor = true;
            btn_Ex7.Click += button2_Click_1;
            // 
            // buttonExit
            // 
            buttonExit.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            buttonExit.Location = new Point(344, 327);
            buttonExit.Margin = new Padding(2);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(103, 42);
            buttonExit.TabIndex = 17;
            buttonExit.Text = "Thoát";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click_1;
            // 
            // button6
            // 
            button6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            button6.Location = new Point(188, 155);
            button6.Margin = new Padding(2);
            button6.Name = "button6";
            button6.Size = new Size(103, 42);
            button6.TabIndex = 16;
            button6.Text = "Bài 4";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click_1;
            // 
            // buttonEx2
            // 
            buttonEx2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            buttonEx2.Location = new Point(344, 81);
            buttonEx2.Margin = new Padding(2);
            buttonEx2.Name = "buttonEx2";
            buttonEx2.Size = new Size(103, 42);
            buttonEx2.TabIndex = 15;
            buttonEx2.Text = "Bài 2";
            buttonEx2.UseVisualStyleBackColor = true;
            buttonEx2.Click += buttonEx2_Click_1;
            // 
            // buttonEx6
            // 
            buttonEx6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            buttonEx6.Location = new Point(510, 155);
            buttonEx6.Margin = new Padding(2);
            buttonEx6.Name = "buttonEx6";
            buttonEx6.Size = new Size(103, 42);
            buttonEx6.TabIndex = 14;
            buttonEx6.Text = "Bài 6**";
            buttonEx6.UseVisualStyleBackColor = true;
            buttonEx6.Click += buttonEx6_Click_1;
            // 
            // buttonEx5
            // 
            buttonEx5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            buttonEx5.Location = new Point(344, 155);
            buttonEx5.Margin = new Padding(2);
            buttonEx5.Name = "buttonEx5";
            buttonEx5.Size = new Size(103, 42);
            buttonEx5.TabIndex = 13;
            buttonEx5.Text = "Bài 5";
            buttonEx5.UseVisualStyleBackColor = true;
            buttonEx5.Click += buttonEx5_Click_1;
            // 
            // buttonEx3
            // 
            buttonEx3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            buttonEx3.Location = new Point(510, 81);
            buttonEx3.Margin = new Padding(2);
            buttonEx3.Name = "buttonEx3";
            buttonEx3.Size = new Size(103, 42);
            buttonEx3.TabIndex = 12;
            buttonEx3.Text = "Bài 3";
            buttonEx3.UseVisualStyleBackColor = true;
            buttonEx3.Click += buttonEx3_Click_1;
            // 
            // buttonEx1
            // 
            buttonEx1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            buttonEx1.Location = new Point(188, 81);
            buttonEx1.Margin = new Padding(2);
            buttonEx1.Name = "buttonEx1";
            buttonEx1.Size = new Size(103, 42);
            buttonEx1.TabIndex = 11;
            buttonEx1.Text = "Bài 1";
            buttonEx1.UseVisualStyleBackColor = true;
            buttonEx1.Click += buttonEx1_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Ex7);
            Controls.Add(buttonExit);
            Controls.Add(button6);
            Controls.Add(buttonEx2);
            Controls.Add(buttonEx6);
            Controls.Add(buttonEx5);
            Controls.Add(buttonEx3);
            Controls.Add(buttonEx1);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Ex7;
        private Button buttonExit;
        private Button button6;
        private Button buttonEx2;
        private Button buttonEx6;
        private Button buttonEx5;
        private Button buttonEx3;
        private Button buttonEx1;
    }
}