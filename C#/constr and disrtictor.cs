using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constr_and_disrtictor
{
    class employee
    {
        public employee()
        {
            Console.WriteLine("constructor called");
        }
        ~employee()
        {
            Console.WriteLine("districtor called");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            employee employee = new employee();
            Console.ReadKey();

            employee employee1 = new employee();
            Console.ReadKey();
        }
    }
}
