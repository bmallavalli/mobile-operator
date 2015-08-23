using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class customer : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Server=localhost;Integrated Security=true;Initial Catalog=Bavi"); 
    SqlCommand cmd;
    
    protected void Page_Load(object sender, EventArgs e)
    {
       Label1.Text = Session["uname"].ToString();

        Response.Expires = -1;
Response.Cache.SetNoServerCaching();
Response.Cache.SetAllowResponseInBrowserHistory(false);
Response.CacheControl ="no-cache";
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




        cmd = new SqlCommand("select * from mobcust where userid='" + Label1.Text + "'", con);
        SqlDataReader dr;
        con.Open();
        dr = cmd.ExecuteReader();
        if (dr.Read() == true)
        {
            cid.Text = dr[0].ToString();
            sim.Text = dr[5].ToString();
            mobno.Text = dr[7].ToString();
            ctype.Text = dr[17].ToString();
            state.Text = dr[18].ToString();
            totbill.Text=dr[22].ToString();
            balamt.Text=dr[19].ToString();
            Statuss.Text=dr[20].ToString();
            
        }
        con.Close();

        if (ctype.Text == "prepaid")
        {
            bal.Visible = true;
            recharge.Visible = true;
         }

        if (ctype.Text == "postpaid")
            Button2.Visible = true;

        
    }
    
    
    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        tid.Text = DropDownList2.Text;
        tid.Visible = true;
        if (tid.Text == "call")
            Button1.Text = "start call";
        else if (tid.Text == "message")
        {
            Button1.Text = "Send message";
        }
        else if (tid.Text == "internet")
            Button1.Text = "start Internet";
        else if(tid.Text=="voicecall")
            Button1.Text = "start voicecall";

    }

    protected void Button1_Click(object sender, EventArgs e)
    {



        if (Statuss.Text == "activate")
        {
            //DateTime starttime=DateTime.Now;
            if (typeno.Text == "local" || typeno.Text == "STD" || typeno.Text == "ISD"|| typeno.Text=="none")
            {
                if (Button1.Text == "start call")
                {

                    cmd = new SqlCommand("select * from mobcust where userid='" + Label1.Text + "'", con);
                    SqlDataReader dr;
                    con.Open();
                    dr = cmd.ExecuteReader();
                    if (dr.Read() == true)
                    {

                        TextBox2.Text = dr[23].ToString();
                    }
                    con.Close();



                    if (typeno.Text != "none")
                    {
                        Button1.Text = "stop";
                        sttime.Text = System.DateTime.Now.ToString();
                        DateTime starttime = System.DateTime.Now;
                    }
                    else
                    {
                        TextBox1.Text = "select local/std/isd";
                        TextBox1.Visible = true;
                    }
                }
                else if (Button1.Text == "Send message")
                {

                    TextBox2.Text = "0";
                    if (typeno.Text != "none")
      
                    {                 Button1.Text = "send success";

                    if (Button1.Text == "send success")
                    {
                        duration.Text = "1";
                        

                        cmd = new SqlCommand("select * from Tarif where state='" + state.Text + "' and ctype='" + ctype.Text + "' and servtype='" + tid.Text + "' and calltype='" + typeno.Text + "' and planno='" + TextBox2.Text + "'", con);
                        SqlDataReader dr;
                        con.Open();
                        dr = cmd.ExecuteReader();
                        if (dr.Read() == true)
                        {
                            amount.Text = dr[5].ToString();
                            TextBox4.Text = dr[0].ToString();
                        }
                        con.Close();

                        bill.Text = (Convert.ToDouble(duration.Text) * Convert.ToDouble(amount.Text)).ToString();
                    }


                  if (Convert.ToDouble(duration.Text) >= 1 && Convert.ToDouble(bill.Text) > 0)
                    {
                        cmd = new SqlCommand("select * from mobcust where userid='" + Label1.Text + "'", con);
                        SqlDataReader dr;
                        con.Open();
                        dr = cmd.ExecuteReader();
                        if (dr.Read() == true)
                        {
                            totbill.Text = dr[22].ToString();
                        }
                        con.Close();

                        
                        double b = Convert.ToDouble(bill.Text);
                        double d = Convert.ToDouble(balamt.Text);
                        double c = Convert.ToDouble(totbill.Text);
                        if (ctype.Text == "postpaid")
                        {
                            totbill.Visible = true;
                            double a = b + c;
                            totbill.Text = a.ToString();
                            cmd = new SqlCommand("update mobcust set Bill='" + totbill.Text + "' where userid='" + Label1.Text + "'", con);
                            con.Open();
                           // cmd.CommandTimeout = 60; 
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }
                        else if (ctype.Text == "prepaid")
                        {
                            bal.Visible = true;
                            balamt.Visible = true;
                            recharge.Visible = true;
                            rechamt.Visible = true;
                            submit.Visible = true;
                            Label2.Visible = true;
                            double f = d - b;
                            balamt.Text = f.ToString();
                            cmd = new SqlCommand("update mobcust set Balance='" + balamt.Text + "' where userid='" + Label1.Text + "'", con);
                            con.Open();
                            //cmd.CommandTimeout = 60; 
                            cmd.ExecuteNonQuery();
                            con.Close();
                         }
                        //con.Open();
                        //cmd.ExecuteNonQuery();
                        //con.Close();

                    }
                }
                    else
                    {
                      TextBox1.Text = "select local/std/isd";
                    TextBox1.Visible = true;
                    }

                }

                else if (Button1.Text == "start Internet")
                {
                    TextBox2.Text = "0";
                    if (typeno.Text == "none")
                    {
                        Button1.Text = "stop";
                        sttime.Text = System.DateTime.Now.ToString();
                        DateTime starttime = System.DateTime.Now;
                    }
                    else
                    {
                        TextBox1.Text = "select local/std/isd";
                        Label5.Visible = true;
                    }
                }

                else if (Button1.Text == "start voicecall")
                {
                    TextBox2.Text = "0";
                    if (typeno.Text != "none")
                    {
                        Button1.Text = "stop";
                        sttime.Text = System.DateTime.Now.ToString();
                        DateTime starttime = System.DateTime.Now;
                    }
                    else
                        TextBox1.Visible = true;
                }



                if (Button1.Text == "stop")
                {
                    endtime.Text = System.DateTime.Now.ToString();
                    DateTime andtime = System.DateTime.Now;
                    TimeSpan span = andtime.Subtract(Convert.ToDateTime(sttime.Text));

                    duration.Text = span.TotalSeconds.ToString();
                    if (Convert.ToDouble(duration.Text) >= 1)
                    {
                        Button1.Text = "ended";

                        int k=Convert.ToInt32(TextBox2.Text);
                       
                            cmd = new SqlCommand("select * from Tarif where state='" + state.Text + "' and ctype='" + ctype.Text + "' and servtype='" + tid.Text + "' and calltype='" + typeno.Text + "' and planno='" + TextBox2.Text + "'", con);
                            SqlDataReader dr;
                            con.Open();
                            dr = cmd.ExecuteReader();
                            if (dr.Read() == true)
                            {
                                amount.Text = dr[5].ToString();
                                TextBox4.Text = dr[0].ToString();
                            }
                            con.Close();
                        
                        bill.Text = (Convert.ToDouble(duration.Text) * Convert.ToDouble(amount.Text)).ToString();
                    }


                    if (Convert.ToDouble(duration.Text) >= 1 && Convert.ToDouble(bill.Text) > 0)
                    {
                        cmd = new SqlCommand("select * from mobcust where userid='" + Label1.Text + "'", con);
                        SqlDataReader dr;
                        con.Open();
                        dr = cmd.ExecuteReader();
                        if (dr.Read() == true)
                        {
                            totbill.Text = dr[22].ToString();
                            TextBox7.Text=dr[24].ToString();
                        }
                        con.Close();


                        double b = Convert.ToDouble(bill.Text);
                        double d = Convert.ToDouble(balamt.Text);
                        double c = Convert.ToDouble(totbill.Text);
                        
                        if (ctype.Text == "postpaid")
                        {
                            totbill.Visible = true;



                            int k = Convert.ToInt32(TextBox2.Text);

                            if (k > 0)
                            {
                                DateTime dt1, dt2;
                                string dt = "0";
                                double h = Convert.ToDouble(TextBox7.Text);

                                dt1 = System.DateTime.Now;
                                dt2 = System.DateTime.Now;

                                cmd = new SqlCommand("select * from mobcust where userid='" + Label1.Text + "'", con);
                                SqlDataReader dp;
                                con.Open();
                                dp = cmd.ExecuteReader();
                                if (dp.Read() == true)
                                {

                                    dt = dp[25].ToString();
                                    dt1 = Convert.ToDateTime(dt);
                                }
                                con.Close();
                                double m = Convert.ToDouble(TextBox7.Text);
                                if (dt1 >= dt2 && m >= 0)
                                {
                                    TextBox7.Visible = true;
                                    double f = h - b;
                                    TextBox7.Text = f.ToString();
                                    cmd = new SqlCommand("update mobcust set offerbal='" + TextBox7.Text + "' where userid='" + Label1.Text + "'", con);
                                    con.Open();
                                    cmd.ExecuteNonQuery();
                                    con.Close();
                                }
                                if (dt1 < dt2 || m <= 0)
                                {
                                    cmd = new SqlCommand("update mobcust set planno=0,offerbal=NULL,lastdate=NULL  where userid='" + Label1.Text + "'", con);
                                    con.Open();
                                    cmd.ExecuteNonQuery();
                                    con.Close();
                                }

                            }
                            double a = b + c;
                            totbill.Text = a.ToString();
                            cmd = new SqlCommand("update mobcust set Bill='" + totbill.Text + "' where userid='" + Label1.Text + "'", con);
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }
                        else if (ctype.Text == "prepaid")
                        {
                            int k = Convert.ToInt32(TextBox2.Text);
                            
                            if (k > 0)
                            { 
                            DateTime dt1, dt2;
                            string dt = "0";
                            double h = Convert.ToDouble(TextBox7.Text);

                            dt1 = System.DateTime.Now;
                            dt2 = System.DateTime.Now;

                            cmd = new SqlCommand("select * from mobcust where userid='"+Label1.Text+"'", con);
                            SqlDataReader dp;
                             con.Open();
                            dp = cmd.ExecuteReader();
                            if (dp.Read() == true)
                            {
                                
                                dt = dp[25].ToString();
                                dt1 = Convert.ToDateTime(dt);
                            }
                            con.Close();

                            bal.Visible = true;
                            balamt.Visible = true;

                            
                            double m = Convert.ToDouble(TextBox7.Text);
                            if (dt1 >= dt2 && m>=0)
                            {
                               TextBox7.Visible = true;
                               double f=h-b;
                               TextBox7.Text = f.ToString();
                               cmd = new SqlCommand("update mobcust set offerbal='" + TextBox7.Text + "' where userid='" + Label1.Text + "'", con);
                               con.Open();
                               cmd.ExecuteNonQuery();
                               con.Close();
                            }
                            if (dt1 < dt2 || m<=0)
                            {
                                cmd = new SqlCommand("update mobcust set planno=0,offerbal=NULL,lastdate=NULL  where userid='" + Label1.Text + "'", con);
                                con.Open();
                                cmd.ExecuteNonQuery();
                                con.Close();
                            }

                        }
                            if (k == 0)
                            {
                                double f = d - b;
                                balamt.Text = f.ToString();
                                cmd = new SqlCommand("update mobcust set Balance='" + balamt.Text + "' where userid='" + Label1.Text + "'", con);
                                con.Open();
                                cmd.ExecuteNonQuery();
                                con.Close();
                            }


                        }

                    }


                }


            }
            else
            {
                TextBox1.Visible = true;
                TextBox1.Text = "select local/std/isd";

            }
        }

        else
        {
            Label3.Visible = true;
            Label3.ForeColor = System.Drawing.Color.Red;
            Label3.Text = "Not Yet Activated";
        }
    }



    protected void bal_Click(object sender, EventArgs e)
    {

        balamt.Visible = true;

        cmd = new SqlCommand("select * from mobcust where userid='" + Label1.Text + "'", con);
        SqlDataReader dr;
        con.Open();
        dr = cmd.ExecuteReader();
        if (dr.Read() == true)
        {
            balamt.Text = dr[19].ToString();
        }
        con.Close();

    }
    protected void recharge_Click(object sender, EventArgs e)
    {
        rechamt.Visible = true;
        TextBox5.Visible = true;
        submit.Visible = true;
    }
    protected void submit_Click(object sender, EventArgs e)
    {
        int v=-1,l=0;
        DateTime dt1, dt2;
        string dt="0";

        dt1 = System.DateTime.Now;
        dt2 = System.DateTime.Now;
        if (TextBox5.Text != "planno")
            v = Convert.ToInt32(TextBox5.Text);
        else
            Label6.Visible = true;
        if (v > -1)
        {
            
            cmd = new SqlCommand("select * from Tarif where planno='"+TextBox5.Text+"'", con);
            SqlDataReader dr;
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read() == true)
            {
                if (v > 0)
                {
                    dt = dr[9].ToString();
                    dt1 = Convert.ToDateTime(dt);


                    if (state.Text == dr[1].ToString() && ctype.Text == dr[2].ToString() && rechamt.Text == dr[7].ToString() && dt1 >= dt2)
                    {
                        l = 1;
                        Label2.Visible = false;
                    }
                    else if (dt1 < dt2)
                    {
                        Label2.Text = "Offer is not apply for u, check offers once";
                        Label2.Visible = true;
                    }
                }
                else if (dr[6].ToString() == "0")
                {
                    l = 2;
                    Label2.Visible = false;
                }

                
                else
                {
                    Label2.Text = "Offer is not apply for u, check offers once";
                    Label2.Visible = true;
                }
            }
            con.Close();
        }
        if (l==2)
        {
            double b = Convert.ToDouble(rechamt.Text);
            double c = Convert.ToDouble(balamt.Text);
            double a = b + c;
            balamt.Text = a.ToString();
            cmd = new SqlCommand("update mobcust set Balance='" + balamt.Text + "'  where userid='" + Label1.Text + "'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Label2.ForeColor = System.Drawing.Color.Green;
            Label2.Text = "Recharged Successfully";
            Label2.Visible = true;
        }

        if (l == 1)
        {
            cmd = new SqlCommand("update mobcust set offerbal='" + rechamt.Text + "',lastdate='" + dt + "',planno='" + TextBox5.Text + "' where userid='" + Label1.Text + "'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Label2.ForeColor = System.Drawing.Color.Green;
            Label2.Text = "Recharged Successfully";
            Label2.Visible = true;
        }
    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        typeno.Text = DropDownList1.Text;
        if (tid.Text == "internet" && typeno.Text != "none")
            Label5.Visible = true;
        else
            Label5.Visible = false;
        typeno.Visible = true;
        
        
    }


    protected void cpswd_Click(object sender, EventArgs e)
    {
        npswd.Visible = true;
        submt.Visible = true;
    }
    protected void submt_Click(object sender, EventArgs e)
    {
        cmd = new SqlCommand("update mobcust set password='" + npswd.Text + "'where userid='"+ Label1.Text +"'", con);
        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();
        Label4.Visible = true;
        Label4.ForeColor = System.Drawing.Color.Green;
        Label4.Text = "changed Successfully";
    }
    protected void offr_Click(object sender, EventArgs e)
    {
        Response.Redirect("Offers.aspx");
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        int v = 0, l = 0;
        DateTime dt1, dt2;
        string dt = "0";

        dt1 = System.DateTime.Now;
        dt2 = System.DateTime.Now;
        if (TextBox6.Text != "planno")
            v = Convert.ToInt32(TextBox6.Text);
        else
            Label6.Visible = true;
        if (v > 0)
        {

            cmd = new SqlCommand("select * from Tarif where planno='" + TextBox6.Text + "'", con);
            SqlDataReader dr;
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read() == true)
            {


                dt = dr[9].ToString();
                dt1 = Convert.ToDateTime(dt);


                if (state.Text == dr[1].ToString() && ctype.Text == dr[2].ToString() && TextBox8.Text == dr[7].ToString() && dt1 >= dt2)
                {
                    l = 1;
                    Label2.Visible = false;
                }
                
                else
                {
                    Label2.Text = "Offer is not apply for u, check offers once";
                    Label2.Visible = true;
                }
            }
            con.Close();
        }

        if (l == 1)
        {
            cmd = new SqlCommand("update mobcust set offerbal='" + TextBox8.Text + "',lastdate='" + dt + "',planno='" + TextBox6.Text + "' where userid='" + Label1.Text + "'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Label2.ForeColor = System.Drawing.Color.Green;
            Label2.Text = "Recharged Successfully";
            Label2.Visible = true;
        }
    }


    protected void Button2_Click(object sender, EventArgs e)
    {
        TextBox6.Visible = true;
        TextBox8.Visible = true;
        Button3.Visible = true;
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        TextBox7.Visible = true;
        cmd = new SqlCommand("select * from mobcust where userid='" + Label1.Text + "'", con);
        SqlDataReader dr;
        con.Open();
        dr = cmd.ExecuteReader();
        if (dr.Read() == true)
        {
            TextBox7.Text = dr[24].ToString();
        }
        con.Close();
    }
}



