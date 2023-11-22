using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessSpecifiers
{
    class student
    {
        public string id { get; set; }
        public string name { get; set; }
        public string email { get; set; }

    }

}

namespace AccessSpecifiers
{
   

    internal class Program
    {
        static void Main(string[] args)
        {
            student stu = new student();
            stu.id = "11";
            stu.name = "ashish";
            stu.email = "golu@gmail.com";

            Console.WriteLine("ID = " + stu.id);
            Console.WriteLine("name = " + stu.name);
            Console.WriteLine("email = " + stu.email);

            Console.ReadKey();

        }
    }
}
