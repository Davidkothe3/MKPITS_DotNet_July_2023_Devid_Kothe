using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace product_Store_12jan
{
    public partial class Form1 : Form
    {
        string strcon = "server =.\\SQLEXPRESS; integrated security = true; database = TAbleProductCategory_11jan";
        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;


        public Form1()
        {
            InitializeComponent();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getcategory();
            getproduct();   
        }
        public void getcategory()
        {
            try
            {
                con = new SqlConnection(strcon);
                da = new SqlDataAdapter("select * from TableProductCategory order by Product_Category_ID", con);
                ds = new DataSet();
                da.Fill(ds, "tpc");
                comboBox1.DataSource = ds.Tables["tcp"];
                comboBox1.DisplayMember = "Product_Type_Name";
                comboBox1.ValueMember = "Product_Category_ID";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void getproduct()
        {

            if(comboBox1.SelectedValue != null && comboBox1.SelectedValue.GetType() != typeof(System.Data.DataRowView))
            {               
                    con = new SqlConnection(strcon);
                    da = new SqlDataAdapter("select * from Tableproduct where Product_Category_ID = @pci", con);
                    da.SelectCommand.Parameters.AddWithValue("@pci", comboBox1.SelectedValue);
                    ds = new DataSet();
                    da.Fill(ds,"product");
                    comboBox2.DataSource = ds.Tables["product"];
                    comboBox2.DisplayMember = "Product_Name";
                    comboBox2.ValueMember = "ProductID";    
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
             
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            getproduct();
        }
    }
}
