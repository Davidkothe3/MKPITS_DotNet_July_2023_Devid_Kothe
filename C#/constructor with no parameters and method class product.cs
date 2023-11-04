using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor_with_no_parameters_and_method_class_product
{

    class product
    {
        int productid;
        string productname;
        int price;
        int quantity;


        public product()
        {
            productid = 1;
            productname = "sarang";
            price = 200;
            quantity = 1;
        }
        public void display()
        {
            Console.WriteLine("productid=" + productid);
            Console.WriteLine("productname=" + productname);
            Console.WriteLine(" price=" + price);
            Console.WriteLine("qunatity= " + quantity);

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            product p= new product();
            p.display();
            Console.ReadKey();
        }
    }
}
