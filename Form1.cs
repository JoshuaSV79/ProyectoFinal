namespace ProyectoGina
{
    public partial class Form1 : Form
    {

        ToolTip toolTip1 = new ToolTip();
        public Form1()
        {

            InitializeComponent();
            toolTip1.SetToolTip(button1, "Ingresar al sistema");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            login f2 = new login();
            f2.Show();
            this.Hide();

        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }
    }
}
