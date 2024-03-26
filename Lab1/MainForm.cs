namespace Lab1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.FormClosed += (sender, e) => Application.Exit();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonEx1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Ex1 = new Ex1();
            Ex1.Show();
        }

        private void buttonEx2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Ex2 = new Ex2();
            Ex2.Show();

        }

        private void buttonEx3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Ex3 = new Ex3();
            Ex3.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Ex4 = new Ex4();
            Ex4.Show();
        }

        private void buttonEx5_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Ex5 = new Ex5();
            Ex5.Show();
        }

        private void buttonEx6_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Ex6 = new Ex6();
            Ex6.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Ex3_1 = new Ex3_1();
            Ex3_1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Ex7 = new Ex7();
            Ex7.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Ex8 = new Ex8();
            Ex8.Show();
        }
    }
}