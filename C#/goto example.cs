using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example_of_goto_statement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("enter the no");
            n=Convert.ToInt32(Console.ReadLine());

            if (n % 2 == 0) goto Even;
             Console.WriteLine("odd no");

            goto end;
        Even:
            Console.WriteLine("even no");

        end:
            Console.WriteLine("BYE");
             Console.ReadKey();
        }
    }
}
