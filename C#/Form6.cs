﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsclass_employee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        employee emp;
        ArrayList ar=new ArrayList();

        

        private void button1_Click(object sender, EventArgs e)
        {

            emp = new employee(Convert.ToInt32(textBox1.Text), textBox2.Text,Convert.ToInt32(textBox3.Text),textBox4.Text);
            ar.Add(emp);

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder(); 

            foreach(employee emp in ar )
            {
                sb.Append("Empno " + emp.name + "\n");
                sb.Append("Emp name " + emp.name + "\n");
                sb.Append("emp designation " + emp.designation + "\n");
                sb.Append("Emp salary " + emp.selary + "\n");
            }
            richTextBox1.Text = sb.ToString();  
        }
    }
}
