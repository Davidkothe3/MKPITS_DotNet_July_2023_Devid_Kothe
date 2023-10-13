using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace accept_3_subject_marks__if_else_if
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sub1,sub2,sub3,total;
            float per;
            string gread = null;
            Console.WriteLine("mark sub1=");
            sub1=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("mark sub2=");
            sub2=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("mark sub3=");
            sub3=Convert.ToInt32(Console.ReadLine());
             
            total=sub1 +sub2 + sub3;

            Console.WriteLine("total=" +  total);

            Console.WriteLine("\n");

            per = (total / 300.0f) * 100.0f;

            Console.WriteLine("per= {0}", per);

            if (per >= 80)
            {
                Console.WriteLine("A grade ");
            }
            else if (per >= 65 )
            {
                Console.WriteLine("B grade");
            }

            else if (per >= 50)
            {
                Console.WriteLine("C grade");

            }
            else
            {
                Console.WriteLineWriteLine("you are fail");

            }
            Console.WriteLine("grade : {0}", gread);

            Console.ReadKey();
        }
    }
}
