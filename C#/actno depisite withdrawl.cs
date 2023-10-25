using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parameter_actno_amount__deposit
{
    internal class Program
    {
        static int choice(int amt, int ac,char op)
        {
            int bal = 1000;
            int result =  0;

            if (op == 'W' || op =='w')
            {
                result = amt - bal;
                Console.WriteLine("bal =" + result);
            }
            else if(op =='D'|| op =='d')
            {
                result = amt + bal;
                Console.WriteLine("bal=" + result);
            }
            return result;

        }
        static void Main(string[] args)
        {
            int actno;
            char opr;
            int amt;

            Console.WriteLine("enter the act on");
            actno=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the opr");
            opr=Convert.ToChar(Console.ReadLine());

            Console.WriteLine("enter amt");
            amt=Convert.ToInt32(Console.ReadLine());

            int res=choice(amt, actno, opr);

            Console.ReadKey();

        }
    }
}
