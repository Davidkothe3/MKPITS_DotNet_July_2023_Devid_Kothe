using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form2_5dec
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("username " + textBox1.Text + "\n");
            sb.Append("password " +textBox2.Text +"\n");

            string gender = null;
            if(radioButton1.Checked)
            
                gender = radioButton1.Text;
            
            else if(radioButton2.Checked)
            
                gender=radioButton2.Text;
            
            sb.Append("gender "+gender+"\n");

            string course = null;

            if(checkBox1.Checked)
                course = radioButton1.Text;

            if (checkBox2.Checked)
                course = course + " " + checkBox2.Text;

            sb.Append(" course " +course + "\n");

            sb.Append("country " + comboBox1.Text + "\n");

            sb.Append("city " +comboBox2.Text +"\n");

            richTextBox1.Text = sb.ToString();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            comboBox2.Text = " ";

            switch (comboBox1.Text)
            {
                case "india":
                    comboBox2.Items.Add("nagpur");
                    comboBox2.Items.Add("pune");
                
                break;
                case "nepal":
                    comboBox2.Items.Add("janakpur");
                    comboBox2.Items.Add("katmandu");
                break;
              
            }
          
        }
    }
}
