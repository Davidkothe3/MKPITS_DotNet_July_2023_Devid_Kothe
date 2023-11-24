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
using System.Runtime.InteropServices;

namespace collection_hashtable2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Hashtable hs=new Hashtable();
        private void button1_Click(object sender, EventArgs e)
        {
          hs.Add(textBox1.Text,textBox2.Text);
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            ICollection val =hs.Values;
            foreach (string i in val)
            {
                sb.Append("Age "+ i+"\n");
            }
            richTextBox1.Text = sb.ToString();

            ICollection key=hs.Keys;
            StringBuilder sb2 = new StringBuilder();
            foreach(string i in key)
            {
                sb2.Append("Name " +i+"\n");
            }
            richTextBox2.Text=sb2.ToString();
        }
    }
}
