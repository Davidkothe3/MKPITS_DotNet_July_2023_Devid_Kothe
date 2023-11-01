using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_prog2
{
    class Customer
    {
        int Customer_id;
        string Customer_name;

        public void getdata(int id,string cn)
        {
            Customer_id = id;
            Customer_name = cn;
        }
        public void displaydata()
        {
            Console.WriteLine("customer id =" + Customer_id);
            Console.WriteLine("customer name= "+  Customer_name);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
           Customer cust = new Customer();
            cust.getdata(123, "sham");
           
            cust.displaydata();

            Console.ReadKey();
        }
    }
}
