using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace float_double_decomal_char_bool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float s;
            Console.WriteLine("ente the float value=");
            s=Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("float="+ s);

            double s1;
            Console.WriteLine("enter the double value=");
            s1=Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("double=" +  s1);

            decimal s2;
            Console.WriteLine("enter the decimal=");
            s2 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("swcimal="+ s2);

            char s3;
            Console.WriteLine("enter the char=");
            s3 = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("char="+ s3);

            Boolean s4;
            Console.WriteLine("enter the bool=");
            s4 = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("boolean="+ s4);

            Console.ReadKey();
        }
    }
}
