using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swapping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            Console.WriteLine("enter the num1=");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the num2=");
            b = Convert.ToInt32(Console.ReadLine());

            
            a = a - b;
            b = a + b;
            a = b - a;

            Console.WriteLine(a);
            Console.WriteLine(b);

            Console.ReadKey();
        }
    }
}
