using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace total__percentage_and_grade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] marks = new int[5];
            int sum = 0;
            float per = 0;
            string grade = null;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("enter marks");
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < 5; i++)
            {
                sum = sum + marks[i];
                Console.WriteLine("sum  = {0}", sum);
                
            }
            per = (sum / 500.0f) * 100.0f;
            Console.WriteLine("per = {0}", per);

            if (per < 90)
            {
                grade = "Topper";
            }
            else if (per > 70 && per < 90)
            {
                    grade = "Grade A";
            }
            else if (per > 50 && per < 70)
            {

                grade = "grade B";
            }
            else



            Console.WriteLine("Grade is = " + grade);
            Console.ReadKey();


        }
        
    }
}
