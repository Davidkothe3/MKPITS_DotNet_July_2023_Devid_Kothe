using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace square_num
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, square;
            Console.WriteLine("enter the no=");
            num = Convert.ToInt32(Console.ReadLine());
            square = num * num;
            Console.WriteLine("square = " + square);

            Console.ReadKey();
        }
    }
}
