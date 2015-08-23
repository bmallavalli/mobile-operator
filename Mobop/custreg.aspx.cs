using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Collections;

public partial class custreg : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Server=localhost;Integrated Security=true;Initial Catalog=Bavi");
    SqlCommand cmd;
    
    protected void Page_Load(object sender, EventArgs e)
    {

        string regno = "0";
        TextBox13.Text = System.DateTime.Now.ToString();
        TextBox14.Text = System.DateTime.Now.AddYears(20).ToString();

        cmd = new SqlCommand("select count(*) from mobcust", con);
        SqlDataReader dr;
        con.Open();
        dr = cmd.ExecuteReader();
        if (dr.Read() == true)
        {
            regno = dr[0].ToString();
        }
        con.Close();

        TextBox6.Text = (Convert.ToInt32(regno) + 1).ToString();
    }
    protected void sbmt_Click(object sender, EventArgs e)
    {

        int x = 0;
            if (FileUpload1.PostedFile != null && FileUpload1.PostedFile.FileName != "" )
            {


                byte[] imageSize = new byte
                              [FileUpload1.PostedFile.ContentLength];
                HttpPostedFile uploadedImage = FileUpload1.PostedFile;
                uploadedImage.InputStream.Read
                   (imageSize, 0, (int)FileUpload1.PostedFile.ContentLength);


                string simno = "0";
                cmd = new SqlCommand("select count(*) from mobcust", con);
                SqlDataReader dr;
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read() == true)
                {
                    simno = dr[0].ToString();
                }
                con.Close();

                TextBox16.Text = (Convert.ToInt32(simno) + 893573221008).ToString();


                cmd = new SqlCommand("select * from Aadhar where Uid='" + TextBox2.Text + "'", con);
                SqlDataReader d;
                
                con.Open();
                d = cmd.ExecuteReader();
                if (d.Read() == true)
                {
                    
                    if (TextBox1.Text == d[1].ToString() && TextBox7.Text==d[4].ToString())
                    {
                        x = 1;
                        
                        
                    }
                   

                }

               
               
                con.Close();



                if (x > 0 && Label4.Text == "UserName Available")
                {
                    cmd = new SqlCommand("insert into mobcust values('" + TextBox6.Text + "','" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox16.Text + "','" + TextBox7.Text + "','" + TextBox8.Text + "','" + TextBox9.Text + "','" + TextBox10.Text + "','" + DropDownList1.Text + "','" + TextBox11.Text + "','" + DropDownList2.Text + "','" + TextBox12.Text + "','" + TextBox13.Text + "','" + TextBox14.Text + "','" + TextBox15.Text + "','" + RadioButtonList1.Text + "','" + DropDownList3.Text + "',0,'none',@Image,0,0,NULL,NULL)", con);


                    SqlParameter UploadedImage = new SqlParameter
                                  ("@Image", SqlDbType.Image, imageSize.Length);
                    UploadedImage.Value = imageSize;
                    cmd.Parameters.Add(UploadedImage);
                    con.Open();
                    int result = cmd.ExecuteNonQuery();
                    con.Close();
                    if (result > 0)
                    {
                        Label1.Visible = true;
                        Label1.ForeColor = System.Drawing.Color.Green;
                        Label1.Text = "Image Uploaded & Registered Successfully";
                        Label2.Visible = true;
                        Label2.Text = "Sim no is:";
                        TextBox16.Visible = true;
                    }
                    Label4.Visible = false;
                    Label3.Visible = false;

                }
                else if (x != 1)
                {
                    Label3.Visible = true;
                    Label3.ForeColor = System.Drawing.Color.Red;
                    Label3.Text = "invalid Aadhar details";
                }

                else
                {
                    Label4.ForeColor = System.Drawing.Color.Brown;
                    Label4.Text = "User name not Available";
                    Label3.Visible = false;
                }
            }

            
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("home.aspx");
    }



    protected void TextBox3_TextChanged(object sender, EventArgs e)
    {
        cmd = new SqlCommand("select * from mobcust where userid= '"+TextBox3.Text+"'",con);
        
        con.Open();
        SqlDataReader dr = cmd.ExecuteReader();
             if (dr.HasRows)
                  {
                     Label4.Visible = true;
                     Label4.Text="UserName not Available";
                  }
                        else
                         {
                          Label4.Visible = true;
                          Label4.Text="UserName Available";
                         }
             con.Close();

}
    }
