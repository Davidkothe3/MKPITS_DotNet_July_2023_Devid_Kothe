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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void enquryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            enqury eq = new enqury();
            eq.MdiParent = this;
            eq.Show();
        }

        private void addimissionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addimission ad= new addimission();
            ad.MdiParent = this;
            ad.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
           textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="admin" || textBox2.Text=="admin")
            {
                panel1.Visible = false;
                menuStrip1.Visible = true;
                textBox1.Clear();
                textBox2.Clear();

            }
            else
            {
                MessageBox.Show("invalid");
            }
            
        }
    }
}
