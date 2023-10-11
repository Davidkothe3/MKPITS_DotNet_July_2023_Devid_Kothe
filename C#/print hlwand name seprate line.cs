using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace print_hello_and_name_seprate_line
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;

            Console.WriteLine("enter the name");
            name = Console.ReadLine();

            Console.WriteLine("hello:" + name);

            Console.ReadLine();
        }
    }
}
