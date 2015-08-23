<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage1.master" AutoEventWireup="true" CodeFile="admin.aspx.cs" Inherits="admin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
            width: 280px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="style1">
        <tr>
            <td bgcolor="#000099" class="style2">
                &nbsp;</td>
            <td bgcolor="#000099" 
                style="font-family: 'Times New Roman', Times, serif; font-size: x-large; color: #FFFFFF">
                Welcome&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </td>
        </tr>
        <tr>
            <td bgcolor="#000099" class="style2">
                &nbsp;</td>
            <td bgcolor="#000099">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
    <br />
    <br />
    <asp:Button ID="ademp" runat="server" onclick="ademp_Click" Text="Add Employ" 
        Width="118px" />
    <br />
    <br />
    <br />
    <asp:Button ID="deact" runat="server" Text="Deactivate Employ" Width="116px" 
        onclick="deact_Click" />
    <br />
    <br />
    <br />
    <asp:Button ID="vemp" runat="server" Text="View Employ" onclick="vemp_Click" />
    <br />
    <br />
    <br />
    <asp:Button ID="upemp" runat="server" Text="Update Employ" Width="112px" 
        onclick="upemp_Click" />
    <br />
    <br />
</asp:Content>

