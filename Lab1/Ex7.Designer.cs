namespace Lab1
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
            textBoxInputScores = new TextBox();
            labelInputScores = new Label();
            listViewScores = new ListView();
            columnSubject = new ColumnHeader();
            columnGrades = new ColumnHeader();
            labelAvg = new Label();
            labelMax = new Label();
            labelMin = new Label();
            labelGrade = new Label();
            labelPassed = new Label();
            labelFailed = new Label();
            textBoxAvg = new TextBox();
            textBoxMax = new TextBox();
            textBoxMin = new TextBox();
            textBoxGrades = new TextBox();
            textBoxPass = new TextBox();
            textBoxFail = new TextBox();
            labelTitle = new Label();
            buttonCalc = new Button();
            buttonReset = new Button();
            buttonExit = new Button();
            label1 = new Label();
            textBoxStudentName = new TextBox();
            SuspendLayout();
            // 
            // textBoxInputScores
            // 
            textBoxInputScores.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            textBoxInputScores.Location = new Point(334, 61);
            textBoxInputScores.Margin = new Padding(2);
            textBoxInputScores.Name = "textBoxInputScores";
            textBoxInputScores.Size = new Size(428, 30);
            textBoxInputScores.TabIndex = 0;
            textBoxInputScores.TextChanged += textBoxInputScores_TextChanged;
            // 
            // labelInputScores
            // 
            labelInputScores.AutoSize = true;
            labelInputScores.Font = new Font("SF Mono", 13.8F, FontStyle.Bold);
            labelInputScores.Location = new Point(42, 63);
            labelInputScores.Margin = new Padding(2, 0, 2, 0);
            labelInputScores.Name = "labelInputScores";
            labelInputScores.Size = new Size(278, 27);
            labelInputScores.TabIndex = 1;
            labelInputScores.Text = "Nhập Họ Tên Và Điểm";
            // 
            // listViewScores
            // 
            listViewScores.Columns.AddRange(new ColumnHeader[] { columnSubject, columnGrades });
            listViewScores.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            listViewScores.FullRowSelect = true;
            listViewScores.GridLines = true;
            listViewScores.Location = new Point(42, 131);
            listViewScores.Margin = new Padding(2);
            listViewScores.Name = "listViewScores";
            listViewScores.Size = new Size(186, 259);
            listViewScores.TabIndex = 2;
            listViewScores.UseCompatibleStateImageBehavior = false;
            listViewScores.View = View.Details;
            listViewScores.SelectedIndexChanged += listViewScores_SelectedIndexChanged;
            // 
            // columnSubject
            // 
            columnSubject.Text = "Môn";
            columnSubject.Width = 110;
            // 
            // columnGrades
            // 
            columnGrades.Text = "Điểm";
            columnGrades.Width = 100;
            // 
            // labelAvg
            // 
            labelAvg.AutoSize = true;
            labelAvg.Font = new Font("SF Mono", 12F, FontStyle.Bold);
            labelAvg.Location = new Point(244, 176);
            labelAvg.Margin = new Padding(2, 0, 2, 0);
            labelAvg.Name = "labelAvg";
            labelAvg.Size = new Size(190, 24);
            labelAvg.TabIndex = 3;
            labelAvg.Text = "Điểm Trung Bình";
            labelAvg.Click += labelAvg_Click;
            // 
            // labelMax
            // 
            labelMax.AutoSize = true;
            labelMax.Font = new Font("SF Mono", 12F, FontStyle.Bold);
            labelMax.Location = new Point(244, 215);
            labelMax.Margin = new Padding(2, 0, 2, 0);
            labelMax.Name = "labelMax";
            labelMax.Size = new Size(166, 24);
            labelMax.TabIndex = 4;
            labelMax.Text = "Điểm Cao Nhất";
            // 
            // labelMin
            // 
            labelMin.AutoSize = true;
            labelMin.Font = new Font("SF Mono", 12F, FontStyle.Bold);
            labelMin.Location = new Point(244, 254);
            labelMin.Margin = new Padding(2, 0, 2, 0);
            labelMin.Name = "labelMin";
            labelMin.Size = new Size(178, 24);
            labelMin.TabIndex = 5;
            labelMin.Text = "Điểm Thấp Nhất";
            // 
            // labelGrade
            // 
            labelGrade.AutoSize = true;
            labelGrade.Font = new Font("SF Mono", 12F, FontStyle.Bold);
            labelGrade.Location = new Point(245, 291);
            labelGrade.Margin = new Padding(2, 0, 2, 0);
            labelGrade.Name = "labelGrade";
            labelGrade.Size = new Size(106, 24);
            labelGrade.TabIndex = 6;
            labelGrade.Text = "Xếp Loại";
            // 
            // labelPassed
            // 
            labelPassed.AutoSize = true;
            labelPassed.Font = new Font("SF Mono", 12F, FontStyle.Bold);
            labelPassed.Location = new Point(245, 328);
            labelPassed.Margin = new Padding(2, 0, 2, 0);
            labelPassed.Name = "labelPassed";
            labelPassed.Size = new Size(130, 24);
            labelPassed.TabIndex = 7;
            labelPassed.Text = "Số Môn Đậu";
            // 
            // labelFailed
            // 
            labelFailed.AutoSize = true;
            labelFailed.Font = new Font("SF Mono", 12F, FontStyle.Bold);
            labelFailed.Location = new Point(245, 365);
            labelFailed.Margin = new Padding(2, 0, 2, 0);
            labelFailed.Name = "labelFailed";
            labelFailed.Size = new Size(130, 24);
            labelFailed.TabIndex = 8;
            labelFailed.Text = "Số Môn Rớt";
            // 
            // textBoxAvg
            // 
            textBoxAvg.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            textBoxAvg.Location = new Point(438, 176);
            textBoxAvg.Margin = new Padding(2);
            textBoxAvg.Name = "textBoxAvg";
            textBoxAvg.ReadOnly = true;
            textBoxAvg.Size = new Size(114, 30);
            textBoxAvg.TabIndex = 9;
            // 
            // textBoxMax
            // 
            textBoxMax.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            textBoxMax.Location = new Point(438, 215);
            textBoxMax.Margin = new Padding(2);
            textBoxMax.Name = "textBoxMax";
            textBoxMax.ReadOnly = true;
            textBoxMax.Size = new Size(114, 30);
            textBoxMax.TabIndex = 10;
            // 
            // textBoxMin
            // 
            textBoxMin.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            textBoxMin.Location = new Point(438, 254);
            textBoxMin.Margin = new Padding(2);
            textBoxMin.Name = "textBoxMin";
            textBoxMin.ReadOnly = true;
            textBoxMin.Size = new Size(114, 30);
            textBoxMin.TabIndex = 11;
            // 
            // textBoxGrades
            // 
            textBoxGrades.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            textBoxGrades.Location = new Point(438, 291);
            textBoxGrades.Margin = new Padding(2);
            textBoxGrades.Name = "textBoxGrades";
            textBoxGrades.ReadOnly = true;
            textBoxGrades.Size = new Size(114, 30);
            textBoxGrades.TabIndex = 12;
            textBoxGrades.TextChanged += textBoxGrades_TextChanged;
            // 
            // textBoxPass
            // 
            textBoxPass.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            textBoxPass.Location = new Point(438, 328);
            textBoxPass.Margin = new Padding(2);
            textBoxPass.Name = "textBoxPass";
            textBoxPass.ReadOnly = true;
            textBoxPass.Size = new Size(114, 30);
            textBoxPass.TabIndex = 13;
            // 
            // textBoxFail
            // 
            textBoxFail.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            textBoxFail.Location = new Point(438, 365);
            textBoxFail.Margin = new Padding(2);
            textBoxFail.Name = "textBoxFail";
            textBoxFail.ReadOnly = true;
            textBoxFail.Size = new Size(114, 30);
            textBoxFail.TabIndex = 14;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("SF Mono", 13.8F, FontStyle.Bold);
            labelTitle.Location = new Point(319, 9);
            labelTitle.Margin = new Padding(2, 0, 2, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(138, 27);
            labelTitle.TabIndex = 15;
            labelTitle.Text = "Tính Điểm";
            // 
            // buttonCalc
            // 
            buttonCalc.Font = new Font("SF Mono", 12F, FontStyle.Bold);
            buttonCalc.Location = new Point(665, 189);
            buttonCalc.Margin = new Padding(2);
            buttonCalc.Name = "buttonCalc";
            buttonCalc.Size = new Size(111, 48);
            buttonCalc.TabIndex = 16;
            buttonCalc.Text = "Tính";
            buttonCalc.UseVisualStyleBackColor = true;
            buttonCalc.Click += buttonCalc_Click;
            // 
            // buttonReset
            // 
            buttonReset.Font = new Font("SF Mono", 12F, FontStyle.Bold);
            buttonReset.Location = new Point(665, 263);
            buttonReset.Margin = new Padding(2);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(111, 48);
            buttonReset.TabIndex = 17;
            buttonReset.Text = "Đặt Lại";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += buttonReset_Click;
            // 
            // buttonExit
            // 
            buttonExit.Font = new Font("SF Mono", 12F, FontStyle.Bold);
            buttonExit.Location = new Point(665, 342);
            buttonExit.Margin = new Padding(2);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(111, 48);
            buttonExit.TabIndex = 18;
            buttonExit.Text = "Thoát";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SF Mono", 12F, FontStyle.Bold);
            label1.Location = new Point(245, 136);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(166, 24);
            label1.TabIndex = 19;
            label1.Text = "Tên Sinh Viên";
            // 
            // textBoxStudentName
            // 
            textBoxStudentName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            textBoxStudentName.Location = new Point(438, 130);
            textBoxStudentName.Margin = new Padding(2);
            textBoxStudentName.Name = "textBoxStudentName";
            textBoxStudentName.ReadOnly = true;
            textBoxStudentName.Size = new Size(269, 30);
            textBoxStudentName.TabIndex = 20;
            // 
            // Ex7
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(803, 468);
            Controls.Add(textBoxStudentName);
            Controls.Add(label1);
            Controls.Add(buttonExit);
            Controls.Add(buttonReset);
            Controls.Add(buttonCalc);
            Controls.Add(labelTitle);
            Controls.Add(textBoxFail);
            Controls.Add(textBoxPass);
            Controls.Add(textBoxGrades);
            Controls.Add(textBoxMin);
            Controls.Add(textBoxMax);
            Controls.Add(textBoxAvg);
            Controls.Add(labelFailed);
            Controls.Add(labelPassed);
            Controls.Add(labelGrade);
            Controls.Add(labelMin);
            Controls.Add(labelMax);
            Controls.Add(labelAvg);
            Controls.Add(listViewScores);
            Controls.Add(labelInputScores);
            Controls.Add(textBoxInputScores);
            Margin = new Padding(2);
            Name = "Ex7";
            Text = "Bài 7";
            FormClosed += Ex7_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxInputScores;
		private Label labelInputScores;
		private ListView listViewScores;
		private Label labelAvg;
		private Label labelMax;
		private Label labelMin;
		private Label labelGrade;
		private Label labelPassed;
		private Label labelFailed;
		private TextBox textBoxAvg;
		private TextBox textBoxMax;
		private TextBox textBoxMin;
		private TextBox textBoxGrades;
		private TextBox textBoxPass;
		private TextBox textBoxFail;
		private Label labelTitle;
		private Button buttonCalc;
		private Button buttonReset;
		private Button buttonExit;
		private ColumnHeader columnSubject;
		private ColumnHeader columnGrades;
        private Label label1;
        private TextBox textBoxStudentName;
    }
}