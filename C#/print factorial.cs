using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number_and_print_factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int fact = 1;
            Console.WriteLine("enter the num");
           num= Convert.ToInt32(Console.ReadLine());

            for(int i=1;i<=num;  i++)
            {
                fact= fact*i;
            }
            Console.WriteLine("fact=" +  fact);

            Console.ReadKey();
        }
    }
}
