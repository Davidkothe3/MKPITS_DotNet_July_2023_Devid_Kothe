using first;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace first
{
    public class hello
    {
        public void sayhello()
        {
            Console.WriteLine("hello namespace");

        }
    }
}
namespace second
{ 
   public class wellcome()
    {
        public void saywellcome()
        {
            Console.WriteLine("wellcome namsepace");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            hello h1 = new hello();
            wellcome w1 = new wellcome();
            h1.sayhello();
            w1.saywellcome();
        }
    }
}
