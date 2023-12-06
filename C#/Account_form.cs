using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace contextmenustrip_control_6dec
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rToolStripMenuItem_Click(object sender, EventArgs e)
        {
            register_form rf= new register_form();
            rf.MdiParent = this;
            rf.Show();

        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            register_form rf=new register_form();
            rf.MdiParent = this;
            rf.Show();
        }

        private void accountToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Account_form af= new Account_form();
            af.MdiParent = this;
            af.Show();
        }

        private void accountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Account_form af = new Account_form();
            af.MdiParent = this;
            af.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
