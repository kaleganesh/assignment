using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scalculatorassignment
{
    public partial class Form1 : Form
    {
        int num1, num2;
        string op;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + (sender as Button).Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToInt32(textBox1.Text);
            textBox1.Text = "";
            op = (sender as Button).Text;



           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = Math.Sin(Convert.ToDouble(textBox1.Text) * (Math.PI / 180)).ToString();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = Math.Cos(Convert.ToDouble(textBox1.Text) * (Math.PI / 180)).ToString();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = Math.Tan(Convert.ToDouble(textBox1.Text) * (Math.PI / 180)).ToString();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(Math.Sqrt(Convert.ToDouble(textBox1.Text)));
        }

        private void button11_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToInt32(textBox1.Text);

            switch (op)
            {
                case "+":
                    textBox1.Text = (num1 + num2).ToString();
                    break;

                case "-":
                    textBox1.Text = (num1 - num2).ToString();
                    break;
                case "*":
                    textBox1.Text = (num1 * num2).ToString();
                    break;
                case "/":
                    textBox1.Text = (num1 / num2).ToString();
                    break;
            }
        }
    }
}
