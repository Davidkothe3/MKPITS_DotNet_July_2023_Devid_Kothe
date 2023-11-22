using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sealed_class_student2
{
    sealed class student
    {
        public student name;
    }
    class parttime:student //error
    {

    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
