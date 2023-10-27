using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace add_of_row_to_col
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr1 = { { 2, 3 }, { 4, 5 } };
            int[,] arr2 = { { 4, 3 }, { 7, 6 } };
            int[,] arr3 = new int[2, 2];

            for (int i = 0;i<2;i++)
            {
                for(int j = 0;j<2;j++)
                {
                    arr3[i,j]= arr1[i,j] + arr2[j,i];
                }
            }

            for(int i = 0; i<2;i++)
            {
                for (int j = 0; j<2;j++)
                {
                    Console.Write(arr3[i,j] + "\t");
                }
                Console.WriteLine();
            }

            Console.ReadKey();

        }
    }
}
