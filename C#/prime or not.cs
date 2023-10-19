using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace no.is_prime_or_not
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num,i;
             int fact = 0;

            Console.WriteLine("enter the num");
            num=Convert.ToInt32(Console.ReadLine());

            for(  i=2;i<num;i++)
            {
                if (num % 2 == 0)
                {
                    fact = 1;
                    break;
                }
            }

            if(fact == 0)
            {
                Console.WriteLine("number is prime");
            }
            else
            {
                Console.WriteLine("not prime");
            }

            Console.ReadKey();
        }
    }
}
