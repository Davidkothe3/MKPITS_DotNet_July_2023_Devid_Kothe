using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheriting_Methods_base_class_person_derivr_class_student
{
      public class person
    {
        string name;
        string address;

        public void getpersonData(string name, string address)
        {
            this.name = name;
            this.address = address;
        }
        public void dispalypersonData()
        {
            Console.WriteLine("name = " +name);
            Console.WriteLine("address = "+ address);
        }
    }

    public class student : person
    {
        int roll;
        int marks;
        public void getstudent(int roll, int marks)
        {
            this.roll = roll;
            this.marks = marks;

        }
        public void displaystudentData()
        {
            Console.WriteLine("roll = " + roll);
            Console.WriteLine("marks = " +  marks);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            student s1 = new student();
            s1.getpersonData("ram", "nagpur");
            s1.getstudent(1,99);
            s1.dispalypersonData();
            s1.displaystudentData();

            Console.ReadKey();

            
        }
    }
}
