using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace print_the_table_of_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("enter the num");
            num=Convert.ToInt32(Console.ReadLine());

            int res = 0;
            int cont = 1;

            while(cont <=10) 
            {
                res=num*cont;

                Console.WriteLine("{0}*{1}={2}",num,cont,res);

                cont++;
            }

            Console.ReadKey();  
        }
    }
}
