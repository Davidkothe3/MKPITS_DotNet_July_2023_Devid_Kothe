using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace the_sum_of_the_first_10_num
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            int i = 0;
            int sum = 0;
            while (i <= n)
            {
                sum += i;
                i++;
            }

            Console.WriteLine("Sum is: " + sum);

            Console.ReadKey();
        }
    }
}
