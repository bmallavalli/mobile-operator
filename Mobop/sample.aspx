<%@ Page Language="C#" AutoEventWireup="true" CodeFile="sample.aspx.cs" Inherits="sample" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    
    </div>
    <asp:TextBox ID="TextBox1" runat="server">Andhra Pradesh</asp:TextBox>
    <br />
    <asp:TextBox ID="TextBox2" runat="server">postpaid</asp:TextBox>
    <br />
    <asp:TextBox ID="TextBox3" runat="server">call</asp:TextBox>
    <br />
    <asp:TextBox ID="TextBox4" runat="server">std</asp:TextBox>
    <br />
    <asp:TextBox ID="TextBox5" runat="server">0</asp:TextBox>
    <br />
    <asp:TextBox ID="TextBox6" runat="server">0</asp:TextBox>
    <br />
    cost:<asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Click" />
    </form>
</body>
</html>
