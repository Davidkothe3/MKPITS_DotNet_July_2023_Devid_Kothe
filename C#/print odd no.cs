using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace accept_a_number_and_print_odd_no
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int count = 1;

            Console.WriteLine("enter the num=");
            num=Convert.ToInt32(Console.ReadLine());

            int sum = 1;

            while(true)
            {
                if(sum<=num)
                {
                    if(count%2 !=0)
                    {
                        Console.WriteLine("odd no={0}", count);
                        sum = sum + 1;

                    }

                }
                else
                {
                    break;
                }
                count++;
            }
            Console.ReadKey();
        }
    }
}
