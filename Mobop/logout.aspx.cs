using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

public partial class logout : System.Web.UI.Page
{
       

private void Page_Load(object sender, System.EventArgs e)
{
    // Put user code to initialize the page here
    Session.Abandon();
    FormsAuthentication.SignOut();
   
}
    }
