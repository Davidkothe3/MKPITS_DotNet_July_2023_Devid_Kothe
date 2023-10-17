using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_number_and_print_day
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int day;
            Console.WriteLine("enter hte day");
            day=Convert.ToInt32(Console.ReadLine());

            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                break;

                    case 2:
                      Console.WriteLine("Tuesday");
                    break;

                    case 3:
                     Console.WriteLine("wednsday");
                    break;

                    case 4:
                      Console.WriteLine("thursday");
                    break;
                    
                    case 5:
                       Console.WriteLine("friday");
                    break;

                    case 6:
                       Console.WriteLine("saturday");
                    break;

                    case 7:
                      Console.WriteLine("sunday");
                    break;

                    default: Console.WriteLine("some othe days");

                    break;
            
            } 
            Console.ReadKey();
        }
              
    }
}
