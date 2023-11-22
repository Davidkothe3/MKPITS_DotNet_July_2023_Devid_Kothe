using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
   
  
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           Account act= new Saving();
            int actno=Convert.ToInt32(textBox1.Text);
            int amt=Convert.ToInt32(textBox2.Text);
            string teansectiontype=textBox3.Text;
            if(teansectiontype =="seving")
            {
                act = new Saving();
            }
            else if(teansectiontype =="current")
            {
                act=new Current();
            }
            label4.Text=act.deposit(actno,amt);
            label5.Text = act.showbalence();
        }
    }
}
