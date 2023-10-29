using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stores_elements_in_an_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 1, 2, 3, 4, 5 };
            int flag = 0;
            int username;

            Console.WriteLine("enter num to be search");
            username = Convert.ToInt32(Console.ReadLine());

            for(int i=0;i<num.Length;i++)
            {
                if (num[i]==username)
                {
                   flag = 1;
                    break;
                }
            }
            if (flag == 1)
            {
                Console.WriteLine("num {0} is found", username);
            }
            else
            {
                Console.WriteLine("num is not found");
            }
            Console.ReadKey();
        }
    }
}
