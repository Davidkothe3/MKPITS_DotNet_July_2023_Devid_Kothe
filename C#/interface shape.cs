using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_shape
{
    interface shape
    {
        void drow();
    }
    class reactangle:shape
    {
        public void drow()
        {
            Console.WriteLine("draw the method of reactangle");
        }
    }

    class circle :shape
    {
        public void drow()
        {
            Console.WriteLine("draw the method of circle");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            shape s= new reactangle();
            s.drow();

            s= new circle();
            s.drow();

            Console.ReadKey();
        }
    }
}
