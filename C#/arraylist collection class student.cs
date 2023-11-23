using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraylist_collection_class_student
{
    class student
    {
        public int Id;
        public string name;
        public student(int Id,string name) 
        {
             this.Id = Id;
            this.name = name;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            student s1=new student (1,"qwerty");
            student s2 = new student(2, "sham");
            student s3 = new student(3, "ayush");

            ArrayList at = new ArrayList();

            at.Add(s1);
            at.Add(s2);
            at.Add(s3);

            foreach(student i in at)
            {
                Console.WriteLine("---------------");
                Console.WriteLine("roll no "+ i.Id);

                Console.WriteLine("name = " + i.name);
                Console.WriteLine("------------");
                    
            }

            Console.ReadKey();
        }
    }
}
