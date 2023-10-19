using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace displays_the_sum_of_n_natural_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int sum = 0;

            Console.WriteLine("enter the num");
            num=Convert.ToInt32(Console.ReadLine());

            for(int i=1;i<=num;i++)
            {
                Console.WriteLine(i);
                sum = sum * num;
                

            }
            Console.WriteLine("Sum=" + sum);
            Console.ReadKey();
        }
    }
}
