using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace access_modifier_class_student
{
    class student
    {
        internal int rollno;
        internal string name;
        public void displaydata()
        {
            Console.WriteLine("roll no " + rollno);
            Console.WriteLine("name " + name);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            student s = new student();
            s.rollno = 1;   
            s.name = "Tejas";

            s.displaydata();
            Console.ReadKey();
        }
    }
}
