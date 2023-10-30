using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_as_parameter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[]num= { 1, 5, 2, 6, 3, 7 };
            Array.Sort(num);
            int n =num [num.Length-2];
            Console.WriteLine(n);

            Console.ReadKey();

        }
    }
}
