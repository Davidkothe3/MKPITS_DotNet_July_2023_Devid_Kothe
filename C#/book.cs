using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book
{
    class book
    {
       public static int id;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            book.id = 1;
            Console.WriteLine("book id = " + book.id);
            Console.ReadKey();
        }
    }
}
