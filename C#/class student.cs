using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_student
{
    class student
    {
        string name;
        int rollno;
        int[] mark;
        
        public void getdata(string name, int rollno,int[] mark)

        {
            this.name = name;
            this.rollno = rollno;
            this.mark = mark;
           


        }

        public void displaydata()
        {
            Console.WriteLine("enter the name="+ name);
            Console.WriteLine("enter the roll=" + rollno);
            int total = 0;
            for (int i = 0; i < mark.Length; i++)
            {
                total = total + mark[i];
            }
            int avg= total/mark.Length;
            Console.WriteLine("total=" + total);
            Console.WriteLine("average=" + avg);
        
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            student stud = new student();

            Console.WriteLine("enter the name=");
            string  name = Convert.ToString(Console.ReadLine());

            Console.WriteLine("enter the age");
            int rollno=Convert.ToInt32(Console.ReadLine());


            int[] m = new int[5];
            
               Console.WriteLine("enter the marks");
               
            for (int i = 0; i < m.Length; i++)
            {
                m[i]= Convert.ToInt32(Console.ReadLine());
            }


            stud.getdata(name,rollno,m);

            stud.displaydata();

            Console.ReadKey();
        }
    }
}
