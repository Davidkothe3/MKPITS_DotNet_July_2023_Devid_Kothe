using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace index_of_soft_method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 4, 6, 8, 9, 4, 7 };
            Array.Sort(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.ReadKey();
        }

    }
}
