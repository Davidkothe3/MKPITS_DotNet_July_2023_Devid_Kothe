using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protected_Internal_Access_Specifier
{
    class proctedtest
    {
        protected internal string name = "sunny";
        protected void Msg(string msg)
        {
            Console.WriteLine("hello "+msg);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            proctedtest pt = new proctedtest();
            pt.name = "ravi";
            Console.WriteLine(pt.name);

            Console.ReadKey();
        }
    }
}
