using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace event_handling
{
    class bankevent
    {
       

            public int netBalance { get; set; }
        public void overbalance(int amount)
        {
            double tax = amount * 0.18;
            MessageBox.Show("Tax  amount is" + tax);
        }
        public void underbalance()
        {
            MessageBox.Show("your balance is low please maintain minimum balance up to 5000");
        }

    }
}
