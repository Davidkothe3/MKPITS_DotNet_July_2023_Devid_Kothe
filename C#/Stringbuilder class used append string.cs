using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stringbuilder_class_used_append_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("lorance");
            sb.Append(" boshonai");
            Console.WriteLine(sb.ToString());
            Console.WriteLine("bye");

            Console.ReadKey();
        }
    }
}
