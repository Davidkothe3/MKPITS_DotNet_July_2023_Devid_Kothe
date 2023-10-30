using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign_13_to_find_the_second_smallest_element__array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 4, 9, 8, 2, 3 };
            Array.Sort(num);
            int n=num[num.Length-2];
            Console.WriteLine(n);
            Console.ReadKey();
        }
    }
}
