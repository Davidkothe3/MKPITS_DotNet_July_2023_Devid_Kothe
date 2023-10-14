using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace calculate_the_total__percentage_division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rollno;
            string name;
            int phy, chem, maths;
            int total;
            float per;
            string gread=null;

            Console.WriteLine("enter the rollno=");
            rollno=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the name=");
            name=Convert.ToString(Console.ReadLine());

            Console.WriteLine("mark sub1=");
            phy = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("mark sub2=");
            chem = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("mark sub3=");
            maths = Convert.ToInt32(Console.ReadLine());

            total = phy + chem + maths;

            Console.WriteLine("total=" + total);

            Console.WriteLine("\n");

            per = (total / 300.0f) * 100.0f;

            Console.WriteLine("per= {0}", per);

            if (per >= 80)
            {
                Console.WriteLine("A grade= ");
            }
            else if (per >= 65)
            {
                Console.WriteLine("B grade");
            }

            else if (per >= 50)
            {
                Console.WriteLine("C grade");

            }
            else
            {
                Console.WriteLine("you are fail");

            }
            Console.WriteLine("rollno={0},name={1},phy={2},chem= {3},maths={4},total={5},per={6},gread={7}",rollno,name,phy,chem,maths,total,per,gread);
             


             Console.ReadKey();


        }
    }
}
