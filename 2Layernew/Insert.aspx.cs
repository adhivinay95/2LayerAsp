using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _2Layernew
{
    public partial class Insert : System.Web.UI.Page
    {
        Connectioncls obj = new Connectioncls();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label7.Visible = true;
            string p = "~/phs/" + FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(p));
            string sq = "insert into TwoLayer_Tab values('" + TextBox1.Text + "'," + TextBox2.Text + ",'" + TextBox3.Text + "','" + p + "','" + TextBox4.Text + "','" + TextBox5.Text + "')";
            int i = obj.Fn_exequery(sq);
            if (i == 1)
            {
                Label7.Text = "inserted";
            }
        }
    }
}