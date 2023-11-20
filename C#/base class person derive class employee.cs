using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace base_class_person_derive_class_employee
{
   class  person
    {
       public  string name;
       public string address;
    }

    class employee:person
    {
       public int empno;
        public int salery;
        public string designation;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            employee emp=new employee();
            emp.empno = 12;
            emp.name = "sarang";
            emp.address = "mauda";
            emp.salery = 1000000;
            emp.designation = "maneger";

            

            Console.WriteLine("empno = " +emp.empno);
            Console.WriteLine("name = " + emp.name);
            Console.WriteLine("address = " + emp.address);
            Console.WriteLine("salery = "+  emp.salery);
            Console.WriteLine("designation = " + emp.designation);

            Console.ReadKey();
        }
    }
}
