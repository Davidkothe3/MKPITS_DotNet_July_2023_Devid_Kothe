using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace to_calculate_profit_and_loss
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int profit, sell,cost;

            Console.WriteLine("sell =");
            sell=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("cost=");
            cost=Convert.ToInt32(Console.ReadLine());

            

            if (cost< sell)
            {
                profit=sell-cost;
                Console.WriteLine("profit={0}", profit);
            }
            else if
            {
                profit = cost - sell;
                Console.WriteLine("loss={0}", profit);

            }

            Console.ReadKey();


        }
    }
}
