namespace Lab3
{
    partial class Task2
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
            rtb_showContent = new RichTextBox();
            btn_Listen = new Button();
            SuspendLayout();
            // 
            // rtb_showContent
            // 
            rtb_showContent.Location = new Point(55, 153);
            rtb_showContent.Name = "rtb_showContent";
            rtb_showContent.Size = new Size(525, 285);
            rtb_showContent.TabIndex = 0;
            rtb_showContent.Text = "";
            // 
            // btn_Listen
            // 
            btn_Listen.Location = new Point(486, 65);
            btn_Listen.Name = "btn_Listen";
            btn_Listen.Size = new Size(94, 29);
            btn_Listen.TabIndex = 1;
            btn_Listen.Text = "Listen";
            btn_Listen.UseVisualStyleBackColor = true;
            btn_Listen.Click += btn_Listen_Click;
            // 
            // Task2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(637, 450);
            Controls.Add(btn_Listen);
            Controls.Add(rtb_showContent);
            Name = "Task2";
            Text = "Task2";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox rtb_showContent;
        private Button btn_Listen;
    }
}