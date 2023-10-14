using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vowel_or_consonant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char a;

            Console.WriteLine("enter the char=");
            a=Convert.ToChar(Console.ReadLine());

            if (a == 'a' || a == 'e' || a == 'i' || a == 'o' || a == 'u')
            {
                Console.WriteLine("vowel");
            }

            else
            {
                Console.WriteLine("consonant");
            }

            Console.ReadKey();

        }
    }
}
