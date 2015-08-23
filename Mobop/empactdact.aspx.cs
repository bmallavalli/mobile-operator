using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class empactdact : System.Web.UI.Page
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
    protected void sbmit_Click(object sender, EventArgs e)
    {
        cmd = new SqlCommand("select * from mobemp where empid='" + empid.Text + "'", con);
        SqlDataReader dr;
        con.Open();
        dr = cmd.ExecuteReader();
        if (dr.Read() == true)
        {
            name.Text = dr[1].ToString();
            uid.Text = dr[2].ToString();
            status.Text = dr[13].ToString();

        }

    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        status.Text = DropDownList1.SelectedItem.ToString();

        if (status.Text == "Activate")
        {
            cmd = new SqlCommand("update mobemp set Status='activate'where empid='" + empid.Text + "'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        else if (status.Text == "Deactivate")
        {
            cmd = new SqlCommand("update mobemp set Status='deactivate'where empid='" + empid.Text + "'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
    protected void back_Click(object sender, EventArgs e)
    {
        Response.Redirect("admin.aspx");
    }
}