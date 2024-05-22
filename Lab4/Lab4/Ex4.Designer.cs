namespace Lab4
{
    partial class Ex4
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
            panel1 = new Panel();
            progressBar1 = new ProgressBar();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(802, 611);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(0, 607);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(802, 47);
            progressBar1.TabIndex = 1;
            // 
            // Ex4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 652);
            Controls.Add(progressBar1);
            Controls.Add(panel1);
            Name = "Ex4";
            Text = "Ex4";
            Load += Ex4_Load;
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ProgressBar progressBar1;
    }
}