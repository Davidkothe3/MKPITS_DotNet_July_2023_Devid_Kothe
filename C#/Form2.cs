using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace example_of_array_list
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        ArrayList ar=new ArrayList();
        private void button1_Click(object sender, EventArgs e)
        {
            ar.Add(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("capecity " + ar.Capacity);
            MessageBox.Show("Count " + ar.Count);
            StringBuilder sb = new StringBuilder();

            foreach (object o in ar)
            {
                sb.Append("name " + o.ToString() + "\n");
            }
            label2.Text = sb.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
