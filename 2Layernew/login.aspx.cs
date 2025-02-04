using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
namespace _2Layernew
{
    public partial class login : System.Web.UI.Page
    { 
        Connectioncls obj = new Connectioncls();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string sq = "select count(Id) from TwoLayer_Tab where username='" + TextBox1.Text + "' and password='" + TextBox2.Text + "'";
            string i = obj.Fn_scalar(sq);
            if (i == "1")
            {
                int j=0;
                string s= "select Id from TwoLayer_Tab where username='" + TextBox1.Text + "' and password='" + TextBox2.Text + "'";
                SqlDataReader dr = obj.fn_datareader(s);
                while (dr.Read())
                {
                    j = Convert.ToInt32(dr["Id"].ToString());
                }
                    Session["uid"] = j;
                    Response.Redirect("view.aspx");
                
               
            }
            else
            {
                Label3.Text = "invalid";
            }
        }
    }
}