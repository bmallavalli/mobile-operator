<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage1.master" AutoEventWireup="true" CodeFile="empupdate.aspx.cs" Inherits="empupdate" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
            width: 138px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="style1">
        <tr>
            <td class="style2" bgcolor="#000099">
                &nbsp;</td>
            <td bgcolor="#000099" style="color: #FFFFFF">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Welcome&nbsp;&nbsp;
                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                Employ id</td>
            <td>
                <asp:TextBox ID="empid" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Enter" />
            </td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                Name</td>
            <td>
                <asp:TextBox ID="name" runat="server" ReadOnly="True"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style2">
                UID</td>
            <td>
                <asp:TextBox ID="uid" runat="server" ReadOnly="True"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style2">
                Mobile No</td>
            <td>
                <asp:TextBox ID="mobno" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style2">
                Email</td>
            <td>
                <asp:TextBox ID="mail" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style2">
                Worklocation</td>
            <td>
                <asp:TextBox ID="wloc" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style2">
                Address</td>
            <td>
                <asp:TextBox ID="adrs" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;</td>
            <td>
                <asp:Button ID="updt" runat="server" onclick="updt_Click" Text="Update" />
            </td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;</td>
            <td>
                <asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="Back" />
            </td>
        </tr>
    </table>
</asp:Content>

