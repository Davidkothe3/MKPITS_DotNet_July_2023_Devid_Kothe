using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reactrangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int l, b, reactrangle;

            Console.WriteLine("enter tn length");
            l=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the breadth=");
             b=Convert.ToInt32(Console.ReadLine());

            reactrangle = l * b;

            Console.WriteLine("reactrangle=" + reactrangle);

            Console.ReadKey();

        }
    }
}
