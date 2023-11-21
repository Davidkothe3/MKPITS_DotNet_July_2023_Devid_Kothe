using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_bank_4
{
    interface bank
    {
        string deposit(int actno, int amount);
         string withdrawl(int actno, int amount);
    }
    class account
    {
        public int actno;
        public int bal=1000;
        public string showbalence()
        {
            return "bal is :" + bal;
        }
    }
    class seving :account,bank
    {
        public string deposit(int actno, int amount) 
        {
            this.actno = actno;
            bal = bal + amount;

            return "deposited successfully successfully ,bal is " + bal;

        }
        public string withdrawl(int actno, int amount)
        {
           this.actno=actno;
            bal=bal - amount;
            return "deposited successfully successfully ,bal is " + bal;

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            seving b;
            b =new seving();
            string str=b.deposit(1, 200);
            Console.WriteLine(str);

            str=b.withdrawl(1, 100);
            Console.WriteLine(str);
            Console.WriteLine(b.showbalence());

            Console.ReadKey();
        }
    }
}
