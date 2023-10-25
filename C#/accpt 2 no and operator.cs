using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace accept_2_number_and_operator
{
    internal class Program
    {
        public static int calculate(int num1, int num2,char oper)
        {
            int res = 0;
            if (oper == '+')

                res = num1 + num2;
            else if (oper == '-')
                res = num1 - num2;

            else if (oper == '*')
                res = num1 * num2;

            else
                Console.WriteLine("invalid operator");

            return res;
        }
        static void Main(string[] args)
        {

            int  n1, n2;
            char op;

            Console.WriteLine("enter the number1=");
            n1=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the number2=");
            n2=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter op + - *");
            op=Convert.ToChar(Console.ReadLine());

            int result = calculate( n1, n2, op);
            Console.WriteLine("result " +  result);

            Console.ReadKey();

        }
    }
}
