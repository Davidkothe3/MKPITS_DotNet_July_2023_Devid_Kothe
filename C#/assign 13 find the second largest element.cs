using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign_13_find_the_second_largest_element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[5];
            

            

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Element [{0}]: ", i);
                num[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(num);
            Console.Write("second largest element is: ");
            int ln = num[num.Length-2];

            Console.WriteLine(ln);
            Console.ReadKey();
        }
    }
}
