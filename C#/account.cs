using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    abstract class Account
    {
        
            public int actno;
            public int bal = 1000;
        public abstract string deposit(int actno, int bal);
        public abstract string withdrawl(int actno, int bal);

            public string showbalence()
            {
                return "bal " + bal;
            }
    }
    class Saving:Account
    {
        public override string deposit(int a, int b)
        {

            int intrest = 500;
            bal = bal + b + intrest;
            actno = a;
            return "bal " + bal;
        }
        public override string withdrawl(int a, int b)
        {
            bal=bal- b;
            return "bal" + bal;
        }
    }
    class Current : Account
    {
        public override string deposit(int a, int b)
        {

            bal = bal + b;
            return "balence " + bal;
        }
        public override string withdrawl(int a, int b)
        {
            bal = bal - b;
            return "bal " + bal;

        }
    }
}
