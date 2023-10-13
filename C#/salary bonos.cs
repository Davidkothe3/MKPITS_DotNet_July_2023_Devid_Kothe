using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salary_bonos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int empno;
            string empname;
            string designation;
            float  salay;
            float total, bonas = 0;

            Console.WriteLine("enter the employe n=");
            empno = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the emp name=");
            empname = Convert.ToString(Console.ReadLine());

            Console.WriteLine("enter the designation=");
            designation =Convert.ToString(Console.ReadLine());

            Console.WriteLine("enter the salary=");
            salay=Convert.ToSingle(Console.ReadLine());

            if (designation == "manegar")
            {
                bonas = salay * 0.55f;
            }
            else if (designation == "enginner")
            {
                bonas = salay * 0.20f;
            }

            else if (designation == "pion")
            {
                bonas = salay * 0.12f;
            }

            else
            {
                Console.WriteLine("happy diwali");
            }

            total = salay + bonas;
            Console.WriteLine("empno= {0},empname= {1},designation={2},salary={3}", empno, empname, designation, salay);

            Console.WriteLine("total salary={0},bons={1}", salay, bonas);
              
            Console.ReadKey();
        }
    }
}
