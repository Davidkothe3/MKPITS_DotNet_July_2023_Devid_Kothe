using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_class_student
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList ar=new ArrayList();

        student[] stud=new student[3];
        int i = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            i++;
            if(i<=3)
            {

                stud[i - 1] = new student(Convert.ToInt32(textBox1.Text), textBox2.Text);
                ar.Add(stud[i - 1]);

            }


            if (i == 3)
            {
                MessageBox.Show("3 student added");
                button1.Enabled = false;
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {

            StringBuilder sb = new StringBuilder();
            foreach (student s in ar)
            {
                sb.Append("rno " + s.rno + " name " + s.name + "\n");
            }
            richTextBox1.Text = sb.ToString();

        }
    }
}
