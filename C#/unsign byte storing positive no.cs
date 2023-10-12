using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unsigned_byte_for_storing_positive_no
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte b=15;
            Console.WriteLine("enter the b" + b);
            Console.WriteLine("enter the byte");
            b= Convert.ToByte(Console.ReadLine());
            Console.WriteLine("byte=" + b);

            Console.ReadKey();
        }
    }
}
