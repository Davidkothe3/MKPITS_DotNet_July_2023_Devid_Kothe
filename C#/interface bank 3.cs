using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_bank_3
{
    interface bank
    {
        string deposit(int actno, int amt);

    }
    class account 
    {
        public int actno;
        public int balence=1000;

    }

    class seving:account,bank
    {
        public string deposit(int actno,int amt)
        {
            this.actno = actno;
            balence = balence+amt;

            return "deposit successfully ,bal is :" + balence;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            bank b;
            b= new seving();
            string str=b.deposit(1, 200);
            Console.WriteLine(str);

            Console.ReadKey();
        }
    }
}
