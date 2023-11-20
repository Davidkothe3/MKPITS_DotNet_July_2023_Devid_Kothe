using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_class_account_2
{
    abstract class account
    {
        public abstract void deposit();

        public void showbalance()
        {
            Console.WriteLine("balence method");
        }
    }

    class seving:account
    {
        public override void deposit()
        {
            Console.WriteLine("hellow from seving deposit account");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            account act = new seving();
            act.deposit();
            act.showbalance();
        }
    }
}
