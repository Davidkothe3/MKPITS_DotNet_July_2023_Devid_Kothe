using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contain_more_than_one_main_method
{
    class book
    {
        public static int id;
        public static void disalay()

        {
            Console.WriteLine("hello from static dispaly method");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            book.id = 1;
            Program p = new Program();
            p.main();
            Console.WriteLine("id = " + book.id);
        }
        void main()
        {
            Console.WriteLine("hello from another main method");
            Console.ReadKey();

        }
    }
}
