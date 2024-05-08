using Lab03;

namespace Lab3
{
    public partial class Menu_Lab_3 : Form
    {
        public Menu_Lab_3()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Task1_Click(object sender, EventArgs e)
        {
            Task_1 task_1 = new Task_1();
            task_1.Show();
        }

        private void btn_Task3_Click(object sender, EventArgs e)
        {
            Bai03_Client client = new Bai03_Client();
            client.Show();
            Bai03_Server server = new Bai03_Server();
            server.Show();
        }

        private void btn_Task2_Click(object sender, EventArgs e)
        {
            Task2 task2 = new Task2();
            task2.Show();
        }

        private void btn_Task6_Click(object sender, EventArgs e)
        {
            Task_6 task_6 = new Task_6();
            task_6.Show();
        }

        private void btn_Task5_Click(object sender, EventArgs e)
        {
            Task5 task5 = new Task5();
            task5.Show();
        }
    }
}
