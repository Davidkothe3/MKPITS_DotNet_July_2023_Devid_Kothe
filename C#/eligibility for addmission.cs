using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eligibility_for_admission
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int phy, chem, math;
            int total;
            Console.WriteLine("enter the phy mark=");
            phy=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the chem marks=");
            chem=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the maths marks=");
            math=Convert.ToInt32(Console.ReadLine());

            total = phy + chem + math;

            Console.WriteLine("marks="+ total);

            if(total>=140)
            {
                Console.WriteLine("cong..you are eligible");
            }
            else
            {
                Console.WriteLine("sorry.. you are not eligible");
            }

            Console.ReadKey();
        }
    }
}
