using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace display_Month_name
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("enter the num=");
            num=Convert.ToInt32(Console.ReadLine());

            switch (num)
            {
               
                    case 1:
                    Console.WriteLine("jan");
                    break;
                        case 2:
                    Console.WriteLine("FEB");
                    break;
                        case 3:
                    Console.WriteLine("MARCH");
                    break;
                        case 4:
                    Console.WriteLine("APR");
                    break;
                        case 5:
                    Console.WriteLine("MAY");
                    break;
                        case 6:
                    Console.WriteLine("JUNE");
                    break;
                        case 7:
                    Console.WriteLine("JUL");
                    break;
                        case 8:
                    Console.WriteLine("AUG");
                    break;
                        case 9:
                    Console.WriteLine("SEP");
                    break;
                        case 10:
                    Console.WriteLine("OCT");
                    break;

                case 11:
                    Console.WriteLine("NOV");
                    break;
                case 12:
                    Console.WriteLine("DEC");
                    break;

                default: Console.WriteLine("invalid");
                    break;
            }
            Console.ReadKey();

            }
    }
}
