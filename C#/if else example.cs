using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace if_else_example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m;

            Console.WriteLine("enter the value of m=");
            m=Convert.ToInt32(Console.ReadLine());

            if(m<= 0 ) 
            {
              Console.WriteLine("n=-1");
            }
            else if(m>0)
            {
                Console.WriteLine("n=1");
            }

            else
            {
                Console.WriteLine("n=0");
            }

            Console.ReadKey();
           


        }
    }
}
