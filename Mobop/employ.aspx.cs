using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class employ : System.Web.UI.Page
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

        cmd = new SqlCommand("select * from mobemp where userid= '" + Label1.Text + "'", con);

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
    protected void custdet_Click(object sender, EventArgs e)
    {
        Response.Redirect("custdetails.aspx");
    }
    protected void actdeact_Click(object sender, EventArgs e)
    {
        Response.Redirect("actdeact.aspx");
    }
    protected void update_Click(object sender, EventArgs e)
    {
        Response.Redirect("update.aspx");
    }
    protected void chpswd_Click(object sender, EventArgs e)
    {
        npswd.Visible = true;
        submit.Visible = true;
    }
    protected void submit_Click(object sender, EventArgs e)
    {
        cmd = new SqlCommand("update mobemp set pswd='" + npswd.Text + "'where userid='" + Label1.Text +"'", con);
        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();
        Label2.Visible = true;
        Label2.ForeColor = System.Drawing.Color.Green;
        Label2.Text = "Change Successfully";
    }
    protected void addplan_Click(object sender, EventArgs e)
    {
        Response.Redirect("addplan.aspx");
    }
    protected void updplan_Click(object sender, EventArgs e)
    {
        Response.Redirect("updateplan.aspx");
    }
}