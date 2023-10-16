using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometric
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float radius , circle, Square, Reactangle;
            int l, b, n , choice;

            Console.WriteLine("1.Circle\n 2.Square \n------------------------- 3.rectangle ");

            choice = Convert.ToInt32(Console.ReadLine());

            if(choice==1)
            {
                Console.WriteLine("ENter radius");
                radius = Convert.ToInt32(Console.ReadLine());

                circle = 3.14f * radius * radius;

                Console.WriteLine("Circle is = " +circle);
            }
            else if (choice==2)
            {
                Console.WriteLine("Enter Square");
                n=Convert.ToInt32(Console.ReadLine());

                Square = n * n;

                Console.WriteLine("Square is = " + Square);
            }
            else if(choice==3)
            {
                Console.WriteLine("Enter Length");
                l=Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Breath");
                b = Convert.ToInt32(Console.ReadLine());

                Reactangle = l * b;
                Console.WriteLine("Rectangle is = "+ Reactangle);   
            } 
            else
            {
                Console.WriteLine("Input Error");
            }

            Console.ReadKey();
        }
    }
}
