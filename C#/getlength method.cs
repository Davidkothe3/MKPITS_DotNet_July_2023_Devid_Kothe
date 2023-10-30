using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getlength_method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int l = num.GetLength(0);

            Console.WriteLine("length= " + l);

            Console.ReadKey();
        }
    }
}
