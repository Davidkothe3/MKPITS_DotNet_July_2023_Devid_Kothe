using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_list_example3
{
  
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add(11);
            list.Add(12);
            list.Add(13);
            list.Add(14);
                list.Add(15);

            foreach (int obj in list)
            {
                Console.WriteLine("student roll no " + obj);
            }

            Console.WriteLine("capacity {0}", list.Capacity);

            Console.WriteLine("count {0}", list.Count);

            Console.ReadKey();
        }
    }
}
