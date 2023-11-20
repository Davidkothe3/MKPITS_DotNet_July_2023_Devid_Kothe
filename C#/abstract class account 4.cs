using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_class_account_4
{
    abstract class account
    {
        public int bal = 1000;
        public abstract void deposit(int amount);
        public abstract void withdrawl(int amount);
        public void showbalance()
        {
            Console.WriteLine("the bal is ",bal);
        }
    }

    class seving:account
    {
        public override void withdrawl(int amount)
        {
            bal=bal-amount;
        }
        public override void deposit(int amount)
        {
            int intrest = 300;
            bal = bal+amount+intrest;
            Console.WriteLine("amount deposit with intrest the bal is" + bal);
        }
    }

    class current:account
    {
        public override void withdrawl(int amt)
        {
            bal = bal-amt;
        }
        public override void deposit(int amt)
        {
            bal = bal + amt;
            Console.WriteLine("amount deposit without intrest bal is " + bal);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            account act = null;
            Console.WriteLine("enter amount");
            int amount=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the S or C account");
            string actype=Console.ReadLine();

            Console.WriteLine("enter the D or W");
            string tt=Console.ReadLine();

            if(actype=="seving")
            {
                act=new seving();
            }
            else if(actype=="current")
            {
                act=new current();
            }

            if(tt=="deposit")
            {
                act.deposit(amount);
            }
            else if(tt=="withdrewl")
            {
                act.withdrawl(amount);
            }

            act.showbalance();

            Console.ReadKey();

        }
    }
}
