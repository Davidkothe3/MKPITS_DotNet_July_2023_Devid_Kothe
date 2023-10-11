using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace add_min_mult_div
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2,add,min,mult,;
            float div;

            Console.WriteLine("enter the num1=");
            num1=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the num2=");
            num2=Convert.ToInt32(Console.ReadLine());

            add=num1 + num2;
            Console.WriteLine("ans=" + add);
            min =num1 - num2;
            Console.WriteLine("ans=" + min);
            mult = num1 * num2;
            Console.WriteLine("ans=" + mult);

            div = num1 / num2;
            Console.WriteLine("ans=" +  div);

            Console.ReadKey();
        }
    }
}
