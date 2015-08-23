using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


public partial class custdetails : System.Web.UI.Page
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
    

    
    protected void back_Click(object sender, EventArgs e)
    {
        Response.Redirect("employ.aspx");
    }

    protected void dt_Click(object sender, EventArgs e)
    {
        cmd = new SqlCommand("SELECT cid,name,uid,simno,mobno,doa,imei,type,state,Balance,status,Bill FROM mobcust WHERE CAST(FLOOR(CAST( [doa] AS float)) AS datetime)  =  '" + TextBox1.Text + "'", con);
        con.Open();

        SqlDataReader reader = cmd.ExecuteReader();

        GridView2.DataSource = reader;
        GridView2.DataBind();
        con.Close();
    }
    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        TextBox1.Text = Calendar1.SelectedDate.ToShortDateString();
        Calendar1.Visible = false;
    }
    protected void mobsub_Click(object sender, EventArgs e)
    {
        cmd = new SqlCommand("SELECT cid,name,uid,simno,mobno,doa,imei,type,state,Balance,status,Bill FROM mobcust WHERE mobno  =  '" + TextBox2.Text + "'", con);
        con.Open();

        SqlDataReader reader = cmd.ExecuteReader();

        GridView3.DataSource = reader;
        GridView3.DataBind();
        con.Close();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        cmd = new SqlCommand("select cid,name,uid,simno,mobno,doa,imei,type,state,Balance,status,Bill from mobcust", con);
        con.Open();

        SqlDataReader reader = cmd.ExecuteReader();

        GridView1.DataSource = reader;
        GridView1.DataBind();
        con.Close();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Calendar1.Visible = true;
    }
    protected void back_Click1(object sender, EventArgs e)
    {
        Response.Redirect("employ.aspx");
    }
}