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

namespace collection_hashmap_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        Hashtable hs = new Hashtable();

        private void button1_Click(object sender, EventArgs e)
        {
            hs.Add(textBox1.Text, textBox2.Text);
            textBox1.Clear();
            textBox2.Clear();

            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
          

            StringBuilder sb = new StringBuilder();
             ICollection key=hs.Keys;

            foreach (string a in key)
            {
                sb.Append("album name "+a+"\n");
            }
            richTextBox1.Text = sb.ToString();

            ICollection val=hs.Values;
            StringBuilder sb2 = new StringBuilder();
            foreach (string a in val)
            {
                sb2.Append("singer"+a+"\n");
            }
            richTextBox1.Text = sb2.ToString();

        }
    }
}
