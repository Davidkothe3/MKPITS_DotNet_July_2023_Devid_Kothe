using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace accept_5_subject_marks_per_grade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] marks= new int[5];
            int total;
          //  float per;

            for (int i = 0;i<5;i++)
            {
                Console.WriteLine("enter the marks=");
                marks[i] = Convert.ToInt32(marks[i]);

            }

            for(int i = 0; i<5;i++)
            {
                 total = marks + i;
            }
              
            Console.WriteLine("total="+ total);
            Console.ReadKey();

        }
    }
}
