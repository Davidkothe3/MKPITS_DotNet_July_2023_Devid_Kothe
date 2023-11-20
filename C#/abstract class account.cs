using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_class_account
{
    abstract class account
    {
        public abstract void deposit();
    }
    class saving : account
    {
        public override void deposit()
        {
            Console.WriteLine("hellow from seving deposite account");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            account act = new saving();
            act.deposit();
            Console.ReadKey();
        }
    }
}
