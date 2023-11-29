using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exception_handling_throw
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 0;

            try
            {
                Console.WriteLine("enter the age");
                age = Convert.ToInt32(Console.ReadLine());

                if(age < 18 )
                {
                    throw new Exception("age should be greater or equal to 18");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine("enter the age 18 or grater than 18");
                age=Convert.ToInt32(Console.ReadLine());
            }

            finally
            {
                Console.WriteLine("finally block is executing");
                Console.WriteLine("age :" + age);
            }
            Console.WriteLine("bye");

            Console.ReadKey();
        }
    }
}
