using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace person_class_4
{
   class person
    {
        string name;
        int age;
        string address;

        public void getdata(string name, int age,string address)
        {
            this.name = name;   
            this.age = age;
            this.address = address;
        }
        public void displaydata()
        {
            Console.WriteLine("enter the name= " + name);
            Console.WriteLine("enter age = " + age);
            Console.WriteLine("enter address = " + address);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            person per = new person();
            per.getdata("SARANG", 23, "purani basti");

            per.displaydata();
            Console.ReadKey();

        }
    }
}
