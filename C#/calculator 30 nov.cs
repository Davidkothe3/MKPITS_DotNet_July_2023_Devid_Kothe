using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator_30_nov
{
    public class calculator
    {
        public int res;
        public void addition(int x, int y)
        {
             
            res = x + y;
        }
        public void substration(int x,int y)
        {
           
            res=x-y;
        }
        public void mult(int x,int y)
        {
            
            res = x*y;
        }
        public void div(int x,int y)
        {
            
            res = x/y;
        }
        public void display()
        {
            Console.WriteLine("Result : " + res);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;

            Console.WriteLine("enter the 2 num");
            n1=Convert.ToInt32(Console.ReadLine());
            n2 = Convert.ToInt32(Console.ReadLine());

            calculator c=new calculator();
            c.addition(n1,n2);
            c.display();

            c.substration(n1,n2);
            c.display();

            c.mult(n1,n2);
            c.display();

            c.div(n1,n2);
            c.display() ;


          
            Console.ReadKey();
        }
    }
}
