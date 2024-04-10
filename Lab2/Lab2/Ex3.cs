using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Ex3 : Form
    {
        public Ex3()
        {
            InitializeComponent();
        }

        public class MathExpressionEvaluator
        {
            public static double Evaluate(string expression)
            {
                expression = expression.Replace(" ", "");
                return EvaluateExpression(expression);
            }

            private static double EvaluateExpression(string expression)
            {
                // Dựa trên nghịch lý Balan để xử lí

                // Khởi tạo 2 stack lưu trữ số và toán hạng
                Stack<double> numbers = new Stack<double>();
                Stack<char> operations = new Stack<char>();
                // Duyệt qua từng phần tử của chuỗi toán hạng được đưa vào

                for (int i = 0; i < expression.Length; i++)
                {
                    // Là khoảng trắng -> Tiếp tục lặp

                    char c = expression[i];
                    if (c == ' ') continue;

                    // Nếu kí tự tại vị trí này là số hoặc là dấu "."
                    if (char.IsDigit(c) || c == '.')
                    {
                        // Chuỗi lưu số
                        string numStr = c.ToString();

                        // Nếu phần tử này < độ dài của chuỗi toán hạng được đưa vào đồng thời vị trí sau nó là số
                        // hoặc là "."
                        while (i + 1 < expression.Length && (char.IsDigit(expression[i + 1]) || expression[i + 1] == '.'))
                        {
                            // Cộng dồn giá trị vào numStr -> lúc này nó sẽ chứa các số hoặc .
                            numStr += expression[i + 1];
                            i++;
                        }
                        // Chuyển kiểu string -> Double
                        double num = double.Parse(numStr, CultureInfo.InvariantCulture);
                        // Đưa vào stack
                        numbers.Push(num);
                    }
                    else if (c == '(')
                    {
                        // Trường hợp là dấu ngoặc trái ( mở )
                        // Push vào stack để đánh dấu vị trí các toán hạng trong biểu thức con này
                        operations.Push(c);
                    }
                    else if (c == ')')
                    {
                        // Trường hợp là dấu ngoặc phải ( đóng )
                        // 1 vòng lặp lấy các giá trị trong biểu thưc (....) mà không xóa khỏi stack
                        // Nếu lấy từ stack ra chưa gặp giá trị là "(" tức mở của biểu thức con đó
                        // Thì gọi lại hàm và tiếp tục đưa vào stack
                        while (operations.Peek() != '(')
                        {
                            EvaluateOperation(numbers, operations);
                        }
                        // Sau khi xong -> Xóa "("
                        operations.Pop(); 
                    }
                    else
                    {
                        // Trường hợp ưu tiên toán hạng , ta có độ ưu tiên như sau
                        // Độ ưu tiên "^" = 3 , "*/" = 2 , "+-" = 1;
                        // Nếu mức độ ưu tiên của toán tử đang xét cao hơn hoặc bằng
                        // chúng ta tiếp tục thực hiện các phép tính trên stack numbers và operations.
                        while (operations.Count > 0 && GetPriority(operations.Peek()) >= GetPriority(c))
                        {
                            EvaluateOperation(numbers, operations);
                        }
                        // Thêm toán tử hiện tại vào stack
                        operations.Push(c);
                    }
                }

                while (operations.Count > 0)
                {
                    EvaluateOperation(numbers, operations);
                }
                // Khi thực hiện xong -> Xóa khỏi stack
                return numbers.Pop();
            }

            private static void EvaluateOperation(Stack<double> numbers, Stack<char> operations)
            {
                // Lấy toán tử đầu stack
                // Lấy 2 số hạng đầu stack
                char op = operations.Pop();
                double num2 = numbers.Pop();
                double num1 = numbers.Pop();
                double result = 0;

                switch (op)
                {
                    case '^':
                        result = Math.Pow(num1, num2);
                        break;
                    case '+':
                        result = num1 + num2;
                        break;
                    case '-':
                        result = num1 - num2;
                        break;
                    case '*':
                        result = num1 * num2;
                        break;
                    case '/':
                        result = num1 / num2;
                        break;
                }
                // Lưu kết quả khi tính toán
                numbers.Push(result);
            }

            // Hàm mức độ ưu tiên
            private static int GetPriority(char op)
            {
                if (op == '^')
                    return 3;
                else if (op == '*' || op == '/')
                    return 2;
                else if (op == '+' || op == '-')
                    return 1;
                return 0;
            }
        }

        private void btn_Read_Click(object sender, EventArgs e)
        {
            // Mở đường dẫn file
            OpenFileDialog ofd = new OpenFileDialog();
            // Chỉ định chọn file định dạng file đuôi .txt
            ofd.Filter = "Text File|*.txt";

            try
            {

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
                    StreamReader sr = new StreamReader(fs);
                    rtb_Display.Text += sr.ReadToEnd();
                    fs.Close();

                    MessageBox.Show($"Read successfully from {ofd.FileName}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Can not open file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading the file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }


        private void btn_Cal_Click(object sender, EventArgs e)
        {
            OpenFileDialog sfDialog = new OpenFileDialog();
            sfDialog.Filter = "Text File|*.txt";

            try
            {
                if (sfDialog.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream fs = new FileStream(sfDialog.FileName, FileMode.OpenOrCreate))
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        // Lưu từng dòng của richTextBox
                        string[] lines = rtb_Display.Lines;
                        
                        // Duyệt qua từng phần tử của mỗi dòng
                        for ( int i = 0; i < lines.Length; i++ )
                        {
                            double result = MathExpressionEvaluator.Evaluate(lines[i]);

                            string formattedResult = IsInteger(result) ? ((int)result).ToString() : result.ToString("0.0", CultureInfo.InvariantCulture);

                            sw.WriteLine($"{lines[i]} = {formattedResult}");
                        }

                    }

                    MessageBox.Show("Calculation completed. Results written to output3.txt", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Đọc và hiển thị kết quả nếu có
                    string outputFileContent = File.ReadAllText(sfDialog.FileName, Encoding.UTF8);
                    rtb_Display.Text = outputFileContent;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Ex3_Load(object sender, EventArgs e)
        {

        }

        private static bool IsInteger(double number)
        {
            // number % 1 -> Nếu là số nguyên -> mod 1 = 0
            // double.Epsilon là một hằng số cực nhỏ đại diện cho khoảng cách tối thiểu giữa hai số double
            // có thể được biểu diễn. Mục đích của việc nhân double.Epsilon với 100 ở đây là tạo ra một ngưỡng nhỏ,
            // có thể được sử dụng để xác định xem phần dư của number có gần bằng 0 hay không.
            // Math.Abs(number % 1) < double.Epsilon * 100: Nếu giá trị tuyệt đối của phần dư của
            // number khi chia cho 1 nhỏ hơn ngưỡng nhỏ được tạo ra từ double.Epsilon * 100,
            // có nghĩa là phần dư của number gần bằng 0 --> number gần với một số nguyên.
            return Math.Abs(number % 1) < double.Epsilon * 100;
        }

        private void Ex3_FormClosed(object sender, FormClosedEventArgs e)
        {
            var MainForm = new MainForm();
            MainForm.Show();
        }
    }


}