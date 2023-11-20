using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace base_class_employee_derieved_class_programmer
{
    class employee
    {
        protected int salery;
    }
    class programmer:employee
    {
        int bonus;

        public void getdata(int salery, int bonus)
        {
            this.bonus = bonus;
            this.salery = salery;
        }

        public void displaydata()
        {
            Console.WriteLine("salery " + salery);
            Console.WriteLine("bonus " + bonus);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            programmer p = new programmer();
            p.getdata(120000,10000);
            p.displaydata();
            Console.ReadKey();
        }
    }
}
