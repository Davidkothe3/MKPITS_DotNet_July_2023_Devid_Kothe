using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BAsic2_jan17
{
    public partial class calculation_basic2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int n1=Convert.ToInt32(TextBox1.Text);
            int n2=Convert.ToInt32(TextBox2.Text);
            char op=Convert.ToChar(TextBox3.Text);
            int res = 0;

            if (op == '+')
            {
                res = n1 + n2;
            }
            else if (op == '-')
            {
                res = n1 - n2;
            }
            else if (op == '*')
            {
                res = n1 * n2;
            }
            else if (op == '/')
            {
                res = n1 / n2;
            }
            else
            {
                Label1.Text = "invalid charactor";
            }
            Label1.Text=" result " + res.ToString();
          
            
        }
    }
}