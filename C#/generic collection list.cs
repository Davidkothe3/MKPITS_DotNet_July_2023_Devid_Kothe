using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generic_collection_list
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("java");
            list.Add("php");
            list.Add("c#");
            list.Add("c");
            list.Add("dotnet");

            Console.WriteLine(list.Contains("c#"));

            Console.WriteLine(list[1]);
            Console.WriteLine(list[2]);

          list.Remove("c#");
            list.Remove("c");

            Console.WriteLine(list.Contains("c#"));

            list.Insert(3, "html");

            list.Sort();

            foreach (string item in list)

            {
                Console.WriteLine(item);
            }

            Console.ReadKey();

        }
    }
}
