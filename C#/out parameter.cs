using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace of_out_parameter
{
    internal class Program
    {
        static void cal(int r,out float area,out float circ)

        {
            area = 3.14f * r * r;
            circ = 2 * 3.14f * r;
        }

        static void Main(string[] args)
        {
            int r;

            float circ, area;
           
            Console.WriteLine("enterthe redius=");
            r=Convert.ToInt32(Console.ReadLine());

            cal(r, out area, out circ);

              Console.WriteLine("area=" + area);
            Console.WriteLine("circ=" +  circ);
             
            Console.ReadKey();
        }
    }
}
