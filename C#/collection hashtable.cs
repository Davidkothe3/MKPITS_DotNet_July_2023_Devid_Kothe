using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.ObjectModel;

namespace collection_hashtable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("1","luaky");
            ht.Add("2","sarang");
            ht.Add("3","sujit");
            ht.Add("4","chrtan");
            ht.Add("5","david");

            if(ht.ContainsValue("akash"))
            {
                Console.WriteLine("the student name alertely list");
            }
            else
            {
                ht.Add("6", "akash");
            }

            ICollection key= ht.Keys;
            foreach(string str in key)
            {
                Console.WriteLine(str + ":" + ht[str]);
            }

            Console.ReadKey();
        }
    }
}
