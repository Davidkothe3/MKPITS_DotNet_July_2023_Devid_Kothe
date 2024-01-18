using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication_18jan
{
    public partial class Form1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                stype = "student";
                TextBox1.Text = "1000";
            }
        }
       static string stype = "student";
        
        protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
          if(RadioButton2.Checked)
          {
                stype = "student";
                TextBox1.Text = "3000";
                TextBox2.Text = "0";
                TextBox3.Text = "0";
          }
        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton1.Checked)
            {

            }
        }
    }
}