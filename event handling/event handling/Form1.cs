using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace event_handling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bankevent b1 = new bankevent();

            b1.netBalance = Convert.ToInt32(textBox1.Text);

            if(b1.netBalance>=100000)
                {

                b1.overbalance(b1.netBalance);

            }
            else if(b1.netBalance<=5000)
            {
                b1.underbalance();
            }
            else
            {
                MessageBox.Show("you dont need to pay a Tax");
            }
        }
    }
}
