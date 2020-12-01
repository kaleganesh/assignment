using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assingnment_2
{
    class Program
    {
        static void Main(string[] args)
        {

            child c = new child();
            Console.WriteLine(c.add(50, 50));


        }


    }

    abstract class parent
    {
        protected abstract int add(int p, int q);
    }

    class child : parent
    {
        protected override int add(int p, int q)
        {
            return p + q;
        }
    }



}
