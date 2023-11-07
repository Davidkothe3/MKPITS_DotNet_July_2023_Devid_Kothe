using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_overloading_with_diff_type_of_para
{
    class calculation
    {
        public void addition(int n1,int n2)
        {
            int add=n1+ n2;
            Console.WriteLine( "addition = " + add);
        }

        public void addition(float n1,float n2)
        {
            float add =n1+ n2;
            Console.WriteLine("addition of float = "+  add);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            calculation cal=new calculation();
            cal.addition(1, 2);
            Console.WriteLine("calling the addition");

            Console.WriteLine("---------------------");

            cal.addition(2.5f, 5.5f);
            Console.WriteLine("calling flaot addition");

            Console.ReadKey();
        }
    }
}
