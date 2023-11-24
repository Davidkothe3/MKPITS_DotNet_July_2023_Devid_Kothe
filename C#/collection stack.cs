using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace collection_stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack st = new Stack();
            st.Push('a');
            st.Push('e');
            st.Push('i');
            st.Push('o');
           
            Console.WriteLine("current stack");
            foreach (char c in st)
            {
                Console.WriteLine(c+"");
            }
            Console.WriteLine();
            st.Push('u');
            Console.WriteLine("next poppable vlaue  in stack "+ st.Peek());
            foreach (char c in st)
            {
                Console.WriteLine(c + "");
            }

            Console.ReadKey();
        }
        
    }
}
