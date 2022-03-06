namespace Calculos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (comboBox1.SelectedItem.ToString() == "Celsius")
            {
                float result;
                result = (int.Parse(this.textBox1.Text) * 9 / 5) + 32f;

                this.textBox2.Text = Convert.ToString(result);

            }
            else
            {
                float result;
                result = ((int.Parse(this.textBox1.Text) - 32) * 5) / 9f;

                this.textBox2.Text = Convert.ToString(result);

            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }
    }
}