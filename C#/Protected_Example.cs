using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protected_Example
{
    class employe   
    {
        public string name;

        protected void getemopdata( string name)
        {
            this.name = name;
        }
        protected void displyempdata()
        {
            Console.WriteLine("Name : " + name);
        }
    }
    class person : employe
    {
        public int id;
        public int salary;

        public void getperdata( int id , int salary) 
        {
            getemopdata("Bandya");
            displyempdata();
         this.id = id;
         this.salary = salary;
        }
        public void displayperdata()
        {
            Console.WriteLine("id : " + id) ;
            Console.WriteLine("Salary : "+  salary) ;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            person p = new person();

            p.getperdata(1, 20000);
            p.displayperdata();

            Console.ReadKey();
        }
    }
}
