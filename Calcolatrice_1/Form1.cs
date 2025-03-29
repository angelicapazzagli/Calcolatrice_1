using System.Linq.Expressions;

namespace Calcolatrice_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string espressione;

        private void button14_Click(object sender, EventArgs e)
        {
            espressione += "*";
            lblFinestra.Text += "*";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            espressione += "1";
            lblFinestra.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            espressione += "2";
            lblFinestra.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            espressione += "3";
            lblFinestra.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            espressione += "4";
            lblFinestra.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            espressione += "5";
            lblFinestra.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            espressione += "6";
            lblFinestra.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            espressione += "7";
            lblFinestra.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            espressione += "8";
            lblFinestra.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            espressione += "9";
            lblFinestra.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            espressione += "0";
            lblFinestra.Text += "0";
        }

        private void addizione_Click(object sender, EventArgs e)
        {
            espressione += "+";
            lblFinestra.Text += "+";
        }

        private void sottrazione_Click(object sender, EventArgs e)
        {
            espressione += "-";
            lblFinestra.Text += "-";
        }

        private void divisione_Click(object sender, EventArgs e)
        {
            espressione += "/";
            lblFinestra.Text += "/";
        }

        private void risultato_Click(object sender, EventArgs e)
        {
            float ris = 0;
            float num_ope = 0;
            char operazione = '+';
            string numero = "";
            string num_cifre = "0123456789";
            for (int i = 0; i < espressione.Length; i++)
            {
                char c = espressione[i];

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
                    else if (operazione == '/')
                    {
                        num_ope /= n;
                    }
                    else if (operazione == '+')
                    {
                        ris += num_ope;
                        num_ope = n;
                    }
                    else if (operazione == '-')
                    {
                        ris += num_ope;
                        num_ope = -n;
                    }
                    operazione = c;
                }
            }
            if (numero != "")
            {
                int n = Int32.Parse(numero);
                if (operazione == '*')
                {
                    num_ope *= n;
                }
                else if (operazione == '/')
                {
                    num_ope /= n;
                }
                else if (operazione == '+')
                {
                    ris += num_ope;
                    num_ope = n;
                }
                else if (operazione == '-')
                {
                    ris += num_ope;
                    num_ope = -n;
                }
            }
            ris += num_ope;
            lblFinestra.Text = ris.ToString();
        }

        private void ac_Click(object sender, EventArgs e)
        {
            lblFinestra.Text = "";
            espressione = "";
        }
    }
}
