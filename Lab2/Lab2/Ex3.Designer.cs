namespace Lab2
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
            rtb_Display = new RichTextBox();
            btn_Read = new Button();
            btn_Cal = new Button();
            label1 = new Label();
            btn_Exit = new Button();
            SuspendLayout();
            // 
            // rtb_Display
            // 
            rtb_Display.Location = new Point(294, 43);
            rtb_Display.Name = "rtb_Display";
            rtb_Display.Size = new Size(494, 360);
            rtb_Display.TabIndex = 1;
            rtb_Display.Text = "";
            // 
            // btn_Read
            // 
            btn_Read.Font = new Font("SF Mono", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Read.Location = new Point(43, 145);
            btn_Read.Name = "btn_Read";
            btn_Read.Size = new Size(193, 58);
            btn_Read.TabIndex = 2;
            btn_Read.Text = "READ FROM FILE";
            btn_Read.UseVisualStyleBackColor = true;
            btn_Read.Click += btn_Read_Click;
            // 
            // btn_Cal
            // 
            btn_Cal.Font = new Font("SF Mono", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Cal.Location = new Point(12, 240);
            btn_Cal.Name = "btn_Cal";
            btn_Cal.Size = new Size(258, 58);
            btn_Cal.TabIndex = 3;
            btn_Cal.Text = "CACULATE EXPRESSION";
            btn_Cal.UseVisualStyleBackColor = true;
            btn_Cal.Click += btn_Cal_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SF Mono", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Crimson;
            label1.Location = new Point(12, 43);
            label1.Name = "label1";
            label1.Size = new Size(264, 27);
            label1.TabIndex = 4;
            label1.Text = "CACULATE FROM FILE";
            // 
            // btn_Exit
            // 
            btn_Exit.Font = new Font("SF Mono", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Exit.Location = new Point(82, 345);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(108, 58);
            btn_Exit.TabIndex = 5;
            btn_Exit.Text = "EXIT";
            btn_Exit.UseVisualStyleBackColor = true;
            btn_Exit.Click += btn_Exit_Click;
            // 
            // Ex3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Exit);
            Controls.Add(label1);
            Controls.Add(btn_Cal);
            Controls.Add(btn_Read);
            Controls.Add(rtb_Display);
            Name = "Ex3";
            Text = "Ex3";
            Load += Ex3_Load;
            FormClosed += Ex3_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox rtb_Display;
        private Button btn_Read;
        private Button btn_Cal;
        private Label label1;
        private Button btn_Exit;
    }
}