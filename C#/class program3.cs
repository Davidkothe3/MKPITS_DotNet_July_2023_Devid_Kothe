using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_prog3
{
    class employee
    {
        int emp_no;
        int salary;
        string emp_name;
        string disignation;

        public void getdata(int emo_no, string emp_name, string disignation , int salary)

        {
            this.emp_no = emo_no;
            this.emp_name = emp_name;
            this.disignation = disignation;
            this.salary = salary;
        }
        public void displaydata()
        {
            Console.WriteLine("enter employee id=" + emp_no);
            Console.WriteLine("enter the name=" + emp_name);
            Console.WriteLine(" enter designantion=" +  disignation);
            Console.WriteLine("salary=" + salary);
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            employee emp = new employee();
            emp.getdata(123, "David", "Md", 50000);

                emp.displaydata();

            Console.ReadKey();
        }
    }
}
