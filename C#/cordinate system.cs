using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XY_coordinate_system
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1,num2;

            Console.WriteLine("enter vlue x=");
            num1=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter value y=");
            num2=Convert.ToInt32(Console.ReadLine());

            if(num1 > 0 && num2 > 0)
            {
                Console.WriteLine("The coordinate point ({num1},{num2}) lies in the First quadrant.");
            }

            else if (num1 > 0 && num2 < 0)
            {
                Console.WriteLine("The coordinate point ({num1},{num2}) lies in the second quadrant.");
            }
            else if (num1 < 0 && num2 > 0)
            {
                Console.WriteLine("The coordinate point ({num1},{num2}) lies in the third quadrant.");
            }
            else if (num1 < 0 && num2 < 0)
            {
                Console.WriteLine("The coordinate point ({num1},{num2}) lies in the forth quadrant.");
            }

            Console.ReadLine();
        }
    }
}
