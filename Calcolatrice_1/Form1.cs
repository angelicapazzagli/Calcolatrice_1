using System.Linq.Expressions;

namespace Calcolatrice_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string numero;
        float ris;

        private void button14_Click(object sender, EventArgs e)
        {
            numero += "*";
            lblFinestra.Text += "*";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            numero += "1";
            lblFinestra.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            numero += "2";
            lblFinestra.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            numero += "3";
            lblFinestra.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            numero += "4";
            lblFinestra.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            numero += "5";
            lblFinestra.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            numero += "6";
            lblFinestra.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            numero += "7";
            lblFinestra.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            numero += "8";
            lblFinestra.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            numero += "9";
            lblFinestra.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            numero += "0";
            lblFinestra.Text += "0";
        }

        private void addizione_Click(object sender, EventArgs e)
        {
            numero += "+";
            lblFinestra.Text += "+";
        }

        private void sottrazione_Click(object sender, EventArgs e)
        {
            numero += "-";
            lblFinestra.Text += "-";
        }

        private void divisione_Click(object sender, EventArgs e)
        {
            numero += "/";
            lblFinestra.Text += "/";
        }

        private void risultato_Click(object sender, EventArgs e)
        {
            float ris = 0;
            float num_ope = 0;
            char ope = '+';
            string numero = "";
            string num_cifre = "0123456789";

            for (int i = 0; i < numero.Length; i++)
            {
                char c = numero[i];

                if (num_cifre.Contains(c))
                {
                    numero += c;
                }

                if (c == '+' || c == '-' || c == '*' || c == '/')
                {
                    int n = Int32.Parse(numero);
                    numero = "";

                    if (n == '*')
                    {
                        num_ope *= n;
                    }
                    else if (ope == '/')
                    {
                        num_ope /= n;
                    }
                    else if (ope == '+')
                    {
                        ris += num_ope;
                        num_ope = n;
                    }
                    else if (ope == '-')
                    {
                        ris += num_ope;
                        num_ope = -n;
                    }
                    ope = c;
                }
            }
            if (numero != "")
            {
                int n = Int32.Parse(numero);
                if (ope == '*')
                {
                    num_ope *= n;
                }
                else if (ope == '/')
                {
                    num_ope /= n;
                }
                else if (ope == '+')
                {
                    ris += num_ope;
                    num_ope = n;
                }
                else if (ope == '-')
                {
                    ris += num_ope;
                    num_ope = -n;
                }
            }
            ris += num_ope;
            lblFinestra.Text = ris.ToString();
            numero = ris.ToString();
        }

        private void ac_Click(object sender, EventArgs e)
        {
            lblFinestra.Text = "";
            numero = "";
        }
    }
}
