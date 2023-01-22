using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calkylator
{
    public partial class Form1 : Form
    {
        string operaciya;
        string znachenie;
        bool flag;
        double chislo1, chislo2, resultat = 0;

        public Form1()
        {
            flag = false;
            InitializeComponent();
        }
    
        private void button5_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                flag = false;
                textBox1.Text = "0";
            }
            Button button = (Button)sender;

            if (textBox1.Text == "0")
            {
                textBox1.Text = button.Text;
            }
            else
            {
                textBox1.Text = textBox1.Text + button.Text;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            chislo2 = Convert.ToDouble(textBox1.Text);
            resultat = Math.Sqrt(chislo2);
            textBox1.Text = resultat.ToString();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            chislo2 = Convert.ToDouble(textBox1.Text);
            resultat = Math.Pow(chislo2, 2);
            textBox1.Text = resultat.ToString();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            chislo2 = Convert.ToDouble(textBox1.Text);
            resultat = 1/chislo2;
            textBox1.Text = resultat.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            chislo2 = Convert.ToDouble(textBox1.Text);
            resultat = -chislo2;
            textBox1.Text = resultat.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains(","))
            {
                textBox1.Text = textBox1.Text + ",";
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length-1);
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operaciya = button.Text;
            znachenie = textBox1.Text;
            textBox1.Clear();
            flag = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            chislo1 = Convert.ToDouble(znachenie);
            chislo2 = Convert.ToDouble(textBox1.Text);
            switch (operaciya)
            {
                case "+":
                    resultat = chislo1 + chislo2;
                    break;
                case "-":
                    resultat = chislo1 - chislo2;
                    break;
                case "*":
                    resultat = chislo1 * chislo2;
                    break;
                case "/":
                    resultat = chislo1 / chislo2;
                    if (chislo2 == 0)
                    {
                        MessageBox.Show("на 0 делить нельзя");
                    }
                    break;
                case "%":
                    resultat = chislo1 * chislo2 / 100;
                    break;
                default:
                    break;
            }

            flag = true;
            textBox1.Text = resultat.ToString();

        }
    }
}
