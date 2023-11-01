


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class1
{

    class Customer
    {
        public int customer_code;

        public string customer_name;

    }
    internal class Program
    {

        static void Main(string[] args)
        {
            Customer cust = new Customer();

            cust.customer_code = 123;
            cust.customer_name = "Ram";

            Console.WriteLine("customer code=" + cust.customer_code);
            Console.WriteLine("customer name=" + cust.customer_name);

            Console.ReadKey();
        }
    }
}
