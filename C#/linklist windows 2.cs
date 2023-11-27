using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace linklist_windows_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        LinkedList<int> li=new LinkedList<int>();
        private void button2_Click(object sender, EventArgs e)
        {
          li.AddLast(Convert.ToInt32(textBox1.Text));
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            li.AddFirst(Convert.ToInt32(textBox1.Text));
            textBox1.Clear();
            textBox1.Focus();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            li.Remove(2,textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();

        }

        private void button6_Click(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            li.Insert(2, textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();

        }

        private void button4_Click(object sender, EventArgs e)
        {

            StringBuilder sb = new StringBuilder();
            foreach (int s in li)
            {
                sb.Append("num " + s + "\n");
            }
            richTextBox1.Text = sb.ToString();

        }
    }
}
