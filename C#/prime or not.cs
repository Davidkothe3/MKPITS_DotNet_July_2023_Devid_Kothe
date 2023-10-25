using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace no.is_prime_or_not
{
    internal class Program
    {
        static int choice(int n)
        {
            int i = 1;
            for ( i = 1; i <= n; i++)
            {
                if (n % 2 == 1)
                {
                    Console.WriteLine("prime no");
                    break;
                }

                else
                {
                    Console.WriteLine("not prime no");
                    break;
                }
            }
            return i;
        }
            
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("enter the num");
            num=Convert.ToInt32(Console.ReadLine());

            int res = choice(num);
        Console.ReadKey();
        }
    }
}
