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

namespace Dictionary_collection_windows2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Dictionary<string, string> domains = new Dictionary<string, string>();

        private void button1_Click(object sender, EventArgs e)
        {
            domains.Add(textBox1.Text, textBox2.Text);
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
            MessageBox.Show("added in dictionary");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            List<string> keys = new List<string>(domains.Values);
            foreach (string key in keys)
            {
                sb.Append("values in dictionay " + key + "\n");
            }
            richTextBox2.Text = sb.ToString();


        }

        private void button2_Click(object sender, EventArgs e)
        {

            StringBuilder sb = new StringBuilder();
            List<string> keys = new List<string>(domains.Keys);
            foreach (string key in keys)
            {
                sb.Append("keys in dictionay " + key + "\n");
            }
            richTextBox1.Text = sb.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (KeyValuePair<string, string> kvp in domains)
            {
                sb.Append("key " + kvp.Key + " value " + kvp.Value + "\n");
            }
            richTextBox2.Text = sb.ToString();

        }
    }
}
