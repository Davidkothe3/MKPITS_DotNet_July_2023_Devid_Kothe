using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_clear_method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr= { 4, 6, 7, 8, 3, 4, 3, 56 };
            Array.Clear(arr, 0, 8);
            for (int i = 0;i<arr.Length;i++) 
            {
                Console.WriteLine(arr[i]);
            }
            Console.ReadKey();
        }
    }
}
