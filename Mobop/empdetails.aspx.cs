using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class empdetails : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Server=localhost;Integrated Security=true;Initial Catalog=Bavi");
    SqlCommand cmd;
    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Text = Session["uname"].ToString();
        Response.Expires = -1;
        Response.Cache.SetNoServerCaching();
        Response.Cache.SetAllowResponseInBrowserHistory(false);
        Response.CacheControl = "no-cache";
        Response.Cache.SetNoStore();

        cmd = new SqlCommand("select * from mobadmin where userid= '" + Label1.Text + "'", con);
        con.Open();
        SqlDataReader dm = cmd.ExecuteReader();
        if (dm.HasRows)
        {
        }
        else
        {
            Response.Redirect("login.aspx");
        }
        con.Close();

        cmd = new SqlCommand("select empid,name,uid,desg,doj,mobno,wloc,status from mobemp", con);
        con.Open();

        SqlDataReader reader = cmd.ExecuteReader();

        GridView1.DataSource = reader;
        GridView1.DataBind();
        con.Close();
    }
   
    protected void back_Click(object sender, EventArgs e)
    {
        Response.Redirect("admin.aspx");
    }
}