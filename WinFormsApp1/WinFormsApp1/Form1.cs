namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        int sum = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //textBox1.Text = "I am Sadik";
            //string name = textBox1.Text;

            // MessageBox.Show("textBox1.Text");
            textBox1.Text = "1";
            // sum = Convert.ToInt32(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sum = Convert.ToInt32(textBox1.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = (sum + Convert.ToInt32(textBox1.Text)).ToString();
        }
    }

}

