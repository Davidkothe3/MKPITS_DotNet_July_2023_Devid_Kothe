using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insert_method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList array = new ArrayList();
            array.Add(13);
            array.Add(12);
            array.Add(15);

            Console.WriteLine("without insert");

            foreach(int i in array)
            {
                Console.WriteLine("student roll no" + i);
            }

            array.Insert(1,2);
            Console.WriteLine("===========================");

            foreach(int i in array)
            {
                Console.WriteLine("student roll no" + i);
            }

            Console.ReadKey();
        }
    }
}
