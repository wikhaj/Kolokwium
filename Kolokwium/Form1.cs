namespace Kolokwium
{
    public partial class Form1 : Form
    {
        public string note;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Matematyka" && textBox2.Text == "123")
            {
                Form f2 = new Form2();
                f2.Show();
            }
            else if (comboBox1.Text == "Filozofia" && textBox2.Text == "123")
            {
                Form f3 = new Form3(this);
                f3.Show();
            }
            else MessageBox.Show("Bledne dane logowania!");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}