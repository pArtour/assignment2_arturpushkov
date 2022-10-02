namespace assignment2_arturpushkov
{
    public partial class Form1 : Form
    {

        private const decimal classAPrice = 15;
        private const decimal classBPrice = 12;
        private const decimal classCPrice = 9;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            numericUpDown3.Value = 0;
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox4.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal classATotal = numericUpDown1.Value * classAPrice;
            decimal classBTotal = numericUpDown2.Value * classBPrice;
            decimal classCTotal = numericUpDown3.Value * classCPrice;
            decimal total = classATotal + classBTotal + classCTotal;

            textBox1.Text = classATotal.ToString("c");
            textBox2.Text = classBTotal.ToString("c");
            textBox3.Text = classCTotal.ToString("c");
            textBox4.Text = total.ToString("c");
        }
    }
}