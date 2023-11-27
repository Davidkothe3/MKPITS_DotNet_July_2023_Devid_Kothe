using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generic_collections_remove
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("A");
            list.Add("B");
            list.Add("C");
            list.Add("D");
            list.Add("E");
            list.Add("F"); 

            list.Remove("F");
            list.Remove("B");

            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
