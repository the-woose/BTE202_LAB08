namespace BTE202_LAB08
{
    public partial class Form1 : Form
    {
        public decimal operand1, operand2 = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "";
            }
            txtDisplay.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "";
            }
            txtDisplay.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "";
            }
            txtDisplay.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "";
            }
            txtDisplay.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "";
            }
            txtDisplay.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "";
            }
            txtDisplay.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "";
            }
            txtDisplay.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "";
            }
            txtDisplay.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "";
            }
            txtDisplay.Text += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "";
            }
            txtDisplay.Text += "0";
        }

        private void buttonPoint_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += ".";
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            buttonPlus.Enabled = true;
            buttonEquals.Enabled = true;
            operand1 = operand2 = 0;
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            decimal.TryParse(txtDisplay.Text, out operand1);
            txtDisplay.Text = "0";
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtDisplay.Text, out operand2))
            {
                decimal result = operand1 + operand2;
                txtDisplay.Text = result.ToString();
                buttonPlus.Enabled = false;
                buttonEquals.Enabled = false;
            }
            else
            {
                txtDisplay.Text = "Hatalı Giriş";
            }
        }
    }
}