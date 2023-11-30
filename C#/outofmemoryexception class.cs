using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace outofmemoryexception_class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "jay";
            string subject = "csharp";
            Console.WriteLine("length of name" + name.Length);
            StringBuilder sb = new StringBuilder(name.Length, name.Length);
            try
            {
                sb.Append(subject);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Console.WriteLine("bye");
            Console.ReadKey();
        }
    }
}

