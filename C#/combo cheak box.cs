using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace combo_cheak_box
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        StringBuilder sb=new StringBuilder();
        private void button1_Click(object sender, EventArgs e)
        {
            string name=Convert.ToString(textBox1.Text);
           
            float salary=Convert.ToInt32(textBox3.Text);
           float bonus = 0;
            float total=0;
            if(comboBox1.Text == "maneger")
            {
                bonus = salary * 0.45f;
                total = salary + bonus;
            }
            
            else if(comboBox1.Text== "clerk")
            {
                bonus = salary * 0.30f;
                total = salary + bonus;
            }
            else if(comboBox1.Text == "pion")
            {
                bonus = salary * 0.20f;
                total = salary + bonus;
            }
            else if(comboBox1.Text == "sarang")
            {
                bonus = salary * 0.10f;
                total = salary + bonus;
            }
            if(checkBox1.Checked)
            {
              sb.Append(bonus);

            }
            if(checkBox2.Checked)
            {
                sb.Append(total);
            }

            label4.Text = sb.ToString();
        }
    }
}
