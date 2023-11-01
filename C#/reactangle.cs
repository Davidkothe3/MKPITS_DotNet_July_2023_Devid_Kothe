using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle_Class
{

    class reactrangle
    {
        int w, h, area = 0;

        public void getdata(int w, int h)
        {
            this.w = w;
            this.h = h;
            area= w * h;
        }

        public void displaydata()
        {
            Console.WriteLine(" width= " + w);
            Console.WriteLine(" height= " + h);

            Console.WriteLine(" area of reactangle== " + area);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            reactrangle react = new reactrangle();

            Console.WriteLine("enter width");
            int w=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the height");
            int h=Convert.ToInt32(Console.ReadLine());
            react.getdata(w,h);

            react.displaydata();

            Console.ReadKey();
        }
    }
}
