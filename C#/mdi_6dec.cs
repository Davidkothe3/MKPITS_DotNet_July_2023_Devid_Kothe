using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mdi_6dec
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registerFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            registerform r= new registerform();
            r.MdiParent = this;
            r.Show();
        }

        private void accountFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            accountform a= new accountform();
            a.MdiParent = this;
            a.Show();
        }

        private void exlitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
