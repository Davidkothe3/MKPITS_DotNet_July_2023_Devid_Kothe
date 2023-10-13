using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace equal_or_not_if_else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;

            Console.WriteLine("enter the num1=");
            num1=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("entwer the num2=");
            num2=Convert.ToInt32(Console.ReadLine());

            if(num1==num2)
            {
                Console.WriteLine("the number is equal..");
            }
            else
            {
                Console.WriteLine("number is not equal");
            }

            Console.ReadKey();
        }
    }
}
