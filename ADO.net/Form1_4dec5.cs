using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace user_pass_disconnect_4jan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("server=.\\SQLEXPRESS;integrated security=true;database=student_info_3jan");
        DataSet ds = new DataSet();
        SqlDataAdapter da;
        SqlCommandBuilder cb = null;
        private void button1_Click(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("Select * from stud_info",con);

            cb = new SqlCommandBuilder(da);

            da.Fill(ds,"student");

            dataGridView1.DataSource = ds.Tables["student"];

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                da.Update(ds.Tables["student"]);
                MessageBox.Show("Record updated");
            }
            catch (Exception ex) 
            {
              MessageBox.Show(ex.Message);
            }
        }
    }
}
