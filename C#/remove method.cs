using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace remove_method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList array = new ArrayList();

            array.Add(1);
            array.Add(2);
            array.Add(3);

            Console.WriteLine("array list without remove method");

             foreach (object obj in array) 
            {
                Console.WriteLine("student roll no "+obj);
            }
             array.RemoveAt(2);

            Console.WriteLine("------------------");

            Console.WriteLine("with remove method");

            foreach (object obj in array)
            {
                Console.WriteLine("student roll no"+obj);

            }
            Console.ReadKey();
        }
    }
}
