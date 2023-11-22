using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sealed_method_class_person
{
    class person
    {
        public virtual void display()
        {
            Console.WriteLine("hellow from person");
        }
    }
    class student : person 
    {
        public string name;
        public sealed override void display()
        {
            Console.WriteLine("hellow");
        }
    }

    class parttimestudent : student
    {

        /*
        public override void display() //error since sealed.
        {
            Console.WriteLine("hellow");
        }
        */
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            parttimestudent p = new parttimestudent();
            p.display();

            Console.ReadKey();
        }
    }
}
