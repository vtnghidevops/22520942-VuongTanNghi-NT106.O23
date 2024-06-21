using Chat_P2P;

namespace Lab6
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void Ex_1_Click(object sender, EventArgs e)
        {
            Task1 Ex1 = new Task1();

            Ex1.Show();
        }

        private void Ex_2_Click(object sender, EventArgs e)
        {
            Task2 Ex2 = new Task2();

            Ex2.Show();
        }

        private void Ex_3_Click(object sender, EventArgs e)
        {
            Task3 Ex3 = new Task3();

            Ex3.Show();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
