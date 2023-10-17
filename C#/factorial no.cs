using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace print_factorial_no
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int fact = 1;
            Console.WriteLine("enter the num=");
            num=Convert.ToInt32(Console.ReadLine());

            while(num > 0)
            {
                fact=fact*num;
                num--;
            }
            Console.WriteLine("facttorial=" + fact);


            Console.ReadKey();
        }
    }
}
