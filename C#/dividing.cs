using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dividing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, div;

            Console.WriteLine("enter the num1");
           num1=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the num2");
            num2=Convert.ToInt32(Console.ReadLine());

            div = num1 / num2;

            Console.WriteLine("div=" + div);

            Console.ReadKey();
        }
    }
}
