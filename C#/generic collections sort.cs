using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generic_collections_sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("A");
            list.Add("s");
            list.Add("C");
            list.Add("b");
            list.Add("E");

            list.Sort();


            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
