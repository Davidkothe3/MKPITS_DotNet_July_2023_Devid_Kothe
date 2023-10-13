


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace greater_no_if_else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;

            Console.WriteLine("enter the value n1");
            n1=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the value n2");
            n2=Convert.ToInt32(Console.ReadLine());

            if (n1 > n2) 
            {
                  Console.WriteLine("num1 is grater");
            }
            else
            {
              Console.WriteLine("n2 is grater");
            }



            Console.ReadKey();
        }
    }
}
