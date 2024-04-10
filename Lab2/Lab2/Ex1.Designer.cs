namespace Lab2
{
    partial class Ex1
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
            btn_Read = new Button();
            btn_Write = new Button();
            btn_Exit = new Button();
            rtb_Result = new RichTextBox();
            btn_Restore = new Button();
            SuspendLayout();
            // 
            // btn_Read
            // 
            btn_Read.Font = new Font("SF Mono", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Read.Location = new Point(21, 27);
            btn_Read.Name = "btn_Read";
            btn_Read.Size = new Size(140, 65);
            btn_Read.TabIndex = 0;
            btn_Read.Text = "ĐỌC FILE";
            btn_Read.UseVisualStyleBackColor = true;
            btn_Read.Click += button1_Click;
            // 
            // btn_Write
            // 
            btn_Write.Font = new Font("SF Mono", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Write.Location = new Point(21, 107);
            btn_Write.Name = "btn_Write";
            btn_Write.Size = new Size(140, 62);
            btn_Write.TabIndex = 1;
            btn_Write.Text = "GHI FILE";
            btn_Write.UseVisualStyleBackColor = true;
            btn_Write.Click += btn_Write_Click;
            // 
            // btn_Exit
            // 
            btn_Exit.Font = new Font("SF Mono", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Exit.Location = new Point(21, 368);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(140, 47);
            btn_Exit.TabIndex = 2;
            btn_Exit.Text = "Thoát";
            btn_Exit.UseVisualStyleBackColor = true;
            btn_Exit.Click += btn_Exit_Click;
            // 
            // rtb_Result
            // 
            rtb_Result.Font = new Font("SF Mono", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtb_Result.Location = new Point(182, 27);
            rtb_Result.Name = "rtb_Result";
            rtb_Result.Size = new Size(606, 388);
            rtb_Result.TabIndex = 3;
            rtb_Result.Text = "";
            // 
            // btn_Restore
            // 
            btn_Restore.Font = new Font("SF Mono", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Restore.Location = new Point(21, 300);
            btn_Restore.Name = "btn_Restore";
            btn_Restore.Size = new Size(140, 53);
            btn_Restore.TabIndex = 4;
            btn_Restore.Text = "Đặt Lại";
            btn_Restore.UseVisualStyleBackColor = true;
            btn_Restore.Click += btn_Restore_Click;
            // 
            // Ex1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Restore);
            Controls.Add(rtb_Result);
            Controls.Add(btn_Exit);
            Controls.Add(btn_Write);
            Controls.Add(btn_Read);
            Name = "Ex1";
            Text = "Form1";
            Load += Ex1_Load;
            FormClosed += Ex1_FormClosed;
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Read;
        private Button btn_Write;
        private Button btn_Exit;
        private RichTextBox rtb_Result;
        private Button btn_Restore;
    }
}
