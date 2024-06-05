namespace Lab5.Task4
{
    partial class Task4
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
            flpMovies = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // flpMovies
            // 
            flpMovies.AutoScroll = true;
            flpMovies.Location = new Point(12, 12);
            flpMovies.Name = "flpMovies";
            flpMovies.Size = new Size(776, 426);
            flpMovies.TabIndex = 0;
            // 
            // Task4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(flpMovies);
            Name = "Task4";
            Text = "List Movie";
            Load += Task4_Load;
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flpMovies;
    }
}