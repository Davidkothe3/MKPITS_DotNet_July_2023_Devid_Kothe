using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace local_and_shared_variable
{
    internal class Program
    {
        class program
        {

            static void display()
            {
                int num = 10;
                Console.WriteLine("num inside method " + num);

            }
            static void Main(string[] args)
            {
                display();

                Console.ReadKey();




    
            }
        }  
    }
}
