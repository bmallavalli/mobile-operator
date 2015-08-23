using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Collections;

public partial class sample : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Server=localhost;Integrated Security=true;Initial Catalog=Bavi");
    SqlCommand cmd;
    protected void Page_Load(object sender, EventArgs e)
    {
        cmd = new SqlCommand("select userid from mobcust",con);
      
        con.Open();
        int i;
        SqlDataReader reader = cmd.ExecuteReader();
        
        GridView1.DataSource = reader;
        GridView1.DataBind();
        i = 1;
        if(reader.Read() == true)
        {
          TextBox1.Text=reader[i].ToString();
            
        }
        con.Close();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        cmd = new SqlCommand("select * from Tarif where state='" + TextBox1.Text + "' and ctype='" + TextBox2.Text + "' and servtype='" + TextBox3.Text + "' and calltype='" + TextBox4.Text + "' and planno='" + TextBox5.Text + "' and subplan='" + TextBox6.Text + "'", con);
        SqlDataReader dr;
        con.Open();
        dr = cmd.ExecuteReader();
        if (dr.Read() == true)
        {
            TextBox7.Text = dr[5].ToString();
        }
        con.Close();
    }
}