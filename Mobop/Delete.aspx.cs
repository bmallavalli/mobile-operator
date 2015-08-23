using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Delete : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Server=localhost;Integrated Security=true;Initial Catalog=Bavi");
    SqlCommand cmd;
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        cmd = new SqlCommand("delete from mobcust where name='Chanti'", con);
        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();
    }
}