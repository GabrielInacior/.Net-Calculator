using System.Globalization;

namespace Calculadora1
{
    public partial class Calculadora : Form
    {

        decimal valor1 = 0;
        decimal valor2 = 0;
        string operacao = "";
        public Calculadora()
        {
            InitializeComponent();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            txtOperacao.Text = txtOperacao.Text + "0";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            txtOperacao.Text = txtOperacao.Text + "1";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            txtOperacao.Text = txtOperacao.Text + "2";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            txtOperacao.Text = txtOperacao.Text + "3";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtOperacao.Text = txtOperacao.Text + "4";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtOperacao.Text = txtOperacao.Text + "5";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtOperacao.Text = txtOperacao.Text + "6";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtOperacao.Text = txtOperacao.Text + "7";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtOperacao.Text = txtOperacao.Text + "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtOperacao.Text = txtOperacao.Text + "9";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            txtOperacao.Text += ".";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            valor2 = decimal.Parse(txtOperacao.Text, CultureInfo.InvariantCulture);

            if (operacao == "SOMA")
            {
                txtOperacao.Text = Convert.ToString(valor1 + valor2);
            }
            else if (operacao == "SUBTRACAO")
            {
                txtOperacao.Text = Convert.ToString(valor1 - valor2);
            }
            else if (operacao == "MULTIPLICACAO")
            {
                txtOperacao.Text = Convert.ToString(valor1 * valor2);
            }
            else if (operacao == "DIVISAO")
            {
                txtOperacao.Text = Convert.ToString(valor1 / valor2);
            }
            else
            {
                txtOperacao.Text = "INVALIDO";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {   
            if (txtOperacao.Text != "")
            {
                valor1 = decimal.Parse(txtOperacao.Text, CultureInfo.InvariantCulture);

                txtOperacao.Text = "";
                operacao = "SOMA";
                lblOperacao.Text = "+";
            }
            else
            {
                MessageBox.Show(" Digite um valor para efetuar a soma");
            }
           
        }

        private void button7_Click(object sender, EventArgs e)
        {   
            if (txtOperacao.Text != "")
            {
                valor1 = decimal.Parse(txtOperacao.Text, CultureInfo.InvariantCulture);

                txtOperacao.Text = "";
                operacao = "SUBTRACAO";
                lblOperacao.Text = "-";
            }
            else
            {
                MessageBox.Show(" Digite um valor para efetuar a subtração");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {   
            if (txtOperacao.Text != "")
            {
                valor1 = decimal.Parse(txtOperacao.Text, CultureInfo.InvariantCulture);

                txtOperacao.Text = "";
                operacao = "MULTIPLICACAO";
                lblOperacao.Text = "*";
            }
            else
            {
                MessageBox.Show(" Digite um valor para efetuar a multiplicação ");
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {   
            if (txtOperacao.Text!= "")
            {
                valor1 = decimal.Parse(txtOperacao.Text, CultureInfo.InvariantCulture);

                txtOperacao.Text = "";
                operacao = "DIVISAO";
                lblOperacao.Text = "÷";
            }
            else
            {
                MessageBox.Show(" Digite um valor para efetuar a divisão");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtOperacao.Text = "";
            lblOperacao.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            operacao = "";
            lblOperacao.Text = "";
            valor1 = 0;
            valor2 = 0;
        }
    }
}
