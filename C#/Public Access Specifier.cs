using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Public_Access_Specifier
{
    class publictest
    {
        public string name = "bhupendra jogi";
        public void Msg(string msg)
        {
        Console.WriteLine( "hellow "+msg);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            publictest pt = new publictest();
            Console.WriteLine("hellow " + pt.name);
            pt.Msg("chetan don");

            Console.ReadKey();
        }
    }
}
