using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variable_length_parameter_list
{
    internal class Program
    {
        static int cal(params int[] num)

        {
            int i, total = 0;
            for(i=0; i<num.Length; i++)
            {
                total = total + num[i];
            }
            return total;
        }
        static void Main(string[] args)
        {
            int res= cal(1,2,3);
            Console.WriteLine("total= " + res);
            Console.ReadKey();
        }
    }
}
