using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cube
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, cube;
            Console.WriteLine("enter the no=");
            num = Convert.ToInt32(Console.ReadLine());
            cube = num * num * num;
            Console.WriteLine("cube" + cube);
            Console.ReadKey();
        }
    }
}
