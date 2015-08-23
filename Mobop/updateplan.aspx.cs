using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class updateplan : System.Web.UI.Page
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
    protected void canc_Click(object sender, EventArgs e)
    {
        DateTime dt1,dt2;
        string dt;
        string tarid = "0";
        int s;
        
        dt1 = System.DateTime.Now;
        cmd = new SqlCommand("select * from Tarif where planno='" + plnno.Text + "'", con);
        SqlDataReader dr;
        con.Open();
        dr = cmd.ExecuteReader();
        if (dr.Read() == true)
        {

            dt = dr[11].ToString();
            dt1 = Convert.ToDateTime(dt);
            tarid = dr[0].ToString();
        }
        con.Close();
        dt2=System.DateTime.Now;

        s = Convert.ToInt32(tarid);
        s = s + 0;
        tarid = s.ToString();



        if (dt2 < dt1)
        {
            Label2.Text = "Offer validity is not completed";
            Label2.Visible = true;

        }

            
        else
        {
            Label2.Visible = false;
            string curdate = System.DateTime.Now.ToString();
            int adate = Convert.ToInt32(TextBox2.Text);
            string avdate = System.DateTime.Now.AddDays(adate).ToString();

            int ldate = Convert.ToInt32(TextBox3.Text);
            string lvdate = System.DateTime.Now.AddDays(adate + ldate).ToString();
            cmd = new SqlCommand("update Tarif set state='" + TextBox5.Text + "', ctype='" + TextBox6.Text + "',cost='" + cst0.Text + "',amountrecharge='" + TextBox1.Text + "',offerdays='" + TextBox3.Text + "',startingofferdate='" + curdate + "',endingofferdate='" + avdate + "',lastvaliditydate='" + lvdate + "'where planno='" + plnno.Text + "' and tarid='"+tarid+"'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            s = Convert.ToInt32(tarid);
            s = s + 1;
            tarid = s.ToString();

            cmd = new SqlCommand("update Tarif set state='" + TextBox5.Text + "', ctype='" + TextBox6.Text + "',cost='" + cst1.Text + "',amountrecharge='" + TextBox1.Text + "',offerdays='" + TextBox3.Text + "',startingofferdate='" + curdate + "',endingofferdate='" + avdate + "',lastvaliditydate='" + lvdate + "'where planno='" + plnno.Text + "' and tarid='" + tarid + "'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            s = Convert.ToInt32(tarid);
            s = s + 1;
            tarid = s.ToString();

            cmd = new SqlCommand("update Tarif set state='" + TextBox5.Text + "', ctype='" + TextBox6.Text + "',cost='" + cst2.Text + "',amountrecharge='" + TextBox1.Text + "',offerdays='" + TextBox3.Text + "',startingofferdate='" + curdate + "',endingofferdate='" + avdate + "',lastvaliditydate='" + lvdate + "'where planno='" + plnno.Text + "' and tarid='" + tarid + "'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
    protected void ok_Click(object sender, EventArgs e)
    {
        string tarid="0";
        int t;
        cmd = new SqlCommand("select * from Tarif where planno='" + plnno.Text + "'", con);
        SqlDataReader dr;
        con.Open();
        dr = cmd.ExecuteReader();
        if (dr.Read() == true)
        {
            
            TextBox5.Text=dr[1].ToString();
            TextBox6.Text=dr[2].ToString();
            cst0.Text = dr[5].ToString();
            tarid = dr[0].ToString();
            

        }
        con.Close();
        t = Convert.ToInt32(tarid);
        t = t + 1;
        tarid = t.ToString();

        cmd = new SqlCommand("select * from Tarif where planno='" + plnno.Text + "' and tarid='"+tarid+"'", con);
        SqlDataReader dx;
        con.Open();
        dx = cmd.ExecuteReader();
        if (dx.Read() == true)
        {

            
            cst1.Text = dx[5].ToString();
            tarid = dx[0].ToString();


        }
        con.Close();

        t = Convert.ToInt32(tarid);
        t = t + 1;
        tarid = t.ToString();

        cmd = new SqlCommand("select * from Tarif where planno='" + plnno.Text + "' and tarid='" + tarid + "'", con);
        SqlDataReader du;
        con.Open();
        du = cmd.ExecuteReader();
        if (du.Read() == true)
        {


            cst2.Text = du[5].ToString();
            tarid = du[0].ToString();


        }
        con.Close();


    }
    protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        TextBox5.Text=RadioButtonList1.Text ;
    }
    protected void RadioButtonList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        TextBox6.Text = RadioButtonList2.Text;
    }
}