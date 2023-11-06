using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overload_method_with_2_para_3_para_4_para
{
    class student
    {
        int id;
        string name;
        string course;
        int fees;

        public void getdata(int id)
        {
            this.id = id;
        }

        public void getdata(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public void getdata(int id,string name,string course)
        
        {
            this.id= id;
            this.name = name;
            this.course = course;
        } 

        public void getdata(int id,string name,string course,int fees)
        {
            this.id = id;
            this.name = name;
            this.course = course;
            this.fees = fees;

        }
        public void display()
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("id = " +id);
            Console.WriteLine("name = " + name);
            Console.WriteLine("course = " + course);
            Console.WriteLine("fees = "+  fees);
            Console.WriteLine("-------------------");
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            student std1 = new student();
             
            std1.getdata(1);
            std1.display();

            student std2 = new student();
            std2.getdata(1,"akash");
            std2.display();

            student std3 = new student();
            std3.getdata(1, "akash", "java");
            std3.display();

            student std4 = new student();
            std4.getdata(1, "akash", "java",1000);
            std4.display();

            Console.ReadKey();


        }
    }
}
