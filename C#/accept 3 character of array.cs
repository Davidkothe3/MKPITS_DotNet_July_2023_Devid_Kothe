using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace accept_3_character_of_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] ch = new char[3];
           
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("enter the char");
                ch[i] = Convert.ToChar(Console.ReadLine());
            }
            for (int i = 0;i < 3;i++)
            {
                Console.Write( ""+ch[i]);
            }
           
            Console.ReadKey();
        }
    }
}
