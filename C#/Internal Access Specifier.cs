using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internal_Access_Specifier
{
    class internaltest
    {
        internal string name="sham shngh";
        internal void Mag(string msg)
        {
            Console.WriteLine("hello"+msg);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            internaltest test = new internaltest();
            Console.WriteLine("hello  "+ test.name);

            test.Mag("bandu");

            Console.ReadKey();
        }
    }
}
