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

namespace Course_reg_8jan
{
    public partial class Form1 : Form
    {
        string strcon = "server=.\\sqlexpress;integrated security=true; database=enumerator_fendal_8jan";
        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
              try
              {
                con = new SqlConnection(strcon);
                da =new SqlDataAdapter("select * from Nation order by Nation_ID", con);
                ds= new DataSet();
                da.Fill(ds, "nation");
                comboBox1.DataSource = ds.Tables["nation"];
                comboBox1.DisplayMember = "Nation_Name";
                comboBox1.ValueMember = "Nation_ID";
              }
            catch(SqlException ee) 
              {
                MessageBox.Show(ee.ToString());
              }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                try
                {
                    con = new SqlConnection(strcon);
                    da = new SqlDataAdapter("select * from States where Nation_ID=@Nation_ID", con);
                    da.SelectCommand.Parameters.AddWithValue("Nation_ID",comboBox1.SelectedValue);

                    ds = new DataSet();
                    ds.Clear();
                    da.Fill(ds,"states");

                    comboBox2.DataSource = ds.Tables["states"];
                    comboBox2.DisplayMember = "State_Name";
                    comboBox2.ValueMember = "State_ID";



                }
                catch (SqlException ee)
                {
                    MessageBox.Show(ee.ToString());
                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox2.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                try
                {

                    con = new SqlConnection(strcon);
                    da = new SqlDataAdapter("select * from City where State_ID=@State_ID",con);
                    da.SelectCommand.Parameters.AddWithValue("@state_id", comboBox2.SelectedValue);
                    ds = new DataSet();
                    ds.Clear();
                    da.Fill(ds,"city");
                    comboBox3.DataSource = ds.Tables["city"];
                    comboBox3.DisplayMember = "city_name";
                    comboBox3.ValueMember = "city_id";

                }
                catch (SqlException ee)
                {
                    MessageBox.Show(ee.ToString());
                }

            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {


        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                cat = category.IT_professional;
                textBox2.Text = "3000";
                textBox3.Text = "0";
                textBox4.Text = "0";
            }
        }
         enum category { Student,IT_professional }
         enum Gender {Male,female,other }

        category cat;
        Gender gen;

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="")
            {
                MessageBox.Show("FUll Name Can't be Blank");
            }
            else
            {
                if(radioButton1.Checked)
                {
                    cat = category.Student;

                }
                else if(radioButton2.Checked)
                {
                    cat = category.IT_professional;
                }
                MessageBox.Show("category " + cat);
              
                if(radioButton3.Checked)
                {
                    gen = Gender.Male;
                }
                else if( radioButton4.Checked)
                {
                    gen = Gender.female;
                }
                else if(radioButton5.Checked)
                {
                    gen = Gender.other;
                }
                MessageBox.Show("gender selected " + gen);

            }
        }

        public void calculatefees()
        {
            if(cat.ToString()=="Student")
            {
                textBox2.Text = "1000";

                float ta=Convert.ToSingle(textBox2.Text);
                float fp = ta * 0.5f;
                float amt = Convert.ToSingle(textBox3.Text);


            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                cat=category.Student;
                textBox2.Text = "1000";
                textBox3.Text = "0";
                textBox4.Text = "0";
            }
        }
    }
}
