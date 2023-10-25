using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace accepting_value_from_user_factorial
{
    internal class Program
    {
        static void factorial(int num)
        {
            int fact = 1;
            while (num > 0)
            {
                fact= fact * num;
                num--;
            }
            Console.WriteLine("fact= " + fact);
        }
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("enter the no");
            num = Convert.ToInt32(Console.ReadLine());

            factorial(num);

            Console.ReadKey();

        }
    }
}
