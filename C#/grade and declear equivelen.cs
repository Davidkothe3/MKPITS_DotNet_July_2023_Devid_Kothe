using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace accept_grade_declare_equivalent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ch;

            Console.WriteLine("enter the char=");
            ch = Convert.ToChar(Console.ReadLine());

            if(ch =='E')
            {
                Console.WriteLine("Excellent");
            }
            else if(ch == 'V')
            {
                Console.WriteLine("Very Good");
            }

            else if(ch=='G')
            {
                Console.WriteLine("Good");
            }

            else if(ch=='A')
            {
                Console.WriteLine("Average");
            }

            else if(ch=='F')
            {
                Console.WriteLine("Fail");
            }

            else
                {
                Console.WriteLine("NO more words");
            }
            Console.WriteLine(" the character is "`+ch);
              Console.ReadKey();
        }
    }
}
