namespace Calcolatrice_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string numero;

        private void button14_Click(object sender, EventArgs e)
        {
            numero += "*";
            num.Text = numero;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            numero += "1";
            num.Text = numero;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            numero += "2";
            num.Text = numero;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            numero += "3";
            num.Text = numero;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            numero += "4";
            num.Text = numero;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            numero += "5";
            num.Text = numero;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            numero += "6";
            num.Text = numero;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            numero += "7";
            num.Text = numero;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            numero += "8";
            num.Text = numero;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            numero += "9";
            num.Text = numero;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            numero += "0";
            num.Text = numero;
        }

        private void addizione_Click(object sender, EventArgs e)
        {
            numero += "+";
            num.Text = numero;
        }

        private void sottrazione_Click(object sender, EventArgs e)
        {
            numero += "-";
            num.Text = numero;
        }

        private void divisione_Click(object sender, EventArgs e)
        {
            numero += "/";
            num.Text = numero;
        }

        private void risultato_Click(object sender, EventArgs e)
        {
            string cifre = "0123456789", primo = "";
            float op = 0, ris = 0;
            char operazione = '+';
            for (int i = 0; i < numero.Length; i++)
            {
                char c = numero[i];
                if (cifre.Contains(c))
                {
                    primo += c;
                }
                if (c == '+' || c == '-' || c == '*' || c == '/')
                {
                    int primo_i = Int32.Parse(primo);
                    primo = "";
                    if (operazione == '*')
                    {
                        op *= primo_i;
                    }
                    else if (operazione == '/')
                    {
                        op /= primo_i;
                    }
                    else if (operazione == '+')
                    {
                        ris += op;
                        op += primo_i;
                    }
                    else if (operazione == '-')
                    {
                        ris -= op;
                        op -= primo_i;
                    }
                    operazione = c;
                }
                if (primo != "")
                {
                    int primo_i = Int32.Parse(primo);
                    if (operazione == '*')
                    {
                        op *= primo_i;
                    }
                    else if (operazione == '/')
                    {
                        op /= primo_i;
                    }
                    else if (operazione == '+')
                    {
                        ris += op;
                        op += primo_i;
                    }
                    else if (operazione == '-')
                    {
                        ris -= op;
                        op -= primo_i;
                    }
                    operazione = c;
                }
                ris += op;
                num.Text = ris.ToString();
                numero = ris.ToString();
            }
        }

        private void ac_Click(object sender, EventArgs e)
        {
            num.Text = "";
            numero = "";
        }
    }
}
