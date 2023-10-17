using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace print_even_num1_and_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 1;

            while(num <= 10)
            {
                if(num %2==0)
                {
                    Console.WriteLine("{0}  is even", num);
                }
                num++;
            }



            Console.ReadKey();
        }
    }
}
