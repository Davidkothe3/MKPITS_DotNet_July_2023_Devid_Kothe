using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_list_example2
{
   

    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList ar=new ArrayList();

            ar.Add("ram");
            ar.Add("sham");
            ar.Add("raja");

            foreach(object obj in ar)
            {
                Console.WriteLine("student name " + obj);
            }

            Console.ReadKey();
                
        }
    }
}
