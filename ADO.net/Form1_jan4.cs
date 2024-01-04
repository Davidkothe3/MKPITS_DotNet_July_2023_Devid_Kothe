using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace user_pass_4jan1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string str = "server=.\\sqlexpress;integrated security=true;database=user_pass_jan4";

        SqlConnection con = null;
        SqlCommand command=null;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(str);
                String qr = "select count (*) from users01 where username=@username and passwords=@passwords";

                command = new SqlCommand(qr, con);
                command.Parameters.Add("@username", SqlDbType.VarChar, 20).Value = textBox1.Text;
                command.Parameters.Add("@passwords", SqlDbType.VarChar, 20).Value = textBox2.Text;

                con.Open();

                int cnt = Convert.ToInt32(command.ExecuteScalar());

                if (cnt > 0)

                    label3.Text = "login successfull";


                else

                    label3.Text = "invalid,plsss try again";
            }

               catch (Exception ee)
               {
                MessageBox.Show(ee.ToString());
               }
      
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear(); 
            textBox1.Focus();
        }
    }
}
