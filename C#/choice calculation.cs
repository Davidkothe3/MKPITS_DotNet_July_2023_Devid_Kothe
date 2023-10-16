using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Choice_Calculation_new
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            int choice;
            int result;

            Console.WriteLine("Enter Number 1");
            num1=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Number 2");
            num2=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter 1 for Addition\n Enter 2 for Substraction\n Enter 3 for Multioplication\n Enter 4 for Division");
            choice = Convert.ToInt32(Console.ReadLine());  

            if(choice == 1)
            {
                result = num1 + num2;
                Console.WriteLine("Addition = {0}", result);
            }
            else if(choice == 2)
            {
                result = num2 - num1;
                Console.WriteLine("Substraction = {0}", result);
            }
            else if( choice == 3)
            {
                result=num1 * num2;
                Console.WriteLine("Multiplication = {0}", result);
            }
            else if(choice == 4)
            {
                result = num1 / num2;
                Console.WriteLine("Division = {0}", result);
            }
            else
            {
                Console.WriteLine("Invalid Choice");
            }
            Console.ReadKey();
        }
    }
}
