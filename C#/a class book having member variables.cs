using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a_class_book_having_member_variables
{

    class book
    {
 
        int  bookid;
        string title;
        string author;
        int price;

           public void getdata()
        {
            bookid = 12;
            title = "pagal world";
            author = "qwerty";
            price = 200;


        }

        public void getdata(int bookid,string title,string author,int price)
        {
            this.bookid = bookid;
            this.title = title;
            this.author = author;
            this.price = price;
        }
        public void display()
        {
            Console.WriteLine("Book id= " + bookid);
            Console.WriteLine("title = " +  title);
            Console.WriteLine("author = "+ author);
            Console.WriteLine("price = " +  price);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            book b=new book();
            b.getdata();

            b.display();

            Console.WriteLine("========================");
             book b1= new book();
            b1.getdata(1,"c#","sunny",200);
            b1.display();

            Console.WriteLine("------book 1 detail");
            Console.WriteLine("enter book id");
            int id=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("title ");
            string title=Console.ReadLine();

            Console.WriteLine("author ");
            string author=Console.ReadLine();

            Console.WriteLine(" price ");
            int price=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("------book 2 detail-----");

            book b2=new book();
            b2.getdata(id,title,author,price);

            b2.display();

            Console.ReadKey();
        }
    }
}
