using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1,num2,min;

            Console.WriteLine("enter the no=");
             num1=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the second num=");
            num2 = Convert.ToInt32(Console.ReadLine());


            min = num1 - num2;
            Console.WriteLine("result=" + min);
            Console.ReadKey();
        }
    }
}
