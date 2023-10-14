using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace the_temperature_state
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int temp;

            Console.WriteLine("enter the temp=");
            temp=Convert.ToInt32(Console.ReadLine());
            
            if(temp <= 0 )
            {
                Console.WriteLine("Freezing weather");
            }
           
            else if (temp <=10   && temp >= 20 )
            {
                Console.WriteLine("it is cold");
            }
            else if (temp <= 21 && temp >= 30)
            {
                Console.WriteLine("it is hot");
            }
            else
            {
                Console.WriteLine("It is Very Hot");
            }
            Console.ReadKey();
        }
    }
}
