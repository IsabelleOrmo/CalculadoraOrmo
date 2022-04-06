using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraOrmo
{
    public partial class Form1 : Form
    {

        private double numero1, numero2, resultado;
        private string operacao;
        private Boolean pressionouIgual;

        public Form1()
        {
            InitializeComponent();
        }

        private void addDigito(string digito)
        {
            if (pressionouIgual)
            {
                limparCampos();
            }

            if (display.Text.Trim().Equals("0"))
            {
                display.Text = digito;
            }
            else
            {
                display.Text = display.Text + digito;
            }
        }

        private void addOperacao(string caractere)
        {
            if (!display.Text.Trim().Equals(String.Empty))
            {
                numero1 = Convert.ToDouble(display.Text.Trim());
                display.Clear();
                operacao = caractere;
            }
        }

        private void limparCampos()
        {
            numero1 = 0;
            numero2 = 0;
            operacao = String.Empty;
            resultado = 0;
            pressionouIgual = false;
            display.Clear();
        }

        private void calcular()
        {
            switch (operacao) 
            {
                case "+":
                    resultado = numero1 + numero2;
                    break;

                case "-":
                    resultado = numero1 - numero2;
                    break;

                case "/":
                    if(numero2 == 0)
                    {
                        MessageBox.Show("Não divida por zero.");
                    } 
                    else
                    {
                        resultado = numero1 / numero2;
                    }
                    break;

                case "*":
                    resultado = numero1 * numero2;
                    break;

                case "^":
                    resultado = Math.Pow(numero1, numero2);
                    break;
            }
            display.Text = resultado.ToString();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }                                    

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_num1_Click(object sender, EventArgs e)
        {
            addDigito("1");
        }

        private void button_num2_Click(object sender, EventArgs e)
        {
            addDigito("2");
        }

        private void button_num3_Click(object sender, EventArgs e)
        {
            addDigito("3");
        }

        private void button_num4_Click(object sender, EventArgs e)
        {
            addDigito("4");
        }

        private void button_num5_Click(object sender, EventArgs e)
        {
            addDigito("5");
        }

        private void button_num6_Click(object sender, EventArgs e)
        {
            addDigito("6");
        }

        private void button_num7_Click(object sender, EventArgs e)
        {
            addDigito("7");
        }

        private void button_num8_Click(object sender, EventArgs e)
        {
            addDigito("8");
        }


        private void button_num9_Click(object sender, EventArgs e)
        {
            addDigito("9");
        }


        private void button0_Click(object sender, EventArgs e)
        {
            if (!display.Text.Trim().Equals("0"))
            {
                display.Text += "0";
            }
            else
            {
                display.Text = "0";
            }
        }

        private void button_equals_Click(object sender, EventArgs e)
        {
            if(!display.Text.Trim().Equals(String.Empty))
            {
                numero2 = Convert.ToDouble(display.Text);
                calcular();
                pressionouIgual = true;
            }
        }

        private void button_minus_Click(object sender, EventArgs e)
        {
            addOperacao("-");
        }

        private void button_plus_Click(object sender, EventArgs e)
        {
            addOperacao("+");
        }


        private void button_mult_Click(object sender, EventArgs e)
        {
            addOperacao("*");
        }

        private void button_comma_Click(object sender, EventArgs e)
        {
            if(pressionouIgual)
            {
                limparCampos();
            }                                                                                                                                                                                                                                                                  

            if (display.Text.Contains(",")) return; 

            if(display.Text.Trim().Equals(String.Empty))
            {
                display.Text += "0,";
            } 
            else
            {
                display.Text += ",";
            }

        }

        private void button_pwr2_Click(object sender, EventArgs e)
        {
            numero1 = Convert.ToDouble(display.Text.Trim());
            resultado = numero1 * numero1;
            display.Text = resultado.ToString();    
            pressionouIgual = true;
        }

        private void button_pwrY_Click(object sender, EventArgs e)
        {
            addOperacao("^");
        }

        private void button_div_Click(object sender, EventArgs e)
        {
            addOperacao("/");
        }

        private void button_c_Click(object sender, EventArgs e)
        {
            limparCampos();
        }
    }
}