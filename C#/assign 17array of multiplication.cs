using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign_17array_of_multiplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] num1 = { { 4, 5 }, { 7, 9 } };
            int[,] num2 = { { 2, 5 }, { 4, 7 } };
            int[,] num3 = new int[2,2];

            for (int i = 0; i <2; i++)
            {
                for (int j = 0; j <2; j++)
                {
                    num3[i,j] = num1[i, j] * num2[i,j];
                }
            }

            for (int i = 0;i <2; i++)
            {
                for(int j = 0;j <2; j++)
                {
                    Console.Write(num3[i,j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();

        } 
    }
}
