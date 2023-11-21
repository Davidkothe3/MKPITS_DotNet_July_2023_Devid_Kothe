using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_bank3
{
    interface bank
    {
        string deposit(int acno, int amount);

    }

    class seving : bank 
    {
        int actno;
        int bal=1000;
        int intrest = 200;

        public string deposit(int acno, int amount)
        {
            this.actno = acno;
            bal =bal + amount + intrest;
            return "actno :" + acno + "balence is : " + bal;
           
        }
    }

    class current :bank
    {
        int actno;
        int bal=1000;

        public string deposit(int actno, int amount)
        {
          this.actno=actno;
            bal=bal + amount;

            return "actno :" + actno + "balence :" + bal;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            bank b = null;
            Console.WriteLine("enter seving or current");
            string acttype=Console.ReadLine();
            switch(acttype)
            {
                case "seving":
                    b=new seving();
                    break;

                case "current":
                    b=new current();
                    break;
            }

            string res=b.deposit(1, 600);
            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}
