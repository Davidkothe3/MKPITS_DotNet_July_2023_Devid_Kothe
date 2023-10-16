using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace display_name_of__day_as_word
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.WriteLine("enter the no=");
            n=Convert.ToInt32(Console.ReadLine());

            if(n == 1) 
            {
                Console.WriteLine("monday");
            }
            else if(n == 2) 
            {
                Console.WriteLine("tuesday");
            }
            else if( n == 3)
            {
                Console.WriteLine("wednesday");
            }
            else if(n == 4)
            {
                Console.WriteLine("thursday");
            }
            else if(n == 5)
            {
                Console.WriteLine("friday");
            }
            else if(n==6)
            {
                Console.WriteLine("saturday");
            }
            else if(n==7) 
            {
                Console.WriteLine("sunday");
            }
            else
            {
                Console.WriteLine("no MORE days....");

            }
           

            Console.ReadKey();
        }
    }
}
