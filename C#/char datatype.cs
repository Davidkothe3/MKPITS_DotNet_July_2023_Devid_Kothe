using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace char_datatype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char b;
            Console.WriteLine("enter the char=");
            b=Convert.ToChar(Console.ReadLine());

            Console.WriteLine("charector="+ b);

            Console.ReadKey();
        }
    }
}
