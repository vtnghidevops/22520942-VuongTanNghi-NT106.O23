using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Lab2.Ex4;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab2
{
    public partial class Ex4 : Form
    {
        public Ex4()
        {
            InitializeComponent();
        }
        // Class student
        public class Student
        {
            // Getter & setter
            public string Name { get; set; }
            public int ID { get; set; }
            public string phoneNumber { get; set; }
            public float Grade1 { get; set; }
            public float Grade2 { get; set; }
            public float Grade3 { get; set; }

            public double AverageGrade
            {
                get { return Average(); }

            }

            public double Average()
            {
                return Math.Round((Grade1 + Grade2 + Grade3) / 3.0, 2);
            }

            // Override ToString()
            public override string ToString()
            {
                string result = Name + "\n"
                    + ID.ToString() + "\n"
                    + phoneNumber.ToString() + "\n"
                    + Grade1.ToString() + "\n"
                    + Grade2.ToString() + "\n"
                    + Grade3.ToString() + "\n"
                    + AverageGrade.ToString() + "\n";
                return result;
            }

        }

        // List thông tin sinh viên
        List<Student> inputStudents = new List<Student>();
        List<Student> outputStudents = new List<Student>();

        // Biến lưu trữ số trang
        int page = 0;

        // Thêm các thông tin của sinh viên 
        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (IsTextBoxEmpty())
            {
                MessageBox.Show("Enter your full info, pls!!");
                return;
            }
            else
            {
                // Khởi tạo 1 đối tương student
                Student student = new Student();
                student.Name = tb_InputName.Text;

                // Thêm ID
                int ID;
                if (tb_InputID.Text.Length < 8 || int.TryParse(tb_InputID.Text, out ID) == false)
                {
                    MessageBox.Show("MSSV must be 8 digits");
                    return;
                }
                else
                {
                    student.ID = ID;
                }

                // Thêm PhoneNumber
                if (tb_InputPhone.Text[0] != '0' && tb_InputPhone.Text.Length > 10)
                {
                    MessageBox.Show("Phone must 10 numbers and begin with 0");
                    return;
                }
                else
                {

                    student.phoneNumber = tb_InputPhone.Text;
                }

                // Thêm Điểm Các Môn
                float cour1, cour2, cour3;
                if (!(float.TryParse(tb_InputCourse1.Text, out cour1) &&
                    float.TryParse(tb_InputCourse2.Text, out cour2) &&
                    float.TryParse(tb_InputCourse3.Text, out cour3)))
                {
                    MessageBox.Show("Invalid point, try again");
                    return;
                }
                else
                {
                    student.Grade1 = cour1;
                    student.Grade2 = cour2;
                    student.Grade3 = cour3;

                }

                // Thêm điểm trung bình
                tb_InputAver.Text = student.AverageGrade.ToString();
                // Thêm student vào list outputStudents
                outputStudents.Add(student);

                // Gỡ giá trị hiển thị ở richTextBox sau khi thêm
                rtb_Result.Clear();

                // Hiển thị các sinh viên đã add vào richTextBox
                foreach (Student sv in outputStudents)
                {
                    rtb_Result.Text += sv.ToString() + "------------------------------\n";
                }

                // Xóa thông tin add bên phần input -> Cb có thể add thêm
                tb_InputName.Text = string.Empty;   
                tb_InputID.Text = string.Empty;
                tb_InputPhone.Text = string.Empty;
                tb_InputCourse1.Text = string.Empty;
                tb_InputCourse2.Text = string.Empty;
                tb_InputCourse3.Text = string.Empty;
                tb_InputAver.Text = string.Empty;
            }


        }

        // Check các box cái rỗng không -> nếu rỗng thông báo 
        private bool IsTextBoxEmpty()
        {
            if (string.IsNullOrEmpty(tb_InputName.Text) ||
                string.IsNullOrEmpty(tb_InputID.Text) ||
                string.IsNullOrEmpty(tb_InputPhone.Text) ||
                string.IsNullOrEmpty(tb_InputCourse1.Text) ||
                string.IsNullOrEmpty(tb_InputCourse2.Text) ||
                string.IsNullOrEmpty(tb_InputCourse3.Text))
            {
                return true;
            }
            return false;
        }

        // Obj to JSON
        static void SerializeToFileJson(string filePath, List<Student> obj)
        {
            try
            {
                var options = new JsonSerializerOptions()
                {
                    IncludeFields = true,
                };
                // Serialize the object to JSON format
                string json = JsonSerializer.Serialize(obj, options);
                File.WriteAllText(filePath, json);
                MessageBox.Show($"Serialized data successfully written to {filePath} ");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occurred while serializing data: {ex.Message} ");
            }
        }


        private void tb_InputAver_TextChanged(object sender, EventArgs e)
        {

        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tbInputMon1_TextChanged(object sender, EventArgs e)
        {

        }


        private List<Student> DeserializeFromFileJson(string filePath)
        {
            try
            {
                // Read the JSON data from the file
                string json = File.ReadAllText(filePath);
                // Deserialize the JSON data to the specified type
                return JsonSerializer.Deserialize<List<Student>>(json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occurred while deserializing data: {ex.Message}");
                return default;
            }
        }

        private void showStudent(Student student)
        {
            if (student != null)
            {
                tb_ReadName.Text = student.Name;
                tb_ReadID.Text = student.ID.ToString();
                tb_ReadPhone.Text = student.phoneNumber;
                tb_ReadCourse1.Text = student.Grade1.ToString(); // Update tb_ReadCourse1 with Grade1
                tb_ReadCourse2.Text = student.Grade2.ToString(); // Update tb_ReadCourse2 with Grade2
                tb_ReadCourse3.Text = student.Grade3.ToString(); // Update tb_ReadCourse3 with Grade3
                tbReadAver.Text = student.AverageGrade.ToString();
                return;
            }
            else
            {
                MessageBox.Show("Student does not exist");
                return;
            }
        }


        private void btn_Exit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Back_Click_1(object sender, EventArgs e)
        {
            // Page > 0 -> Lui page
            if (page > 0)
            {
                page -= 1;
                lb_orderNum.Text = (page).ToString();
                showStudent(inputStudents[(int)page]);
            }
        }

        private void btn_Next_Click_1(object sender, EventArgs e)
        {
            // Page < List student - 1 --> Tiến page
            if (page < inputStudents.Count - 1)
            {
                page += 1;
                lb_orderNum.Text = (page).ToString();
                showStudent(inputStudents[((int)page)]);
            }
        }

        private void lb_orderNum_Click(object sender, EventArgs e)
        {

        }

        private void btn_Write_Click_1(object sender, EventArgs e)
        {
            if (outputStudents == null || outputStudents.Count == 0)
            {
                MessageBox.Show("No student data available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Viết thông tin sinh viên vào file json
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                try
                {
                    // If the file already exists, read the existing data
                    if (File.Exists(filePath))
                    {
                        string fileContent = File.ReadAllText(filePath);
                        Student[] existingStudents = JsonSerializer.Deserialize<Student[]>(fileContent);

                        // Concatenate inputStudents with existingStudents
                        outputStudents = existingStudents.Concat(outputStudents).ToList();

                    }

                    // Serialize the updated array of students to JSON
                    string jsonString = JsonSerializer.Serialize(outputStudents, new JsonSerializerOptions { WriteIndented = true });

                    // Write the serialized JSON string to the file
                    File.WriteAllText(filePath, jsonString);

                    MessageBox.Show("File saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while saving the file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_Read_Click_1(object sender, EventArgs e)
        {
            // Đọc thông tin sinh viên từ đầu vào 
            OpenFileDialog openFileDialog = new OpenFileDialog();
            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    lb_orderNum.Text = page.ToString();
                    string filePath = openFileDialog.FileName;
                    inputStudents = DeserializeFromFileJson(filePath);
                    if (inputStudents == null || inputStudents.Count == 0)
                    {
                        MessageBox.Show("List empty");
                    }
                    showStudent(inputStudents[0]);
                }
                else
                {
                    MessageBox.Show("Can not open file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tb_InputName_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_InputAver_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Ex4_FormClosed(object sender, FormClosedEventArgs e)
        {
            var MainForm = new MainForm();
            MainForm.Show();
        }
    }
}