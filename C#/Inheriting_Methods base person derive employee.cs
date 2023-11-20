using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheriting_Methods_base_person_derive_employee
{
    class person
    {
        string name;
        string address;

        public void getpersonData(string name, string address)
        {
            this.name = name;
            this.address = address;
        }
       public void dispalayperData()
        {
            Console.WriteLine("name = " + name);
            Console.WriteLine("address = " +  address);
        }
    }
    class employe : person
    {
        int empno;
        int salery;

        public void getemploeData(int empno, int salery)
        {
            this.empno = empno;
            this.salery = salery;
        }
        public void dispalyempData()
        {
            Console.WriteLine("empno = " + empno);
            Console.WriteLine("salery = " + salery);
        }
    }
     
    internal class Program
    {
        static void Main(string[] args)
        {
            employe emp = new employe();

            emp.getpersonData("Jadeja", "Pachpoli");
            emp.getemploeData(11, 6000);

            emp.dispalayperData();
            emp.dispalyempData();   

            Console.ReadKey();
        }
    }
}
