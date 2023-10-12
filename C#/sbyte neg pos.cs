using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sbyte_negative_positive_no
{
    internal class Program
    {
        static void Main(string[] args)
        {
            sbyte b=-13;
            Console.WriteLine("sbyte value" + b);
            Console.WriteLine("enter the sbyte");
            Convert.ToByte(Console.ReadLine());

            Console.WriteLine("sbyte=" + b);

            Console.ReadKey();
        }
    }
}
