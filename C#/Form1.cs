﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
         ArrayList at=new ArrayList();
        private void button1_Click(object sender, EventArgs e)
        {
            student s1=new student(Convert.ToInt32(textBox1.Text),textBox2.Text);

            student s2 = new student(Convert.ToInt32(textBox3.Text),textBox4.Text);

            at.Add(s1);
            at.Add(s2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb =new StringBuilder();
            foreach(student i in at)
            {
               sb.Append("rno  \n" + i.rno + "name  " + i.name + "\n");
            }
            label5.Text = sb.ToString();
        }
    }
}
