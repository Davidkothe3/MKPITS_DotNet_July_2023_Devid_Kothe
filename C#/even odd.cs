using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace even_odd_if_else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("enter the no=");
            num=Convert.ToInt32(Console.ReadLine());

            if(num %2==0 )
            {
                Console.WriteLine("number is even...");

            }
            else
            {
                Console.WriteLine("number is odd");
         
            }
            Console.ReadKey();
        }
    }
}
