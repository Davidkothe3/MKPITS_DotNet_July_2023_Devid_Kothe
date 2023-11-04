using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor_with_no_parameters_and_method
{
    class book
    {
        int bookid;
        string title, author;
        int price;

        public book()
        {
            bookid = 1;
            title = "zero to one";
            author = "sarang";
            price = 200;
        }
        public void display()
        {

            Console.WriteLine("book id = " + bookid);
            Console.WriteLine("book title = " + title);
            Console.WriteLine("book author= " + author);
            Console.WriteLine("price = " + price);

        }
    }

        internal class Program
    {
        static void Main(string[] args)
        {
           book b=new book();
                b.display();

                Console.ReadKey();
        }
    }
}