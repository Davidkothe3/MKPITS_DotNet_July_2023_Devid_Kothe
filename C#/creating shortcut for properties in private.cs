using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace creating_shortcut_for_properties_in_private
{
    internal class Program
    {
        class BankAccount
        {
            public int ACNumber { get; set; }
            public string ACName { get; set; }

            public int Balance { get; set; }

            public void display()
            {
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("account details of customer  :");
                Console.WriteLine("------------------------------------");
                Console.WriteLine("account no : " + ACNumber);
                Console.WriteLine("account Holder name : " + ACName);
                Console.WriteLine("Balance : " + Balance);

            }

            public void transfer(BankAccount ba)
            {
                Balance = Balance + ba.Balance;
                ba.Balance = 0;
            }

            public void showbalance()
            {
                Console.WriteLine("curront bal for account no{0} is{1}", ACNumber, Balance);
            }



            static void Main(string[] args)
            {
                BankAccount ba = new BankAccount();
                ba.ACNumber = 1;
                ba.ACName = "sarang";
                ba.Balance = 1000;

                ba.display();

                BankAccount ba1 = new BankAccount();

                ba1.ACNumber = 2;
                ba1.ACName = "SUjit";
                ba1.Balance = 500;

                ba1.display();iu
                ba1.showbalance();

                ba.transfer(ba1);
                Console.WriteLine("---------------------------------");
                Console.WriteLine("bal; after transection  ");
                Console.WriteLine("----------------------------------");

                Console.ReadKey();
            }
        }
    }
}
