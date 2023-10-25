using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example_of_continue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int i = 1;
              while (i <= 10)
            {
                Console.WriteLine(i);
                i++;
                if (i <= 10)

                    continue;

                else
                    break;

            }
              Console.ReadKey();
        }
    }
}
