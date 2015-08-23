<%@ WebHandler Language="C#" Class="Handler" %>

using System;
using System.Web;
using System.Configuration;
using System.IO;
using System.Data;
using System.Data.SqlClient;
 

public class Handler : IHttpHandler {
    
    public void ProcessRequest (HttpContext context) {

        Int32 pid;
        if (context.Request.QueryString["ID"] != null)
            pid = Convert.ToInt32(context.Request.QueryString["ID"]);
        else
            throw new ArgumentException("No parameter specified");

        //context.Response.ContentType = "image/jpeg";
        Stream strm = ShowEmpImage(pid);
        byte[] buffer = new byte[4096];
        int byteSeq = strm.Read(buffer, 0, 4096);

        while (byteSeq > 0)
        {
            context.Response.OutputStream.Write(buffer, 0, byteSeq);
            byteSeq = strm.Read(buffer, 0, 4096);
        }       
        
        context.Response.ContentType = "text/plain";
        context.Response.Write("Hello World");
    }



    public Stream ShowEmpImage(Int32 pid)
    {
        //string conn = ConfigurationManager.ConnectionStrings["EmployeeConnString"].ConnectionString;
        //SqlConnection connection = new SqlConnection(conn);
        SqlConnection con = new SqlConnection("Server=localhost;Integrated Security=true;Initial Catalog=Bavi");
        string sql = "SELECT Image FROM Images WHERE ID = @ID";
        SqlCommand cmd = new SqlCommand(sql, con);
        cmd.CommandType = CommandType.Text;
        cmd.Parameters.AddWithValue("@ID", pid);
        con.Open();
        object img = cmd.ExecuteScalar();
        try
        {
            return new MemoryStream((byte[])img);
        }
        catch
        {
            return null;
        }
        finally
        {
            con.Close();
        }
    }
    
    
    public bool IsReusable {
        get {
            return false;
        }
    }

}