using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace another_example_of_copy_constructor
{  {
    class employee
    {
        private string name;
        private int age;
        public employee(employee emp)  
        {
            name = emp.name;
            age = emp.age;
        }
        public employee(string name, int age) 
        {
            this.name = name;
            this.age = age;
        }
        public string Details     
        {
            get
            {
                return " The age of " + name + " is " + age.ToString();
            }
        }
    }
    class empdetail
    {

        internal class Program
        {
            static void Main(string[] args)

            {
                employee emp1 = new employee("Vithal", 23);  // Create a new employee object.
                employee emp2 = new employee(emp1);          // here is emp1 details is copied to emp2.
                Console.WriteLine(emp2.Details);
                Console.ReadLine();

            }
            
        }
    }
}
