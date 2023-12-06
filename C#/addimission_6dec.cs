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
    public partial class addimission : Form
    {
        public addimission()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb= new StringBuilder();

            sb.Append("name : " + textBox1 + "\n");
            sb.Append("aadhar_no :" + textBox2 + "\n");
            sb.Append("aducation_in :" + textBox10 + "\n");

            if(checkBox1.Checked)
            {
                sb.Append("course : " + checkBox1.Text + "\n");
            }
            if(checkBox2.Checked)
            {
                sb.Append("course : " + checkBox2.Text + "\n");
            }
            if(checkBox3.Checked)
            {
                sb.Append("course : " + checkBox3.Text + "\n");
            }
            if(checkBox4.Checked)
            {
                sb.Append("course : " + checkBox4.Text + "\n");
            }
            sb.Append("DOB : " + maskedTextBox1.Text + "\n");

            if(radioButton1.Checked)
            {
                sb.Append("gender :" + radioButton1.Text + "\n");
            }
            else if(radioButton2.Checked)
            {
                sb.Append("gender : " + radioButton2.Text + "\n");
            }

            sb.Append("division : " + textBox3.Text + "\n");
            sb.Append("distric :" + textBox4.Text + "\n");
            sb.Append("address : " + textBox5.Text + "\n");
            sb.Append("religion :" + textBox6.Text + "\n");
            sb.Append("nationality : " + textBox7 + "\n");
            sb.Append("phone : " + textBox8.Text + "\n");
            sb.Append("email : " + textBox9 + "\n");

            richTextBox1.Text= sb.ToString();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
