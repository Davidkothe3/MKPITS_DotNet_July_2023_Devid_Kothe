using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_3jan24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            studentclass s = new studentclass();
            string g = null;
            if(radioButton1.Checked)
            {
                g= "male";
            }
            if (radioButton2.Checked)
            {
                g = "female";
            }

            string h = null;
            if(checkBox1.Checked)
            {
                h = "khokho";
            }
            if(checkBox2.Checked)
            {
                if (h != null)
                    h = h + "" + "cricket";
                else
                    h = "cricket";
            }

            string result=s.InsertStudent(Convert.ToInt32(textBox1.Text),
                textBox2.Text,g,h,comboBox1.Text,dateTimePicker1.Value.ToShortDateString());

            label7.Text = result;
            cleartext();
        }
         public void cleartext()
         {
            textBox1.Clear();
            textBox2.Clear();
            radioButton1.Checked= false;
            radioButton2.Checked= false;
            checkBox1 .Checked = false;
            checkBox2 .Checked = false;
            comboBox1.Text = "";
            dateTimePicker1.Value= DateTime.Now;

         }

        private void button2_Click(object sender, EventArgs e)
        {
            studentclass s= new studentclass();
            string g = null;
            if(radioButton1.Checked)
            {
                g = "male";

            }
            if(radioButton2.Checked)
            {
                g = "female";
            }
            string h= null;
            if(checkBox1.Checked) 
            {
                h = "khokho";
            }
            if(checkBox2.Checked)
            {
                if (h != null)
                    h = h + " " + "cricket";
                else
                    h = "cricket";
            }

            string result = s.Upadatestudent(Convert.ToInt32(textBox1.Text), textBox2.Text,
                g, h, comboBox1.Text, dateTimePicker1.Value.ToShortDateString());

              label7.Text = result;
            cleartext();
        }
    }
}
