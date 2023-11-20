using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace base_class_person__derive_class_student
{
    class person
    {
        public string name;
        public string address;
    }

    class student:person
    {
       
      public  int roll;
       public int marks;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            student p1=new student();
            p1.roll = 12;
            p1.name = "sunny";
            p1.address = "nagpur";
            p1.marks = 78;

            Console.WriteLine("rollno = " +p1.roll);
            Console.WriteLine("name = " + p1.name);
            Console.WriteLine("address = " + p1.address);
            Console.WriteLine("marks = " + p1.marks);

            Console.ReadKey();

        }
    }
}
