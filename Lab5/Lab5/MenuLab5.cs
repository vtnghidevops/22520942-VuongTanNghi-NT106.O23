namespace Lab5
{
    public partial class MenuLab5 : Form
    {
        public MenuLab5()
        {
            InitializeComponent();
        }

        private void btn_Task1_Click(object sender, EventArgs e)
        {
            Task1 task1 = new Task1();
            task1.Show();
        }

        private void btn_Task2_Click(object sender, EventArgs e)
        {
            Task2 task2 = new Task2();
            task2.Show();
        }

        private void btn_Task3_Click(object sender, EventArgs e)
        {
            Task3 task3 = new Task3();
            task3.Show();
        }

        private void btn_Task4_Click(object sender, EventArgs e)
        {
            Task4.Task4 task4 = new Task4.Task4();
            task4.Show();
        }

        private void btn_Task5_Click(object sender, EventArgs e)
        {
            Task5 task5 = new Task5();
            task5.Show();

        }

        private void btn_Task6_Click(object sender, EventArgs e)
        {
            
        }


    }
}
