using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace toolstrip_control_6dec
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            register r=new register();
            r.MdiParent = this;
            r.Show();
        }

        private void accounToolStripMenuItem_Click(object sender, EventArgs e)
        {
            account a=new account();
            a.MdiParent = this;
            a.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void registerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            account a = new account();
            a.MdiParent = this;
            a.Show();
        }

        private void accountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            register r = new register();
            r.MdiParent = this;
            r.Show();
        }

        private void exitToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this .Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            register r=new register();
            r.MdiParent = this;
            r.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            account a=new account();
            a.MdiParent = this;
            a.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.Close ();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text=DateTime.Now.ToString();
        }
    }
}
