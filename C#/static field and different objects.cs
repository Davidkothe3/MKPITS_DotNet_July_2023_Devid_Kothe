using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_constructor
{
  class student
    {
        static string name;
        static int age;

        static student()
        {
            name = "ram";
            age = 21;
        }
        public static void display()
        {
        Console.WriteLine("name= " +  name);
            Console.WriteLine("age = " +  age);

        }

    }
    
    internal class Program
    {
        public static void Main(string[] args)
        {
            student.display();

              Console.ReadKey();

        }
    }
}
