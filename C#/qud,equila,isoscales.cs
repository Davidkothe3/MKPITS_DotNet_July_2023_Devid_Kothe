using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangle_is_Equilateral__Isosceles_or_Scalene
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.WriteLine("enter the A no=");
            a=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter B no=");
            b=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter C no=");
            c=Convert.ToInt32(Console.ReadLine());

            if(a==b &&  b==c && a==c)
            {
                Console.WriteLine("equilateral triangle"); 
            }

            else if(a==b || b==c || a==c)

            {
                Console.WriteLine("isosceles trinagle");

            }
            else
            {
                Console.WriteLine("scalene tringle");
            }

            Console.ReadLine();
        }
    }
}
