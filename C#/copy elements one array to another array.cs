using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace copy_elements_one_array_to_another_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num1= new int[3];
            int[] num2= new int[3];
           

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter Num:");
                num1[i]=Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("The Elements stored in the first array are:");
            for (int i = 0; i < 3; i++)
            {
                num2[i] = num1[i];
                Console.Write("{0}",num1[i]);

            }
            Console.WriteLine("\nThe Elements stored in the second array are: ");
            for (int i = 0; i < 3; i++)
            {
                Console.Write("{0}", num2[i]);
               
            }
            Console.ReadKey();
        }
    }
}
