using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime_no1_and_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 3, count = 2, flag = 0;

            while(num<=20)
            {
                flag = 0;
                count = 2;

                while(count< num)
                {
                    if(num% count == 0)
                    {
                        flag = 1;
                        break;
                    }
                    count++;
                }
                if(flag == 0)
                {
                    Console.WriteLine("prime no {0}", num);
                }
                num++;
            }
            Console.ReadKey();
        }
    }
}
