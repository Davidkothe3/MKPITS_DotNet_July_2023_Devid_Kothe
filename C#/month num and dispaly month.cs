using System;
using System.Timers;

namespace Month_Number_and_display_Month
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("enter the num=");
            num=Convert.ToInt32(Console.ReadLine());

            if(num == 1 )
            {
                Console.WriteLine("JAN");
            }
            else if ( num == 2 ) 
            {
                Console.WriteLine("FEB");
            }

            else if( num == 3 )
            {
                Console.WriteLine("MARCH");
            }
            else if(num == 4 )
            {
                Console.WriteLine("APRAIL");
            }
            else if(num==5)
            {
             Console.WriteLine("MAY");
            }
            else if(num == 6)
                {
                Console.WriteLine("JUNE");
            }

            else if(num == 7)
            {
                Console.WriteLine("JUL");
            }

            else if(num==8)
            {
                Console.WriteLine("AUG");
            }

            else if(num==9)
            {
                Console.WriteLine("SEP");
            }
            else if(num==10)
            {
                Console.WriteLine("OCT");
            }
            else if(num==11)
            {
                Console.WriteLine("NOV");
            }

            else if( num==12)
            {
                Console.WriteLine("DEC");
            }
            

            Console.ReadKey();
        }
    }
}
