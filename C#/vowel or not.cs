
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vowel_or_not
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ch;
            Console.WriteLine("enter the char=");
            ch=Convert.ToChar(Console.ReadLine());

            switch(ch)
            {
                case 'a':
                case 'e':
                    case 'i':
                case 'o':
                case 'u':

                    Console.WriteLine("the char are vowel");

                break;
       
                    default: Console.WriteLine("charv is consonent");

                    break;

            }
              Console.ReadLine();
        }
    }
}
