using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handling_Exceptions
{
    class divnumber
    {
        int res;
        public void divnumber()
        {
            res = 0;
        }
        public void division(int n1,int n2)
        {
            try
            {
                res = n1 / n2;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("exception catch : {0}", e.ToString());
            }
            finally
            {
                Console.WriteLine("result : {0}",res);
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            divnumber d=new divnumber();
            d.division(24,0);
            Console.ReadKey();
        }
    }
}
