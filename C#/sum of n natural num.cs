using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace the_sum_of_n_natural_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            int i = 1;
            int sum = 0;

            Console.WriteLine("enter the num");
            n=Convert.ToInt32(Console.ReadLine());
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
