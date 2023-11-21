using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_bank1
{
    interface bank
    {
        string deposit(int actno, int bal);
        string withdrawl(int actno, int bal);
        string showbalence();

    }

    class account
    {
        public int actno;
        public int bal=1000;
        public int intrest = 300;
    }

    class seving : account, bank
    {
       public string deposit(int actno,int amount)
        {
            this.actno = actno;
            bal = bal + amount + intrest;
            return "actno : " + actno + "bal is :" + bal;
        }

        public string withdrawl(int actno, int amount) 
        {
            this.actno=actno;
            bal = bal - amount;
            return "actno : " + actno + "bal is :" + bal;

        }

        public string showbalence()
        {

            return "actno " + actno + "bal is " + bal;

        }
    }

    class current : account, bank
    {
        public string deposit(int actno, int amount)
        {
            this.actno= actno;
            bal = bal + amount;
            return "bal is :" + bal + "actno :" + actno;
        }
        public string withdrawl(int  actno, int amount)
        {
            this.actno = actno;
               bal=bal - amount;
            return "bal :" + bal + "actno :" + actno;
        }

        public string showbalence()
        {
            return "bal :" + bal + "actno :" + actno;
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            bank b = null;
            Console.WriteLine("enter the seving or current");
            string acttype= Console.ReadLine();
            string res = null;

            switch(acttype)
            {
                case "seving":
                    b= new seving();
                    break;

                case "current":
                    b= new current();
                    break;
            }

            Console.WriteLine("enter the deposit or withdrawl");
            string tt=Console.ReadLine();

            if (tt == "deposit")
                res = b.deposit(1, 2000);

            else if (tt == "withdrawl")
            res = b.withdrawl(1, 500);

            Console.WriteLine(res);
            Console.WriteLine(b.showbalence());
            Console.ReadKey();



                
        }
    }
}
