using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling_finally_through
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int num2;

            Console.WriteLine("emter the name");
            num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the num2");
            num2 = Convert.ToInt32(Console.ReadLine());

            int res = 0;
            try
            {
                res = num / num2;
            }
            catch(Exception ee)
            {
              Console.WriteLine("catch block is executed");
                Console.WriteLine("can not divided by zero");
            }
            finally
            {
                Console.WriteLine("finally bolck is executed");
                Console.WriteLine("res : " + res);
            }
            Console.WriteLine("bye");

            Console.ReadKey();
        }
    }
}
