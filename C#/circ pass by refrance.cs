using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace area_circ_pass_by_reference
{
    internal class Program
    {
        static void cal(int r, ref float area, ref float circ)
            {
              circ=3.14f * r * r;
               area = 2 * 3.14f * r;

            }
        static void Main(string[] args)
        {
            int r;
            float circ=0, area=0;

              Console.WriteLine("enter the r=");
            r = Convert.ToInt32(Console.ReadLine());

            cal(r, ref area, ref circ);

            Console.WriteLine(" circle= " + circ);
            Console.WriteLine("area= "+ area);
             Console.ReadKey();
        }
    }
}
