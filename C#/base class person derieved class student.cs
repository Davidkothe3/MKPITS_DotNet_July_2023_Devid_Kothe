using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace base_class_person_derieved_class_student
{
    class person
    {
        public string name;
    }

    class student : person
    {
        public int roll;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            student s=new student();
            s.roll = 1;
            s.name = "sham";
            Console.WriteLine( "roll - " + s.roll);
            Console.WriteLine(" name - "+  s.name);
            Console.ReadKey();
        }
    }
}
