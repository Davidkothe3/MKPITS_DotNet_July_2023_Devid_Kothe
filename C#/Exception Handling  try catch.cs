using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling__try_catch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;

            Console.WriteLine("enter the num1");
            num1=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the num2");
            num2 = Convert.ToInt32(Console.ReadLine());

            int res = 0;
            try
            {
                res = num1 / num2; //error will come here and program terminated
            }
            catch
            {
                Console.WriteLine("can not divided by zero");
            }
            Console.WriteLine("res :" + res);
            Console.WriteLine("bye");

            Console.ReadKey();
        }
    }
}
