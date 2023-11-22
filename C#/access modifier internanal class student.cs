using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace access_modifier_internanal_class_student
{
    class student
    {
        internal int rno;
        internal string name;
        public void displaydata()
        {
            Console.WriteLine("roll no " +  rno);
            Console.WriteLine("name " + name);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

}
