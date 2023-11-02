using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace roll_no_name_fees_date
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        student[] stud=new student[5];
        int count = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            stud[0] = new student();
            stud[1]=  new student();
            stud[2] = new student();
            stud[3]=  new student();
            stud[4]=  new student();
         

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (count < 5 )
            {
                stud[count].rollno = Convert.ToInt32(textBox1.Text);
                stud[count].name=textBox2.Text;
                stud[count].fees=Convert.ToDouble(textBox3.Text);
                stud[count].date=Convert.ToString(textBox4.Text);

                count++;

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();

                if (count == 5 )
                {
                    button1.Enabled = false;
                    textBox1.Enabled = false;
                    textBox2.Enabled = false;
                    textBox3.Enabled = false;
                    textBox4.Enabled = false;
                    button2.Enabled = true;

                    MessageBox.Show("detail of 5 student are submited");
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb1 = new StringBuilder();
            sb1.Append("employee detail are :" + "\n");

            for(int i = 0;i<5;i++)
            {
                sb1.Append("=========================== \n ");
                sb1.Append("roll no : " + stud[i].rollno +"\n");
                sb1.Append(" name : " + stud[i].name + "\n");
                sb1.Append("  payement :" + stud[i].fees + "\n");
                sb1.Append(" fees payement : " + stud[i].date + "\n");
            }

            richTextBox1.Text = sb1.ToString();
            double high = stud[0].fees;
            int foundat = 0;

            for(int i = 0; i<5;i++)
            {
                if (high < stud[i].fees )
                {
                    high= stud[i].fees;
                    foundat = i;
                }
            }

            StringBuilder sb2 = new StringBuilder();
            sb2.Append("stuent pay with high fees");
            sb2.Append("roll no : "+stud[foundat].rollno +"\n");
            sb2.Append("name : " + stud[foundat].name +"\n");
            sb2.Append("payement : " + stud[foundat].fees + "\n");
            sb2.Append("date :" + stud[foundat].date +"\n");

            richTextBox2.Text = sb2.ToString();


        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
