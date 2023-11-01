using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace name_age_address
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            person p=new person();
            p.name=textBox1.Text;
            p.age=Convert.ToInt32(textBox2.Text);
            p.address = textBox3.Text;

            StringBuilder sb = new StringBuilder();
            sb.Append("name= " + p.name + "/t");
            sb.Append("age= " + p.age + "/t");
            sb.Append("address= " + p.address + "/t");

            label4.Text = sb.ToString();

        }
    }
}
