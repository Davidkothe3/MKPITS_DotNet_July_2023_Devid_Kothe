using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parameterized_constructor_with_4_parameters
{
    class book
    {
        int id;
         string title;
           string author;
           int  price;

        public book()
        {
          id = 1;
            title = "vb.net";
            author = "qwerty";
            price = 300;
        }

        public book(int id, string title, string author, int price)
        {
            this.id = id;
            this.title = title;
            this.author = author;
            this.price = price;
        }
        public void display()
        {

            Console.WriteLine("-----------");
            Console.WriteLine("id=" +  id);
            Console.WriteLine("title=" +  title);
            Console.WriteLine("author= " +  author);
            Console.WriteLine("price=" +  price);
            Console.WriteLine("----------------");
        }
    }
    internal class Program
    {

        static void Main(string[] args)
        {

            book b1= new book();
            b1.display();

            book b2= new book(2,"zero","asdfg",400);
            b2.display();

            Console.ReadKey();
        }
    }
}
