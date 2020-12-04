using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace win_form_currency_assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float val = float.Parse(textBox1.Text);

            if (comboBox1.SelectedItem.Equals("INR") && comboBox2.SelectedItem.Equals("USD"))
            {
                float result = val / 70;
                textBox2.Text = result.ToString();

            }

            else if (comboBox1.SelectedItem.Equals("USD") && comboBox2.SelectedItem.Equals("INR"))
            {
                double result = val * 70;
                textBox2.Text = Convert.ToDouble(result).ToString();
            }

            else if (comboBox1.SelectedItem.Equals("INR") && comboBox2.SelectedItem.Equals("EURO"))
            {
                float result = val / 88;
                textBox2.Text = result.ToString();
            }

            else if (comboBox1.SelectedItem.Equals("EURO") && comboBox2.SelectedItem.Equals("INR"))
            {
                double result = val * 88;
                textBox2.Text = Convert.ToDouble(result).ToString();
            }

            else if (comboBox1.SelectedItem.Equals("INR") && comboBox2.SelectedItem.Equals("EURO"))
            {
                double result = val / 88;
                textBox2.Text = Convert.ToDouble(result).ToString();
            }

            else if (comboBox1.SelectedItem.Equals("USD") && comboBox2.SelectedItem.Equals("EURO"))
            {
                double result = val / 1.21;
                textBox2.Text = Convert.ToDouble(result).ToString();
            }
            else if (comboBox1.SelectedItem.Equals("EURO") && comboBox2.SelectedItem.Equals("USD"))
            {
                double result = val * 1.21;
                textBox2.Text = Convert.ToDouble(result).ToString();
            }

            else
            {
                Console.WriteLine("Please Select Valid Conversion ");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }

