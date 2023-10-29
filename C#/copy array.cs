using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace copy_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[]num1= new int[5];
            int[]num2= new int[5];

            for (int i = 0; i < 5; i++) 
            {
                Console.WriteLine("enter the num");
                num1[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0;i < 5 ;i++)
            {
                num2[i] = num1[i];
            }
            Console.WriteLine();
            for(int i = 0;i<5 ;i++)
            {
                Console.WriteLine("The number1 is = " + num1[i]);
            }
            Console.WriteLine("\n Same As Number ");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("" + num2[i]);
            }
            Console.ReadKey();
        }
    }
}
