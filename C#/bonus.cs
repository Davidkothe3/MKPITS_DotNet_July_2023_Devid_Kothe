using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designtion_and_print_bonus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string designtion;

            int bonus = 0;

            Console.WriteLine("enter the designantion=");
            designtion= Console.ReadLine();

            switch(designtion)
            {
                case "manager":
                     bonus = 10000;
                break;

                case "clerk":
                    bonus = 7000;
                break;

                case "peon":
                    bonus = 3000;
                 break;

                    default: Console.WriteLine("invalid");
                        break;
            }
               Console.WriteLine("bonus={0}", bonus);
            Console.ReadKey();
        }
    }
}
