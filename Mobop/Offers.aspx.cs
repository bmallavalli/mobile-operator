using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class Offers : System.Web.UI.Page
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

        cmd = new SqlCommand("select * from mobcust where userid= '" + Label1.Text + "'", con);

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

        cmd = new SqlCommand("SELECT planno,state,ctype,servtype,calltype,cost,amountrecharge,startingofferdate,endingofferdate,offerdays FROM Tarif WHERE planno>0", con);
        con.Open();

        SqlDataReader reader = cmd.ExecuteReader();

        GridView1.DataSource = reader;
        GridView1.DataBind();
        con.Close();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("customer.aspx");
    }
}