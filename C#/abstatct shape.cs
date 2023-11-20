using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstatct_shape
{
    abstract class shape
    {
        public abstract void draw();
        
    }
    class reactangle:shape
    { 
      public override void draw()
        {
            Console.WriteLine("code with draw reactangle");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            shape s = new reactangle();
            s.draw();
            Console.ReadLine();
            Console.ReadKey();
        }
    }
}
