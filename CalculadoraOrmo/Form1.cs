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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Trim().Equals("0"))
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1 + "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Trim().Equals("0"))
            {
                textBox1.Text += "0";
            }
            else
            {
                textBox1.Text = "0";
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }
    }
}
