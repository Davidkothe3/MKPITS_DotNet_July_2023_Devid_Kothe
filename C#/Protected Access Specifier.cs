using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protected_Access_Specifier
{
    class student
    {
        protected string name;
        public void getdata()
        {
            name = "ram";
            Console.WriteLine("name :"+name);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            student s = new student();
           // s.name = "ram";
            s.getdata();
            Console.ReadKey();
        }
    }
}
