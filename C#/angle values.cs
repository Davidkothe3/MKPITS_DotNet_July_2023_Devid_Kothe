using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace given_angles_value
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.WriteLine("enter a=");
            a=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter b=");
            b=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter c=");
            c=Convert.ToInt32(Console.ReadLine());

            if((a == 90 && b != 90 && c != 90 )|| (a != 90 && b == 90 && c != 90) || (a != 90 && b != 90 && c == 90))
            {
                Console.WriteLine("right angle trangle");
            }

            else
            {
                Console.WriteLine("wrong trangle");
            }

            Console.ReadLine();
        }
    }
}
