using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example_of_short_method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList array = new ArrayList();
            array.Add(1);
            array.Add(5);
            array.Add(3);
            array.Add(2);

            Console.WriteLine("array collection without short");

            foreach (int i in array)
            {
              Console.WriteLine("student rno " +  i);  
            }

            array.Sort();
            Console.WriteLine("array list collection with short");

            foreach(int i in array)
            {
                Console.WriteLine("student rollno " + i);
            }

            Console.ReadKey();
        }

    }
}
