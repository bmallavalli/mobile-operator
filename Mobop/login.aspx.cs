using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class login : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Server=localhost;Integrated Security=true;Initial Catalog=Bavi");
    SqlCommand cmd;
    protected void Page_Load(object sender, EventArgs e)
    {

        Session["uname"] = usid.Text;
        Response.Expires = -1;
        Response.Cache.SetNoServerCaching();
        Response.Cache.SetAllowResponseInBrowserHistory(false);
        Response.CacheControl = "no-cache";
        Response.Cache.SetNoStore();
    }
    protected void loginbut_Click(object sender, EventArgs e)
    {
        if (Label2.Text == "Customer")
        {
            cmd = new SqlCommand("select * from mobcust where userid='" + usid.Text + "'", con);
            SqlDataReader dr;
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read() == true)
            {
                if (pswd.Text == dr[4].ToString())
                {

                    Response.Redirect("customer.aspx");
                }
                else
                {
                    Label1.ForeColor = System.Drawing.Color.Red;
                    Label1.Text = "Invalid user/password";
                }

            }
            else
            {
                Label1.Visible = true;
                Label1.ForeColor = System.Drawing.Color.Red;
                Label1.Text = "Invalid user/password";
            }
        }

        else if(Label2.Text=="Employee")
        {
            cmd = new SqlCommand("select * from mobemp where userid='" + usid.Text + "'", con);
            SqlDataReader dr;
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read() == true)
            {
                if (pswd.Text == dr[4].ToString())
                {

                    Response.Redirect("employ.aspx");
                }
                else
                {
                    Label1.ForeColor = System.Drawing.Color.Red;
                    Label1.Text = "Invalid user/password";
                }

            }
            else
            {
                Label1.ForeColor = System.Drawing.Color.Red;
                Label1.Text = "Invalid user/password";
            }

        }

        else if (Label2.Text == "Admin")
        {
            cmd = new SqlCommand("select * from mobadmin where userid='" + usid.Text + "'", con);
            SqlDataReader dr;
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read() == true)
            {
                if (pswd.Text == dr[3].ToString())
                {

                    Response.Redirect("admin.aspx");
                }
                else
                {
                    Label1.ForeColor = System.Drawing.Color.Red;
                    Label1.Text = "Invalid user/password";
                }

            }
            else
            {
                Label1.ForeColor = System.Drawing.Color.Red;
                Label1.Text = "Invalid user/password";
            }

        }




    }
    protected void elled_Click(object sender, EventArgs e)
    {
        Response.Redirect("login.aspx");
    }
    protected void cust_emp_SelectedIndexChanged(object sender, EventArgs e)
    {
        Label2.Text = cust_emp.SelectedItem.ToString();
    }
}