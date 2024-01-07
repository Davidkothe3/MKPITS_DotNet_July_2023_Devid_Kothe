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

namespace disconnectedcrude_5jan
{
    public partial class Form1 : Form
    {
        public string ConnectionString { get; set; } = @"Data source = .\sqlexpress;Initial catalog=company_5jan;Integrated Security= true;";


        SqlDataAdapter Sqlda;
        DataSet dataSet;
        SqlCommandBuilder cb;

        public Form1()
        {
            InitializeComponent();
            Sqlda = new SqlDataAdapter("Select * from emolpyee05", ConnectionString);


            cb = new SqlCommandBuilder(Sqlda);
            dataSet = new DataSet();
            Sqlda.Fill(dataSet, "Emp");

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataRow dr = dataSet.Tables["Emp"].NewRow();

            dr[0] = textBox1.Text;
            dr[1] = textBox2.Text;
            dr[2] = textBox3.Text;
            dr[3] = Convert.ToInt16(textBox4.Text);
            dr[4] = textBox5.Text;
            dr[5] = Convert.ToInt32(textBox6.Text);
            dr[6] = Convert.ToInt32(textBox7.Text);

            dataSet.Tables["Emp"].Rows.Add(dr);

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox1.Focus();
          


        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataRow dr in dataSet.Tables["Emp"].Rows)
            {
                if (dr[0].ToString() == textBox1.Text)
                {
                    try
                    {
                        dr[0] = textBox1.Text;
                        dr[1] = textBox2.Text;
                        dr[2] = textBox3.Text;
                        dr[3] = Convert.ToInt16(textBox4.Text);
                        dr[4] = textBox5.Text;
                        dr[5] = textBox6.Text;
                        dr[6] = Convert.ToInt32(textBox7.Text);
                        Sqlda.Update(dataSet.Tables["Emp"]);
                        MessageBox.Show("Data Successfully Updated..");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
                }
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (DataRow dr in dataSet.Tables["Emp"].Rows)
            {
                if (dr[0].ToString() == textBox1.Text)
                {
                    try
                    {
                        dataSet.Tables["Emp"].Rows.Remove(dr);
                        Sqlda.Update(dataSet.Tables["Emp"]);
                        MessageBox.Show("Data Successfully Deleted..");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource = dataSet.Tables["Emp"];

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
