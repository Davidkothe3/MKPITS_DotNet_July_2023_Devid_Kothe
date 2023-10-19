using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace and_print_table_of_that_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i,num;


            Console.WriteLine("enter the nmber");
            num=Convert.ToInt32(Console.ReadLine());

            for(i=1;i<=10;i++)
            {
               
                Console.WriteLine("{0}*{1}={2}", num, i, (num * i));
            }
            Console.ReadKey();
        }
    }
}
