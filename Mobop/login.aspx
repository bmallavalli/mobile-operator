<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .style1
    {
        width: 100%;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="style1">
    <tr>
        <td>
            &nbsp;</td>
        <td>
            <asp:DropDownList ID="cust_emp" runat="server" 
                onselectedindexchanged="cust_emp_SelectedIndexChanged">
                <asp:ListItem>select customer/employ/admin</asp:ListItem>
                <asp:ListItem>Customer</asp:ListItem>
                <asp:ListItem>Employee</asp:ListItem>
                <asp:ListItem>Admin</asp:ListItem>
            </asp:DropDownList>
            <asp:Label ID="Label2" runat="server" Text="Label" Visible="False"></asp:Label>
        </td>
    </tr>
    <tr>
        <td style="font-family: 'Times New Roman', Times, serif; font-size: large; font-weight: bold; color: #FF9966">
            User Id</td>
        <td>
            <asp:TextBox ID="usid" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="font-family: 'Times New Roman', Times, serif; font-size: large; font-weight: bold; color: #FF9966">
            Password</td>
        <td>
            <asp:TextBox ID="pswd" runat="server" TextMode="Password"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
        <td>
            <asp:Label ID="Label1" runat="server" Text="Label" Visible="False"></asp:Label>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Button ID="loginbut" runat="server" Text="login" 
                onclick="loginbut_Click" />
        </td>
        <td>
            <asp:Button ID="elled" runat="server" Text="Cancel" onclick="elled_Click" />
        </td>
    </tr>
</table>
</asp:Content>

