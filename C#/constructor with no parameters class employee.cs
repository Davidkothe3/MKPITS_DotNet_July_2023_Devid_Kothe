using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor_with_no_parameters_class_employee
{
    class employee
    {
        int empno;
        string empname;
        string designtion;
        int salary;

        public employee() 
        {
            empno = 1;
            empname = "sarang";
            designtion = "MD";
            salary = 50000;
        }
        public void display()
        {
            Console.WriteLine("empno=" + empno);
            Console.WriteLine("empname= " + empname);
            Console.WriteLine("designation= " + designtion);
            Console.WriteLine("salary=" + salary);

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            employee emp = new employee();

            emp.display();
            Console.ReadKey();
        }
    }
}
