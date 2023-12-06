using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mdi_application_6dec
{
    public partial class enqury : Form
    {
        public enqury()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb=new StringBuilder();

            sb.Append("name : " + textBox1.Text + "\n");

            if(radioButton1.Checked)
            {
                sb.Append("gender : " + radioButton1.Text + "\n");
            }
            else if(radioButton2.Checked) 
            {
                sb.Append("gender : "+radioButton2.Text +"\n");
            }
           
            if(checkBox1.Checked)
            {
                sb.Append("course :"+checkBox1.Text+"\n");
            }
            if(checkBox2.Checked)
            {
                sb.Append(" "+checkBox2.Text+"\n");
            }
            if(checkBox3.Checked)
            {
                sb.Append(" "+checkBox3.Text+"\n");
            }
            if(checkBox4.Checked)
            {
                sb.Append(" " + checkBox4.Text + "\n");
            }

            sb.Append("contact : " + textBox2.Text + "\n");

            sb.Append("address : " + textBox3.Text + "\n");

            richTextBox1.Text = sb.ToString();
        }
    }
}
