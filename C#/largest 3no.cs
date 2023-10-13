using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace largest_of_three_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1,n2,n3;

            Console.WriteLine("enter the n1=");
            n1=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the n2=");
            n2=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the n3=");
            n3=Convert.ToInt32(Console.ReadLine());

            if(n1>=n2 && n1 >= n3) 
            {
                Console.WriteLine("n1 is greater");
            }

            else if(n2>=n3 && n2 >= n1) 
            { 
              Console.WriteLine("n2 is greater");
            }

            else
            {
                Console.WriteLine("n3 is greater");
            }

            Console.ReadLine();
        }
    }
}
