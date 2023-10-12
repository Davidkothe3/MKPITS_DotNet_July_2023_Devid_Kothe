using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace long_and_ulong__8_bytes_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long s;
            Console.WriteLine("enter the value of s");
            s=Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("the of long=" +  s);

            ulong s1;
            Console.WriteLine("enter the ulong");
            s1=Convert.ToUInt64(Console.ReadLine());

            Console.WriteLine("ulong=" + s1);

            Console.ReadKey();
        }
    }
}
