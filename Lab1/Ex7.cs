﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab1
{
    public partial class Ex7 : Form
    {
        public Ex7()
        {
            InitializeComponent();
            _scores = null;
        }

        private double[]? _scores;

        private void StringScoresToArray(ref double[]? scores, ref string studentName)
        {
            if (string.IsNullOrEmpty(textBoxInputScores.Text))
            {
                MessageBox.Show("Chưa có dữ liệu vui lòng thử lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string[] inputStrings = textBoxInputScores.Text.Split(',');
            studentName = inputStrings[0].Trim(); // Lấy tên sinh viên
            scores = new double[inputStrings.Length - 1]; // Khởi tạo mảng điểm
            double num;
            for (int i = 1; i < inputStrings.Length; i++)
            {
                if (!Double.TryParse(inputStrings[i], out num))
                {
                    MessageBox.Show("Định dạng sai, mỗi phần tử điểm cách nhau dấu cách phẩy \",\"" +
                    "\n Ví dụ: Nguyễn Thị A, 7.5, 5, 8, 10, 9, 10, 8.5, 9, 10", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Array.Clear(scores, 0, scores.Length);
                    scores = null;
                    return;
                }
                if (num < 0 || num > 10)
                {
                    MessageBox.Show("Điểm từ (0 - 10)", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Array.Clear(scores, 0, scores.Length);
                    scores = null;
                    return;
                }
                scores[i - 1] = num; // i - 1 vì mảng điểm bắt đầu từ 0
            }
        }

        private string GetGrade(double[] scores)
        {
            if (scores.Min() >= 6.5 && scores.Average() >= 8)
            {
                return "Giỏi";
            }
            else if (scores.Min() >= 5 && scores.Average() >= 6.5)
            {
                return "Khá";
            }
            else if (scores.Min() >= 3.5 && scores.Average() >= 5)
            {
                return "Trung Bình";
            }
            else if (scores.Min() >= 2 && scores.Max() >= 3.5)
            {
                return "Yếu";
            }
            else
            {
                return "Kém";
            }
        }

        private int GetPass(double[] scores)
        {
            return scores.Count(i => i >= 5);
        }

        private int GetFail(double[] scores)
        {
            return scores.Count(i => i < 5);
        }

        private void ArrayToListView(double[] scores)
        {
            for (int i = 0; i < scores.Length; i++)
            {
                listViewScores.Items.Add(new ListViewItem(new[] { (i + 1).ToString(), scores[i].ToString("0.##") }));
            }
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            string studentName = "";
            StringScoresToArray(ref _scores, ref studentName);
            if (_scores != null && _scores.Length != 0)
            {
                listViewScores.Items.Clear();
                ArrayToListView(_scores);
                textBoxAvg.Text = _scores.Average().ToString("0.##");
                textBoxMin.Text = _scores.Min().ToString("0.##");
                textBoxMax.Text = _scores.Max().ToString("0.##");
                textBoxGrades.Text = GetGrade(_scores);
                textBoxPass.Text = GetPass(_scores).ToString();
                textBoxFail.Text = GetFail(_scores).ToString();
                textBoxStudentName.Text = studentName; // Hiển thị tên sinh viên
            }
            else
            {
                return;
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxStudentName.Text = string.Empty;
            textBoxInputScores.Text = string.Empty;
            textBoxAvg.Text = string.Empty;
            textBoxMin.Text = string.Empty;
            textBoxMax.Text = string.Empty;
            textBoxGrades.Text = string.Empty;
            textBoxPass.Text = string.Empty;
            textBoxFail.Text = string.Empty;
            _scores = null;
            listViewScores.Items.Clear();

            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void Ex6_FormClosed(object sender, FormClosedEventArgs e)
        {
            var MainForm = new MainForm();
            MainForm.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listViewScores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxInputScores_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelAvg_Click(object sender, EventArgs e)
        {

        }
        private void Ex7_FormClosed(object sender, FormClosedEventArgs e)
        {
            var MainForm = new MainForm();
            MainForm.Show();
        }

        private void textBoxGrades_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
