using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculate_total__per_and_grade_for__5_sub
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sub=5;
            int total = 0;
            float per=0;
            string grade;

            Console.WriteLine("entyer the sub=");
            sub=Convert.ToInt32(Console.ReadLine());

            for(int i=1;i<5;i++)
            {


                Console.WriteLine("enter the sub=");
                sub = Convert.ToInt32(Console.ReadLine());

                total = total +  sub ;
              

                per = (total / 500.0f) * 100.0f;

            }

            Console.WriteLine("total is = " + total);
            Console.WriteLine("per is = " + per);
           
          

            if (per>90)
            {
                Console.WriteLine("A grade");
            }
            else if(per>80)
            {
                Console.WriteLine("B grade");
            }
            else if (per>65)
            {
                Console.WriteLine("C grade");
            }

            else if(per>50)
            {
                Console.WriteLine("D grade");
            }

            else
            {
                Console.WriteLine("fail");
            }
          
            grade = Convert.ToString(Console.ReadLine());
            Console.WriteLine("grade=" + grade);

            Console.ReadKey();

        }
    }
}
