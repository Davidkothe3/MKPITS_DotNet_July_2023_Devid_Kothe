using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace int_and_uint___4_bytes_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("enter thew value");
            i=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("value=" + i);


            uint s1;
            Console.WriteLine("enter the value=");
            s1=Convert.ToUInt32(Console.ReadLine());

            Console.WriteLine("value uint="+ s1);

       Console.ReadKey();
        }
    }
}
