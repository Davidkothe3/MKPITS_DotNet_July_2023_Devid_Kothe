using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace double_datatype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double d;
            Console.WriteLine("enter the value");
            d=Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("value="+ d);

            Console.ReadKey();
        }
    }
}
