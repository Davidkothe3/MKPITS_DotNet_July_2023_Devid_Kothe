using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a__parameterized_const_with_4_para_accepting_the_user_value
{
    class book
    { 
    int bookid;
    string title;
    string author;
    int price;


    public book(int bookid, string title, string author, int price)
        {
            this.bookid = bookid;
            this.title = title;
            this.author = author;
            this.price = price;

        }
        public void dispaly()
        {
            Console.WriteLine("bookid=" + bookid);
            Console.WriteLine("title ="+ title);
            Console.WriteLine("author = "+  author);
            Console.WriteLine("ptice = "+  price);

        }
     }
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("enter bookid");
            int b1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter title");
            string t1 = Console.ReadLine();
            Console.WriteLine("enter author");
            string a1 = Console.ReadLine();
            Console.WriteLine("enter price");
            int p1 = Convert.ToInt32(Console.ReadLine());

              book b2=new book(b1,t1,a1,p1);

            b2.dispaly();

            Console.ReadKey();
        }
    }
}
