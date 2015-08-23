using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


public partial class addplan : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Server=localhost;Integrated Security=true;Initial Catalog=Bavi");
    SqlCommand cmd;
    string tarid = "0";
    string servtype = "call";
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


        string planno = "0";
        
        cmd = new SqlCommand("select count(*) from Tarif", con);
        SqlDataReader dr;
        con.Open();
        dr = cmd.ExecuteReader();
        if (dr.Read() == true)
        {
            tarid = dr[0].ToString();
        }
        con.Close();
        
        plnno.Text = (Convert.ToInt32(tarid)+0).ToString();

        cmd = new SqlCommand("select * from Tarif where tarid= '" + plnno.Text + "'", con);
        con.Open();
        SqlDataReader df = cmd.ExecuteReader();
        if (df.Read()==true)
        {
            planno = df[6].ToString();
        }
        
        con.Close();
        
        plnno.Text = (Convert.ToInt32(planno) + 1).ToString();
        

       
    }

    protected void submt_Click(object sender, EventArgs e)
    {
        int s;

        s = Convert.ToInt32(tarid);
        s = s + 1;
        tarid = s.ToString();
        string curdate = System.DateTime.Now.ToString();
        int adate=Convert.ToInt32(TextBox2.Text);
        string avdate=System.DateTime.Now.AddDays(adate).ToString();

        int ldate = Convert.ToInt32(TextBox3.Text);
        string lvdate = System.DateTime.Now.AddDays(adate+ldate).ToString();



        cmd = new SqlCommand("insert into Tarif values('" + tarid + "','" + RadioButtonList1.Text + "','" + RadioButtonList2.Text + "','" + servtype + "','" + sp0.Text + "','" + cst0.Text + "','" + plnno.Text + "','" + TextBox1.Text + "','" + curdate + "','" + avdate + "','" + TextBox3.Text + "','" + lvdate + "')", con);
            con.Open();
                    int result = cmd.ExecuteNonQuery();
                    con.Close();

                    s = Convert.ToInt32(tarid);
                    s = s + 1;
                    tarid=s.ToString();

                    cmd = new SqlCommand("insert into Tarif values('" + tarid + "','" + RadioButtonList1.Text + "','" + RadioButtonList2.Text + "','" + servtype + "','" + sp1.Text + "','" + cst1.Text + "','" + plnno.Text + "','" + TextBox1.Text + "','" + curdate + "','" + avdate + "','" + TextBox3.Text + "','" + lvdate + "')", con);
                    con.Open();
                    int result1 = cmd.ExecuteNonQuery();
                    con.Close();

                    s = Convert.ToInt32(tarid);
                    s = s + 1;
                    tarid = s.ToString();

                    cmd = new SqlCommand("insert into Tarif values('" + tarid + "','" + RadioButtonList1.Text + "','" + RadioButtonList2.Text + "','" + servtype + "','" + sp2.Text + "','" + cst2.Text + "','" + plnno.Text + "','" + TextBox1.Text + "','" + curdate + "','" + avdate + "','" + TextBox3.Text + "','" + lvdate + "')", con);
                    con.Open();
                    int result2 = cmd.ExecuteNonQuery();
                    con.Close();




                    if (result > 0 && result1 > 0 && result2 > 0)
                    {
                        Label2.Text = "Added Successfully";
                        Label2.Visible = true;
                       
                    }
                    else
                        Label2.Text = "Not Added";
        
    }
}