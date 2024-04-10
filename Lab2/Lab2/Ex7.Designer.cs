namespace Lab2
{
    partial class Ex7
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
            treeView = new TreeView();
            pBox_Content = new PictureBox();
            rTB_TextContent = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)pBox_Content).BeginInit();
            SuspendLayout();
            // 
            // treeView
            // 
            treeView.Location = new Point(12, 12);
            treeView.Name = "treeView";
            treeView.Size = new Size(279, 637);
            treeView.TabIndex = 0;
            treeView.AfterSelect += treeView_AfterSelect;
            treeView.NodeMouseDoubleClick += treeView_NodeMouseDoubleClick;
            // 
            // pBox_Content
            // 
            pBox_Content.Location = new Point(316, 12);
            pBox_Content.Name = "pBox_Content";
            pBox_Content.Size = new Size(634, 637);
            pBox_Content.TabIndex = 1;
            pBox_Content.TabStop = false;
            // 
            // rTB_TextContent
            // 
            rTB_TextContent.Location = new Point(316, 12);
            rTB_TextContent.Name = "rTB_TextContent";
            rTB_TextContent.Size = new Size(634, 616);
            rTB_TextContent.TabIndex = 2;
            rTB_TextContent.Text = "";
            // 
            // Ex7
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 665);
            Controls.Add(rTB_TextContent);
            Controls.Add(pBox_Content);
            Controls.Add(treeView);
            Name = "Task_7";
            Text = "Task_7";
            FormClosed += Ex7_FormClosed;
            ((System.ComponentModel.ISupportInitialize)pBox_Content).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TreeView treeView;
        private PictureBox pBox_Content;
        private RichTextBox rTB_TextContent;
    }
}