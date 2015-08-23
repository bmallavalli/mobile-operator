using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class empupdate : System.Web.UI.Page
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
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        cmd = new SqlCommand("select * from mobemp where empid='" + empid.Text + "'", con);
        SqlDataReader dr;
        con.Open();
        dr = cmd.ExecuteReader();
        if (dr.Read() == true)
        {
            name.Text = dr[1].ToString();
            uid.Text = dr[2].ToString();
            mobno.Text = dr[9].ToString();
            mail.Text = dr[10].ToString();
            wloc.Text = dr[11].ToString();
            adrs.Text=dr[8].ToString();

        }
    }
    
    protected void updt_Click(object sender, EventArgs e)
    {
        cmd = new SqlCommand("update mobemp set mobno='" + mobno.Text + "',email='" + mail.Text + "',wloc='" + wloc.Text + "',addrs='"+adrs.Text+"'where empid='" + empid.Text + "'", con);
        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("admin.aspx");
    }
}