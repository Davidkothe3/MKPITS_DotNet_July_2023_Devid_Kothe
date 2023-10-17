using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odd_num_between_20_and_30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter = 20;
            while (counter <= 30)
            {
                if (counter % 2 == 0)
                {
                    Console.WriteLine("{0} is even ", counter);
                }
                counter = counter + 1;
            }


            Console.ReadKey();

        }
    }
}
