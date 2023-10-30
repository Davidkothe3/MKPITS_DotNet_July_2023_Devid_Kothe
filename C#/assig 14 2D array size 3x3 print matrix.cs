using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assig_14_2D_array_size_3x3_print_matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] num=new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0;j<3;j++)
                {
                    Console.Write("enter number");
                    num[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0;i < 3;i++) 
            { 
              for(int j = 0; j<3;j++)
                {
                    Console.Write(num[i, j] + "\t");
                }
              Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
