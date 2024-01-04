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

namespace user_pass_4jan2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string str = "server= DESKTOP-EDB1BOV\\SQLEXPRESS ; integrated security=true;database=user_pass_jan4";
         SqlConnection con = null;
        SqlCommand command = null;

        private void button1_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(str);
            try
            {

                string qr = "select count(*) from users01 where username=@username and passwords=@passwords ";

                command = new SqlCommand(qr, con);

                command.Parameters.Add("@username", textBox1.Text);
                command.Parameters.Add("@passwords", textBox2.Text);

                con.Open();

                int cnt = Convert.ToInt32(command.ExecuteScalar());
                if(cnt>0)
                {
                    MessageBox.Show("Login successful");
                    
                }

                else
                {
                    MessageBox.Show("invalid , plsss try again....!");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

            finally 
            {
                con.Close();
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
