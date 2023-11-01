using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shortcut_for_properties_for_private
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            person p= new person();


            int r= Convert.ToInt32(textBox2.Text);
            string n=textBox1.Text;
            int m = Convert.ToInt32(textBox3.Text);
            int s = Convert.ToInt32(textBox4.Text);
            int en = Convert.ToInt32(textBox5.Text);
            p.getdata(r, n, m,s,en);
            
            StringBuilder sb = new StringBuilder();
            sb.Append("Name = " + p.name);
            sb.Append("Roll No = " + p.rollno);
            sb.Append("total = " + p.total);
            sb.Append("average = "+p.avg);

            label6.Text = sb.ToString();

        }
    }
}
