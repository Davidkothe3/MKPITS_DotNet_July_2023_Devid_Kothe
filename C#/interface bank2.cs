using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_bank2
{
    interface bank
    {
        string deposit(int acno, int amount);
    }

    class seving : bank 
    {
        int actno;
        int balence = 1000;
        public string deposit(int acno,int amount)
        {
            this.actno = acno;
            balence =balence + amount;

            return "deposit successfully , bal is" + balence;
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
