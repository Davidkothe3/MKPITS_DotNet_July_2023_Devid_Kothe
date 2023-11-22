using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulation_class_employee
{
    class employee
    {
        public string empname { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            employee empl=new employee();
            empl.empname = "ravi";
            Console.WriteLine("employee name : " + empl.empname);

            Console.ReadKey();
        }
    }
}
