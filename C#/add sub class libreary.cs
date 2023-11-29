using calculatelilbrary_1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace add_sub_class_libreary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
          Calculate c=new Calculate();
        private void button1_Click(object sender, EventArgs e)
        {
              int r=c.addition(Convert.ToInt32(textBox1.Text),Convert.ToInt32(textBox2.Text));

            label3.Text = "addition" + r;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int r= c.substration(Convert.ToInt32(textBox1.Text),Convert.ToInt32(textBox2.Text));

            label3.Text = "substration " + r;
        }
    }
}
