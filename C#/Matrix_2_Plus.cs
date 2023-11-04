using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix_2_Plus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] num1 = { { 2, 3 }, { 4, 5 } };
            int[,] num2 = { { 1, 6 }, { 7, 8 } };
            int[,] num3 = new int[2, 2];

            {
                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        num3[i, j] = num1[i, j] + num2[i, j];
                    }
                }

                for(int i = 0;i < 2; i++)
                {
                    for(int j = 0;j < 2; j++)
                    {
                        Console.Write( "\t"+ num3[i, j] + " ");
                    }
                    Console.WriteLine();

                }

            }
            Console.ReadKey();
        }
    }
}
