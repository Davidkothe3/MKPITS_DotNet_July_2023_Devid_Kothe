using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace short_and_ushort_2_bytes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            short s = 2500;
            Console.WriteLine("short=" + s);
            Console.WriteLine("emter the short=");
            s=Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("short= " + s);

            ushort s1 = 2600;
            Console.WriteLine("ushort=" + s1);
            Console.WriteLine("entr num");
            s1 = Convert.ToUInt16(Console.ReadLine());

            Console.WriteLine("ushort= " + s1);

            
            
            Console.ReadKey();

        }
    }
}
