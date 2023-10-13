using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eligible_or_not
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;

            Console.WriteLine("enter the age=");
            age=Convert.ToInt32(Console.ReadLine());

            if(age >= 18)
            {
                Console.WriteLine("you are eligible for vote");

            }
            else
            {
                Console.WriteLine("sorry...tou are not eligible fot vote");
            }

            Console.ReadKey();
        }
    }
}
