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

namespace sqlparameter_ado_jan4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string str = "server=.\\sqlexpress;integrated security=true;database=student_info_3jan";

        SqlConnection con = null;

        SqlCommand command = null;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string gender = null;
                if (radioButton1.Checked == true)
                {
                    gender = radioButton1.Text;
                }
                else if (radioButton2.Checked == true)
                {
                    gender = radioButton2.Text;
                }

                string hobby = null;
                if (checkBox1.Checked)
                    hobby = checkBox1.Text;
                if (checkBox2.Checked)
                    hobby += " " + checkBox2.Text;
                con = new SqlConnection(str);
                con.Open();
                string qr = "insert into stud_info values(@rno,@names,@gender,@hobby,@city,@dob)";

                command = new SqlCommand(qr, con);

                command.Parameters.AddWithValue("@rno", Convert.ToInt32(textBox1.Text));
                command.Parameters.AddWithValue("@names", textBox2.Text);
                command.Parameters.AddWithValue("@gender", gender);
                command.Parameters.AddWithValue("@hobby", hobby);
                command.Parameters.AddWithValue("@city", comboBox1.Text);
                command.Parameters.AddWithValue("@dob", dateTimePicker1.Text);
                command.ExecuteNonQuery();

                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();

                MessageBox.Show("Record save successfully");

            }
            catch(Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
      
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con= new SqlConnection(str);
            string qr = "select * from stud_info where @rno=rno";
            command = new SqlCommand(qr, con);

            command.Parameters.AddWithValue("@rno", textBox1.Text);

            con.Open();

            SqlDataReader dr= command.ExecuteReader();

            int flag= 0;
            textBox2.Clear();

            checkBox1.Checked = false;
            checkBox2.Checked = false;

            while(dr.Read())
            {
                flag = 1;
                textBox2.Text = dr["names"].ToString();
                string gen= dr["gender"].ToString() ;

                if(gen=="male")
                    radioButton1.Checked = true;

                else if(gen=="female")
                    radioButton2.Checked = true;


            }
        }
    }
}
