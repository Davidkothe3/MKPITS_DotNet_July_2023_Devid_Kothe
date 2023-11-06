using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overload__method_with_0__1__2_3_4_parameters
{
    class book
    {
        int id;
        string author;
        string title;
        int price;

        public void getdata()
        {
            id = 1;
            title = "zero";
            author = "srk";
            price = 200;
        }
        public void getdata(int id)
        {
            this.id = id;

        }
        public void getdata(int id, string author)
        {
            this.id = id;
            this.author = author;
        }

        public void getdata(int id, string author, string title)
        {
            this.id = id;
            this.author = author;
            this.title = title;
        }
        public void getdata(int id, string author, string title, int price)
        {
            this.id = id;
            this.author = author;
            this.title = title;
            this.price = price;
        }

        public void display()
        {
            Console.WriteLine("id = " + id);
            Console.WriteLine("author = " + author);
            Console.WriteLine("title = " + title);
            Console.WriteLine("price = " + price);
        }

    }
   

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------With First parameter------");
            book b1= new book();
            b1.getdata( 1 );
            b1.display();

            Console.WriteLine("--------With second parameter------");
            book b2 = new book();
            b2.getdata( 1,"Devid");
            b2.display();

            Console.WriteLine("--------With Third parameter------");
            book b3 = new book();
            b3.getdata(1, "Devid","gangsOfWasepur");
            b3.display();

            Console.WriteLine("--------With Fourth parameter------");
            book b4 = new book();
            b4.getdata(1, "Devid", "gangsOfWasepur",550);
            b4.display();



            Console.ReadKey();
        }
    }
}
