using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_calculations_program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2,add,sub,mult;
            int choice;
            float div;

            Console.WriteLine("Enter your Choice");
            Console.WriteLine("1.Addition \n 2.substration  \n  3.multipication  \n 4.divide ");
            choice=Convert.ToInt32(Console.ReadLine());

            switch(choice)
            {
                case 1:
                    Console.WriteLine(" Enter num1 ");
                    num1 =Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("enter num2");
                    num2 =Convert.ToInt32(Console.ReadLine());

                     add =num1 + num2;

                    Console.WriteLine("add= " + add);

                break;

                case 2:

                    Console.WriteLine("enter the num1");
                    num1=Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("enter num2");
                    num2=Convert.ToInt32(Console.ReadLine());

                    sub=num1 - num2;

                    Console.WriteLine("sub=" + sub);

                break;
                     
               case 3:

                    Console.WriteLine("enter num1");
                    num1=Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("enter the num2");
                    num2=Convert.ToInt32(Console.ReadLine()); 
                    
                    mult=num1 * num2;

                    Console.WriteLine("multiplication="+ mult);
               break;

                case 4:

                    Console.WriteLine("enter num1");
                    num1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("enter the num2");
                    num2 = Convert.ToInt32(Console.ReadLine());

                    div = num1 / num2;

                    Console.WriteLine("divide=" + div);

                break;


                    default: Console.WriteLine("exit");

                    break; 

            }
            Console.ReadKey();
        }
    }
}
