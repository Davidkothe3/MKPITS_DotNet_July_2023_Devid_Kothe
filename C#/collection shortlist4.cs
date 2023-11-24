using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace collection_shortlist4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SortedList sl=new SortedList();
        private void button1_Click(object sender, EventArgs e)
        {
            sl.Add(textBox1.Text,textBox2.Text);
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            ICollection key=sl.Keys;
            foreach (string str in key)
            {
                sb.Append("name" +str +"\n"+ "age" + sl[str]+"\n" );
             }
            richTextBox1.Text = sb.ToString();
        }
    }
}
