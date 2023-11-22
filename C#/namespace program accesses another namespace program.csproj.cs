using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace first
{
    class hello
    {
        public void display()
        {
            Console.WriteLine("hello from first");
        }
    }
}

namespace second
{
    class hello
    {
        public void display()
        {
            Console.WriteLine("hellow from second");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            first.hello f=new first.hello();
            f.display();

            second.hello f1=new second.hello();
            f1.display();

            Console.ReadKey();
        }
    }
}
