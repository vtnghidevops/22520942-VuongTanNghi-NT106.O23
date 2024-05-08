namespace Lab3
{
    partial class Task5_1
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
            btn_Random = new Button();
            btn_ListMonAn = new Button();
            btn_Exit = new Button();
            PictureBox = new PictureBox();
            lvList = new ListView();
            clIDMA = new ColumnHeader();
            clTenMonAn = new ColumnHeader();
            groupBoxAn = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)PictureBox).BeginInit();
            groupBoxAn.SuspendLayout();
            SuspendLayout();
            // 
            // btn_Random
            // 
            btn_Random.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Random.Location = new Point(305, 357);
            btn_Random.Name = "btn_Random";
            btn_Random.Size = new Size(94, 29);
            btn_Random.TabIndex = 0;
            btn_Random.Text = "Random";
            btn_Random.UseVisualStyleBackColor = true;
            btn_Random.Click += btn_Random_Click;
            // 
            // btn_ListMonAn
            // 
            btn_ListMonAn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_ListMonAn.Location = new Point(465, 357);
            btn_ListMonAn.Name = "btn_ListMonAn";
            btn_ListMonAn.Size = new Size(124, 29);
            btn_ListMonAn.TabIndex = 1;
            btn_ListMonAn.Text = "List Món ăn";
            btn_ListMonAn.UseVisualStyleBackColor = true;
            btn_ListMonAn.Click += btn_ListMonAn_Click;
            // 
            // btn_Exit
            // 
            btn_Exit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Exit.Location = new Point(669, 357);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(94, 29);
            btn_Exit.TabIndex = 2;
            btn_Exit.Text = "Exit";
            btn_Exit.UseVisualStyleBackColor = true;
            btn_Exit.Click += btn_Exit_Click;
            // 
            // PictureBox
            // 
            PictureBox.Location = new Point(21, 26);
            PictureBox.Name = "PictureBox";
            PictureBox.Size = new Size(435, 285);
            PictureBox.TabIndex = 3;
            PictureBox.TabStop = false;
            // 
            // lvList
            // 
            lvList.Columns.AddRange(new ColumnHeader[] { clIDMA, clTenMonAn });
            lvList.GridLines = true;
            lvList.Location = new Point(12, 21);
            lvList.Name = "lvList";
            lvList.Size = new Size(254, 365);
            lvList.TabIndex = 4;
            lvList.UseCompatibleStateImageBehavior = false;
            lvList.View = View.Details;
            // 
            // clIDMA
            // 
            clIDMA.Text = "IDMA";
            // 
            // clTenMonAn
            // 
            clTenMonAn.Text = "Tên Món Ăn";
            clTenMonAn.Width = 120;
            // 
            // groupBoxAn
            // 
            groupBoxAn.Controls.Add(PictureBox);
            groupBoxAn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBoxAn.Location = new Point(284, 21);
            groupBoxAn.Name = "groupBoxAn";
            groupBoxAn.Size = new Size(479, 330);
            groupBoxAn.TabIndex = 5;
            groupBoxAn.TabStop = false;
            groupBoxAn.Text = "Hôm nay ăn:";
            // 
            // Task5_1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxAn);
            Controls.Add(lvList);
            Controls.Add(btn_Exit);
            Controls.Add(btn_ListMonAn);
            Controls.Add(btn_Random);
            Name = "Task5_1";
            Text = "Task5_1";
            ((System.ComponentModel.ISupportInitialize)PictureBox).EndInit();
            groupBoxAn.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Random;
        private Button btn_ListMonAn;
        private Button btn_Exit;
        private PictureBox PictureBox;
        private ListView lvList;
        private ColumnHeader clIDMA;
        private ColumnHeader clTenMonAn;
        private GroupBox groupBoxAn;
    }
}