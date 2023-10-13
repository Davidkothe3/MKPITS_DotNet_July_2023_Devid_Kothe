using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace height.if_else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int height;

            Console.WriteLine("enter height=");
            height = Convert.ToInt32(Console.ReadLine());

            if(height>=180 && height<=200)
            {
                Console.WriteLine("the man is tall");

            }

            else if(height>=150 && height<=180)
                {
                Console.WriteLine("the man is average");
                 }


            else
            {
                Console.WriteLine("the man is dwart");
            }
            Console.ReadKey();
        }
    }
}
