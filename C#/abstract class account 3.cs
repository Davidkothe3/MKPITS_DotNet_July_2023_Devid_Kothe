using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_class_account_3
{
   abstract class account
    {
        public int ac;
        public int bal = 1000;
        public abstract void deposit(int amt);

        public void showbalance()
        {
            Console.WriteLine("the bal amt for account no {0} is {1} ",ac,bal);
        }
    }

    class current:account
    {
        public override void deposit(int amt)
        {
            bal=bal+amt;
        }
    }

    class seving:account
    {
        public override void deposit(int amt)
        {
            int interest = 200;
            bal=bal+amt+interest;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the ac no");
            int ac=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter amount to be deposit");
            int amt=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the ac type seving or current");
            string actype=Console.ReadLine();

            account act = null;
            if (actype == "seving")
            {
                act = new seving();
            }
            else if (actype == "current");
            {
                act = new current();
            }

            act.ac=ac;
            act.deposit(amt);
            act.showbalance();
            Console.ReadLine();

            Console.ReadKey();

        }
    }
}
