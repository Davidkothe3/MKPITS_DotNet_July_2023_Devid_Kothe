using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace store_the_element_and_print_them
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int[] num= new int[3];

            for ( i = 0;i<num.Length; i++)  
            { 
            
                Console.WriteLine("enter the num");
                num[i]=Convert.ToInt32(Console.ReadLine());
            
            }
            for(i = 0; i<3;i++)
            {
                Console.Write(num[i] + ", ");
            }
            
            Console.ReadKey();
        }
    }
}
