using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multof_3num
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1,num2,num3,mult;

            Console.WriteLine("enter the num1");
            num1=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the num2");
            num2=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the num3");
            num3=Convert.ToInt32(Console.ReadLine());

            mult=num1*num2*num3;

            Console.WriteLine("mult=" + mult);

            Console.ReadKey();

        }
    }
}
