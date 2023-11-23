using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsclass_employee
{
    internal class employee
    {
        public int id;
        public string name;
        public int selary;
        public string designation;
        public employee(int id,string name,int selary,string designation) 
        {
            this.id = id;
            this.name = name;
                this.selary = selary;
            this.designation = designation;
        }
    }
}
