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
    public partial class view : System.Web.UI.Page
    {
        Connectioncls obj = new Connectioncls();
        protected void Page_Load(object sender, EventArgs e)
        {
            string s = "select Name,Age,Address,Photo from TwoLayer_Tab where Id=" + Session["uid"] + "";
            SqlDataReader dr = obj.fn_datareader(s);
            while (dr.Read())
            {
                TextBox1.Text = dr["Name"].ToString();
                TextBox2.Text = dr["Age"].ToString();
                TextBox3.Text = dr["Address"].ToString();
                Image1.ImageUrl = dr["Photo"].ToString();
            }
            DataSet ds = obj.fn_dataset(s);
            GridView1.DataSource = ds;
            GridView1.DataBind();
            DataList1.DataSource = ds;
            DataList1.DataBind();
        }
    }
}