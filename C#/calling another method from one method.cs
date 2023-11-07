using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calling_another_method_from_one_method
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
            title = "assumption";
            author = "akashy";
            price = 500;

        }

        public void getdata(int id)
        {
            this.id = id;
            getdata(id,"ASSSUMPTION");
        }

        public void getdata(int id,string title)
        {
            this.id = id;
            this.title = title;
            author = "ravi";
             getdata(id,title,author);
        }
        public void getdata(int id,string title,string author)

        {
            this.id=id;
            this.title = title;
            this.author = author;
            author = "ravi";
            getdata(id, title, author, 200);
        }

        public void getdata(int id,string title,string author, int price)
        {
            this.id = id;
            this.title=title;
            this.author = author;
            this.price = price;

        }

        public void display()
        {
            Console.WriteLine("id = " +  id);
            Console.WriteLine("title = "+ title);
            Console.WriteLine("author = "+  author);
            Console.WriteLine("price = " +  price);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            book book = new book();
            book.getdata(1);
            book.display();
            Console.WriteLine("----book detail-----");
            Console.ReadKey();
        }
    }
}
