using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leap_yearor_not
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int year;

            Console.WriteLine("enter the year=");
            year=Convert.ToInt32(Console.ReadLine());

            if(year % 4== 0)
            {
                Console.WriteLine("leap year....");
            }
            else
            {
                Console.WriteLine("it is not leap year...");
            }

            Console.ReadKey();
        }
    }
}
