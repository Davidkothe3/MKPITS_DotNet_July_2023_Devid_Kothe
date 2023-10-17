using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace the_area_of_geometrical_shapes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choise,AOR=0 , square = 0, AOT=0 ;
            int l, b, num ,h;
            Console.WriteLine("Chose :  \n 1.area  \n 2.area of square  \n  3.AOT");
            choise=Convert.ToInt32(Console.ReadLine());

            switch(choise)
            {
                case 1:
                    Console.WriteLine("enter the l=");
                    l = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("enter b=");
                    b = Convert.ToInt32(Console.ReadLine());
                    AOR = l * b;

                    Console.WriteLine("AOR=" + AOR);
                    break;

                    case 2:

                    Console.WriteLine("enter the num");
                    num= Convert.ToInt32(Console.ReadLine());

                            square=num*num;

                       Console.WriteLine("square is =" + square );

                    break;

                    case 3:
                        Console.WriteLine("enter the l=");
                        l=Convert.ToInt32(Console.ReadLine());

                       Console.WriteLine("enter b=");
                    b=Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("enter h");
                     h=Convert.ToInt32(Console.ReadLine());

                    AOT = l * b * h;
                    Console.WriteLine("AOT=" + AOT);

                    break;


                    default:
                    Console.WriteLine("default");
                    break;
                  
            }
            

            Console.ReadKey();
        }
    }
}
