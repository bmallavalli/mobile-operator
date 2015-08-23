using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;


public partial class empreg : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Server=localhost;Integrated Security=true;Initial Catalog=Bavi");
    SqlCommand cmd;
    protected void Page_Load(object sender, EventArgs e)
    {
        Label2.Text = Session["uname"].ToString();
        Response.Expires = -1;
        Response.Cache.SetNoServerCaching();
        Response.Cache.SetAllowResponseInBrowserHistory(false);
        Response.CacheControl = "no-cache";
        Response.Cache.SetNoStore();


        cmd = new SqlCommand("select * from mobadmin where userid= '" + Label2.Text + "'", con);
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


        doj.Text = System.DateTime.Now.ToString();

        string regno = "0";

        cmd = new SqlCommand("select count(*) from mobemp", con);
        SqlDataReader dr;
        con.Open();
        dr = cmd.ExecuteReader();
        if (dr.Read() == true)
        {
            regno = dr[0].ToString();
        }
        con.Close();

        empid.Text = (Convert.ToInt32(regno) + 1).ToString();

    }
    protected void canc_Click(object sender, EventArgs e)
    {
        Response.Redirect("empreg.aspx");
    }
    protected void btnUpload_Click(object sender, EventArgs e)
    {

        if (FileUpload1.PostedFile != null && FileUpload1.PostedFile.FileName != "")
        {
           

            byte[] imageSize = new byte
                          [FileUpload1.PostedFile.ContentLength];
            HttpPostedFile uploadedImage = FileUpload1.PostedFile;
            uploadedImage.InputStream.Read
               (imageSize, 0, (int)FileUpload1.PostedFile.ContentLength);

            cmd = new SqlCommand("insert into mobemp values('" + empid.Text + "','" + name.Text + "','" + uid.Text + "','" + usid.Text + "','" + pswd.Text + "','" + dsg.Text + "','" + doj.Text + "','" + dob.Text + "','" + fadd.Text + "','" + mobno.Text + "','" + email.Text + "','" + wloc.Text + "',@Image,'none')", con);
           

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
                Label1.Text = "Image Uploaded & Registered Successfully";
            }

        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("admin.aspx");
    }
}