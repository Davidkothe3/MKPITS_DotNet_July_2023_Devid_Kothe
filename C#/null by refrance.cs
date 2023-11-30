using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace null_by_refrance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = null;
            try
            {
                Console.WriteLine(str.ToString());
            }

            catch (NullReferenceException ne)
            {
              Console.WriteLine(ne.ToString());
            }
            Console.WriteLine("bye");
            Console.ReadKey();
        }
    }
}
