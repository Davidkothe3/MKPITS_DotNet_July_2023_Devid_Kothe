using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aoc_circ_of_circ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int radius;
            float circ, area;

            Console.WriteLine("enter the redus=");
            radius = Convert.ToInt32(Console.ReadLine());

            area = 3.14f * radius * radius;

            circ = 2 * 3.14f * radius;

            Console.WriteLine("area=" + area);

            Console.WriteLine("circ" + circ);

            Console.ReadLine();
        }
    }
}
