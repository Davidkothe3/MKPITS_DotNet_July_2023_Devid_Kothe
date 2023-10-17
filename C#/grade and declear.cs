using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a_grade_and_declare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ch;
            Console.WriteLine("enter the char");
            ch=Convert.ToChar(Console.ReadLine());

            switch(ch)
            {
                case 'e':
                    Console.WriteLine("Excellent");
                break;

                case 'v':
                    Console.WriteLine("Vary good");
                break;

                    case 'g':

                      Console.WriteLine("Good");
                    break;

                    case 'a':
                      Console.WriteLine("Average");
                    break;

                case 'f':
                    Console.WriteLine("fail");

                    break;

                    default: Console.WriteLine("invalid");
                        break;



            }

            Console.ReadKey();
        }
    }
}
