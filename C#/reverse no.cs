using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace display_in_reverse_order
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char x;
            char y;
            char z;
            Console.WriteLine("enter the latter=");
            x=Convert.ToChar(Console.ReadLine());

            Console.WriteLine("enter the latter= " +  x);

            Console.WriteLine("enter the latter=");
            y=Convert.ToChar(Console.ReadLine());

            Console.WriteLine("enter 2nd latter=" +  y);

            Console.WriteLine("enterb 3rd latter=");
            z=Convert.ToChar(Console.ReadLine());

            Console.WriteLine("enterv 3rd no=" +  z);

            Console.WriteLine("char {2},{1},{0}", x, y, z);
            Console.ReadKey();
        }
    }
}
