using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


public partial class update : System.Web.UI.Page
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
    
    protected void enter_Click(object sender, EventArgs e)
    {
        cmd = new SqlCommand("select * from mobcust where cid='" + cid1.Text + "'", con);
        SqlDataReader dr;
        con.Open();
        dr = cmd.ExecuteReader();
        if (dr.Read() == true)
        {
            name.Text = dr[1].ToString();
            usid.Text = dr[2].ToString();
            mobno.Text = dr[7].ToString();
            mail.Text = dr[9].ToString();
            type.Text = dr[17].ToString();

        }
    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        type.Text = DropDownList1.Text;
    }
    protected void updated_Click(object sender, EventArgs e)
    {
        cmd = new SqlCommand("update mobcust set mobno='"+mobno.Text+"',email='"+mail.Text+"',type='"+type.Text+"'where cid='" + cid1.Text +"'", con);
        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();
    }
    protected void back_Click(object sender, EventArgs e)
    {
        Response.Redirect("employ.aspx");
    }

    
}