using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace employee_highest_salary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        employee[] emp = new employee[3];
        int cunt = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            emp[0] = new employee();
            emp[1]= new employee();
            emp[2]= new employee();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(cunt < 3)
            {
                emp[cunt].empId = Convert.ToInt32(textBox1.Text);
                emp[cunt].empName= textBox2.Text;
                emp[cunt].salary = Convert.ToInt32(textBox3.Text);

                cunt++;

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox1.Focus();

                if(cunt == 3) 
                {
                    button1.Enabled = false;
                    textBox1.Enabled = false;
                    textBox2.Enabled=false;
                    textBox3.Enabled=false;
                    button2.Enabled=true;

                    MessageBox.Show("detail of 3 employee are submited");
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("employee detail are : " + "\n");

            for(int i = 0; i < 3; i++)
            {
                sb.Append("------------------------------------  \n" );
                sb.Append("employee id = " + emp[i].empId + "\n");
                sb.Append("employee name = " + emp[i].empName  + "\n");
                sb.Append("employee asalary = " + emp[i].salary + "\n");
                sb.Append("------------------------------------  \n ");

            }


            label4.Text = sb.ToString();

            double high = emp[0].salary;
            int foundat = 0;
            for(int i = 0;i < 3;i++)
            {
                if (high < emp[i].salary) 
                {
                    high = emp[i].salary;
                    foundat = i;
                }
            }

            StringBuilder sb1 = new StringBuilder();
            sb1.Append("employee with high salary :  \n" );
            sb1.Append("employee no : " + emp[foundat].empId + "\n");
            sb1.Append("employee name : " + emp[foundat].empName + "\n");
            sb1.Append("employee salary : "+ emp[foundat].salary + "\n");

            label5.Text = sb1.ToString();
        }
    }
}
