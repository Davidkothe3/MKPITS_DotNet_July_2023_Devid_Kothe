using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace abstract_class_account_5
{
    abstract class account
    {
        public int actno;
        public int balence = 1000;

        public abstract string deposit(int actno, int balence);

        public string showbalance()
        {
            return "balence amount :" + balence;
        }
    }

    class current : account
    {
        public override string deposit(int actno, int amount)
        {
            this.actno = actno;
            balence = balence + amount;

            return "amount deposited successfully without interst in current class";
        }
       
    }
    class seving:account
    {
        public override string deposit(int actno, int amount)
     
        {

            this.actno = actno;
            int interest = 500;
            balence = balence + amount + interest;
            return "amount deposited successfully with interest in saving class";

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("enter account no ");
            int actno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter amount to be deposited ");
            int amount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter account type (saving or currrent)");
            String acttype = Console.ReadLine();


            account act = null;
            if (acttype == "saving")
            {
                act = new seving();
            }
            else if (acttype == "current")
            {
                act = new current();
            }
            String res = act.deposit(actno, amount);
            Console.WriteLine("account no is " + act.actno);
            Console.WriteLine(res);
            res = act.showbalance();
            Console.WriteLine(res);


        }
    }
}
