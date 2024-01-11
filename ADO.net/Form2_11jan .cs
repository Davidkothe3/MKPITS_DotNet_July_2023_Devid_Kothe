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

namespace Product_Store_11jan
{
    public partial class Form1 : Form
    {
        string strcon = "server=.\\sqlexpress;integrated security=true;Database=TAbleProductCategory_11jan";

        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar !='.'))
            {
                e.Handled = true;
                MessageBox.Show("enter only number");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            getcategory();
            getproduct();
            getprice();

        }
        public void getcategory()
        {
            con = new SqlConnection(strcon);
            da = new SqlDataAdapter("select * from tableproductcategory", con);
            ds=new DataSet();
            da.Fill(ds,"tpc");
            comboBox1.DataSource = ds.Tables["tpc"];
            comboBox1.DisplayMember = "Product_Type_Name";
            comboBox1.ValueMember= "Product_Category_ID";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            getproduct();
        }
        public void getproduct()
        {
         if(comboBox1.SelectedValue.ToString() != "System.data.DataRowView")
            {
                 con=new SqlConnection(strcon);
                da = new SqlDataAdapter("select * from tableproduct where Product_Category_ID=@pci", con);
                da.SelectCommand.Parameters.AddWithValue("@pci", comboBox1.SelectedValue);
                ds=new DataSet();
                da.Fill(ds,"tp");

                comboBox2.DataSource = ds.Tables["tp"];
                comboBox2.DisplayMember = "Product_Name";
                comboBox2.ValueMember = "ProductID";
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            getprice();
        }
        public void getprice()
        {
            if(comboBox2.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                con= new SqlConnection(strcon);
                da = new SqlDataAdapter("select * from Tableproduct where ProductID=@pid", con);


                da.SelectCommand.Parameters.AddWithValue("@pid", comboBox2.SelectedValue);

                ds=new DataSet();
                da.Fill(ds,"tp1");

                foreach(DataRow dr in ds.Tables["tp1"].Rows)
                {
                    textBox10.Text = dr["Product_Price"].ToString();
                }

            }
        }
    }
}
