using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class actdeact : System.Web.UI.Page
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

    protected void entr_Click(object sender, EventArgs e)
    {
        cmd = new SqlCommand("select * from mobcust where cid='" + cid1.Text +"'", con);
        SqlDataReader dr;
        con.Open();
        dr = cmd.ExecuteReader();
        if (dr.Read() == true)
        {
            name.Text = dr[1].ToString();
            usid.Text = dr[3].ToString();
            status.Text = dr[20].ToString();

        }

    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        status.Text = DropDownList1.SelectedItem.ToString();

        if (status.Text == "activate")
        {
            cmd = new SqlCommand("update mobcust set status='activate'where cid='" + cid1.Text +"'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        else if (status.Text == "deactivate")
        {
            cmd = new SqlCommand("update mobcust set status='deactivate'where cid='" + cid1.Text +"'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
    protected void back_Click(object sender, EventArgs e)
    {
        Response.Redirect("employ.aspx");
    }
    
}
