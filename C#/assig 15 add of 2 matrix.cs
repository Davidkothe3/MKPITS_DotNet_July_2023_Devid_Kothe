using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assig_15_add_of_2_matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] num1 = { { 1, 2 }, { 3, 4 } };
            int[,] num2 = { { 5, 6 }, { 7, 8 } };
            int[,] num3 = new int[2,2];

            for (int r = 0;r<2;r++)
            {
                for (int c = 0;c<2;c++)
                {
                    num3[r,c] = num1[r,c] + num2[r,c];
                }
            }

            for (int r = 0;r < 2;r++)
            {
                for(int c = 0; c<2 ; c++)
                {
                    Console.Write(num3[r,c] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
