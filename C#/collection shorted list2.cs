using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace collection_shorted_list2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList sl=new SortedList();
            sl.Add(3,"lallan");
            sl.Add(1, "poojjaa");
            sl.Add(4, "donat");
            sl.Add(7, "java");

            if(sl.ContainsValue("khan sir"))
            {
                Console.WriteLine("it is available");
            }
            else
            {
                sl.Add(6, "lanba");
            }

            ICollection key = sl.Keys;

            foreach(int k in key)
            {
                Console.WriteLine(k + ":" + sl[k]);
            }

            Console.ReadLine();
        }
    }
}
