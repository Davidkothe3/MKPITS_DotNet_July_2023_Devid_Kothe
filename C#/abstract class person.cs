using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_class_person
{
    abstract class person
    {
        public string name;
    }
    class student:person
    {
        public int rollno;
    }
    sealed class parttimestudent:student
    {
        public int hour;


    }
   // class bus:parttimestudent  class cant be create by using shild class
    {

    }//
    internal class Program
    {
        static void Main(string[] args)
        {
         
            parttimestudent p= new parttimestudent();
            p.rollno = 1;
            p.name = "shanu";
            p.hour = 2;
            Console.WriteLine("rno "+ p.rollno);
            Console.WriteLine("name " +  p.name);
            Console.WriteLine("hour " + p.hour);

            Console.ReadKey();
        }
    }
}
