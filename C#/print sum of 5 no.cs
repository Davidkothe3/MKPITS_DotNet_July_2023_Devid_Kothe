using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace print_the_sum_of_5_no
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int sum = 0;

            Console.WriteLine("enter the no=");
            num=Convert.ToInt32(Console.ReadLine());

            for(int i=1;i <= num;i++)
            {
                Console.WriteLine(i);
                sum = num + i;


            }
            Console.WriteLine("sum={0}", sum);
            Console.ReadKey();
        }
    }
}
