using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace calculate_and_print_the_electricity_bill
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            int unit,id;
            float charge=0, total=0, surcharge=0, finalamt=0;

            Console.WriteLine("enter the name=");
            name=Convert.ToString(Console.ReadLine());

            Console.WriteLine("enter id=");
            id=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the unit=");
            unit=Convert.ToInt32(Console.ReadLine());

            if(unit < 199)
            {
                charge = 1.20f;
            }

            else if(unit > 200 &&  unit < 400)
            {
                charge = 1.50f;
            }
            
             else if(unit > 401 && unit < 600)
            {
                charge = 1.80f;
            }

            else if(unit < 601)
            {
                charge = 2.00f;
            }

            total = unit* charge;

            Console.WriteLine("name={0}, id={1},unit={2}", name, id, unit);
            Console.WriteLine("Charge is = " + charge);
            Console.WriteLine("total=" + total);
            

            if( unit >= 400)
            {
                surcharge = total * 0.15f;
            }
            finalamt = total + surcharge;

            Console.WriteLine(" surcharge is :  " + surcharge);
            Console.WriteLine("Finalamt is :  " + finalamt);

            Console.ReadKey();
        }
    }
}
