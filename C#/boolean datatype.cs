using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boolean_datatype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Boolean b;
            Console.WriteLine("enter the char=");
                b=Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("boolean="+ b);

            Console.ReadKey();
        }
    }
}
