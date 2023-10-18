using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace to_accept_a_number_and_print_square
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, square;
            char choice;

            do
            {
                Console.WriteLine("enter the num");
                num = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("do you want to continue perss y");
                choice=Convert.ToChar(Console.ReadLine());

                square = num * num;
                Console.WriteLine("num of square={0}", square);
            } while (choice == 'y' || choice == 'Y');
            Console.ReadKey();
        }
    }
}
