using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheriting_Methods_class_car
{
    class car
    {
        public void start()
        {
            Console.WriteLine("car is starting");
        }
    }
    class tata:car
    {
        public void startmusic()
        {
            Console.WriteLine("music is starting");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            tata t = new tata();
            t.start();
            t.startmusic();

            Console.ReadKey();

        }
    }
}
