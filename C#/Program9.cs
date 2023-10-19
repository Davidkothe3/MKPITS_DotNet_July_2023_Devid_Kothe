using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0;i<=5;i++)
            {
                for(int j = 1;j<=i;j++)
                {
                    Console.Write("*\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
