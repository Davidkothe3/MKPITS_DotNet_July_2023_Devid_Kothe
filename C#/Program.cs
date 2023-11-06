using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_field_and_different_objects
{

    class book
    {
        static string title;
        

        static book()
        {

            Console.WriteLine(" static constructor called");
            title = "mkpits";
        }

        public void display()
        {
            Console.WriteLine("title =" + title);
        }
       
    }
    internal class Program
    {
        static void Main(string[] args)
        {
           book b1 = new book();
              b1.display();

            book b2 = new book();
            b2.display();

           Console.ReadLine();
        }
    }
}
