﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace basic_asp17jan
{
    public partial class basic1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int n1=Convert.ToInt32(TextBox1.Text);
            int n2=Convert.ToInt32(TextBox2.Text);
            int res= n1+ n2;
            Label1.Text = "addition "+res.ToString();
        }
    }
}