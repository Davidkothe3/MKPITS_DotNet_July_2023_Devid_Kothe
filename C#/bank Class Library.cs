using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_Class_Library
{
    public abstract class Account
    {

        public int actno;
        public int bal = 1000;
        public abstract string deposit(int amount);
        public string withdrawl(int amount)
        {
            string res = null;
            if (bal < amount)
            {
                res = "insuffient fund.cannot withdrawl money ";
            }
            else
            {
                bal = bal - amount;

                res = "amount withdrawl successfully , balence is " + bal.ToString();
            }
            return res;
        }
    

        public string showbalance()
        {
            return "balence amount is " + bal.ToString();

        }
    }

        public class saving:Account
        {
            public override string deposit(int amount)
            {
                int intrest = 300;
                bal = bal+amount+intrest;

                return "amount deposited successfully, bal is " + bal.ToString();
            }
        }
        public class current:Account
        {
            public override string deposit(int amount)
            {
                bal= bal+amount;
                return "amount deposit successfully,bal is "+ bal.ToString();
            }
        }
    }

