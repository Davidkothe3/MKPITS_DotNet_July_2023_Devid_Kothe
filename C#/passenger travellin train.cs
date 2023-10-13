using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passenger_travell_in_train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string origin;
            string destination;
            int date;
            int trainno;
            string cls;
            string name;
            int km;



            Console.WriteLine("enter your origin=");
            origin = Convert.ToString(Console.ReadLine());

            Console.WriteLine("destionation=");
            destination = Convert.ToString(Console.ReadLine());

            Console.WriteLine("emter date=");
            date = Convert.ToInt32(Console.ReadLine());
            

            Console.WriteLine("train no=");
            trainno = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("class=");
            cls = Convert.ToString(Console.ReadLine());

            Console.WriteLine("name=");
            name = Convert.ToString(Console.ReadLine());

            Console.WriteLine("enter km=");
            km = Convert.ToInt32(Console.ReadLine());

            if(km<=1000)
            {
                Console.WriteLine("fiar is 1200 = " +km);
            }

            else if(km<=600 && km<=1000)
            {

                Console.WriteLine("fair is 800 = " + km);
            }

            else if (km<= 400)
            {
                Console.WriteLine("fair is 500 = " + km);
            }
           
            else
            {
                Console.WriteLine("happy journey");
            }

            Console.WriteLine("origin={0},destination={1},date={2},train n={3},class={4},name={5},km={6}", origin, destination, date, trainno, cls, name, km);
            Console.ReadKey();
        }
    }
}
