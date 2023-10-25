using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace one_int_parameter_print_table
{
    internal class Program
    {
        static int parameter(int num)
        {
           int res=1;
            for(int i = 1;i<=10;i++)
            {
                res = i * num;
                Console.WriteLine("{0}*{1}={2}", num ,i, res);
            }
            return res; 
        }
        static void Main(string[] args)
        {
            int q ;
            Console.WriteLine("enter the vaslue of q");
            q=Convert.ToInt32(Console.ReadLine());

            int result = parameter(q);

            Console.ReadKey();




        }
    }
}
