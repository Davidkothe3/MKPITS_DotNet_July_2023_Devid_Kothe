using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace shorted_example1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList sl = new SortedList();
            sl.Add("01", "rahul");
            sl.Add("03", "sarang");
            sl.Add("02", "kalkai");
            sl.Add("04", "nimunda");

            if (sl.ContainsValue("devsena"))
            {
                Console.WriteLine("this sudent alertly in list");
            }
            else
            {
                sl.Add("05", "bahubali");


                ICollection key = sl.Keys;

                foreach (string kv in key)
                {
                    Console.WriteLine(kv + ":"+ sl[kv]);
                }
            }
            Console.ReadKey();
        }
    }
}
