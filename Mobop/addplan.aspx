<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage1.master" AutoEventWireup="true" CodeFile="addplan.aspx.cs" Inherits="addplan" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style2
        {
            width: 100%;
        }
        .style6
        {
            width: 129px;
        }
        .style7
        {
            width: 213px;
        }
        .style8
        {
            width: 196px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        <br />
        <table class="style2">
            <tr>
                <td bgcolor="#000099" style="font-size: large; color: #FFFFFF">
                    Welcome&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="color: #800000">
                    * represent fields are compulsory</td>
            </tr>
        </table>
    </p>
    <table class="style2">
        <tr>
            <td class="style6">
&nbsp;Plan No:<asp:TextBox ID="plnno" runat="server" Width="47px"></asp:TextBox>
            </td>
            <td class="style7">
                Sub Plan:<asp:TextBox ID="sp0" runat="server" ReadOnly="True" Width="45px">local</asp:TextBox>
            </td>
            <td class="style8">
                Cost:&nbsp;&nbsp;
                <asp:TextBox ID="cst0" runat="server" Width="83px"></asp:TextBox>
                <asp:RangeValidator ID="RangeValidator1" runat="server" 
                    ControlToValidate="cst0" ErrorMessage="0.0-0.9" MaximumValue="0.9" 
                    MinimumValue="0.0"></asp:RangeValidator>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="cst0" ErrorMessage="*"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="style6">
                <asp:RadioButtonList ID="RadioButtonList1" runat="server" Width="180px">
                    <asp:ListItem>AndhraPradesh</asp:ListItem>
                    <asp:ListItem>Other</asp:ListItem>
                </asp:RadioButtonList>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                    ControlToValidate="RadioButtonList1" ErrorMessage="*"></asp:RequiredFieldValidator>
            </td>
            <td class="style7">
                Sub Plan:<asp:TextBox ID="sp1" runat="server" ReadOnly="True" Width="46px">STD</asp:TextBox>
            </td>
            <td class="style8">
                Cost:&nbsp;&nbsp;
                <asp:TextBox ID="cst1" runat="server" Width="85px"></asp:TextBox>
                <asp:RangeValidator ID="RangeValidator2" runat="server" 
                    ControlToValidate="cst1" ErrorMessage="0.0-0.9" MaximumValue="0.9" 
                    MinimumValue="0.0"></asp:RangeValidator>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                    ControlToValidate="cst1" ErrorMessage="*"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="style6">
                <asp:RadioButtonList ID="RadioButtonList2" runat="server">
                    <asp:ListItem>prepaid</asp:ListItem>
                    <asp:ListItem>postpaid</asp:ListItem>
                </asp:RadioButtonList>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                    ControlToValidate="RadioButtonList2" ErrorMessage="*"></asp:RequiredFieldValidator>
            </td>
            <td class="style7">
                Sub Plan:<asp:TextBox ID="sp2" runat="server" ReadOnly="True" Width="50px">ISD</asp:TextBox>
            </td>
            <td class="style8">
                Cost:&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="cst2" runat="server" Width="82px"></asp:TextBox>
                <asp:RangeValidator ID="RangeValidator3" runat="server" 
                    ControlToValidate="cst2" ErrorMessage="0.0-0.9" MaximumValue="0.9" 
                    MinimumValue="0.0"></asp:RangeValidator>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                    ControlToValidate="cst2" ErrorMessage="*"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="style6">
                &nbsp;&nbsp; Amount:<asp:TextBox ID="TextBox1" runat="server" Width="56px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                    ControlToValidate="TextBox1" ErrorMessage="*"></asp:RequiredFieldValidator>
            </td>
            <td class="style7">
                Offer Availability:
                <asp:TextBox ID="TextBox2" runat="server" Width="28px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
                    ControlToValidate="TextBox2" ErrorMessage="*"></asp:RequiredFieldValidator>
                (in days)</td>
            <td class="style8">
                Offer Validity:
                <asp:TextBox ID="TextBox3" runat="server" Width="36px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" 
                    ControlToValidate="TextBox3" ErrorMessage="*"></asp:RequiredFieldValidator>
                (in days)</td>
        </tr>
        <tr>
            <td class="style6">
                &nbsp;</td>
            <td class="style7">
                &nbsp;</td>
            <td class="style8">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style6">
                &nbsp;</td>
            <td class="style7">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="submt" runat="server" onclick="submt_Click" Text="Submit" />
                &nbsp;</td>
            <td class="style8">
                <asp:Label ID="Label2" runat="server" Text="Label" Visible="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style6" style="color: #FF0000">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Note:</td>
            <td class="style7" style="color: #FF0000">
                &nbsp; Cost is per second<br />
                and which is in form
                <br />
&nbsp;&nbsp;&nbsp; 0.01(1 paise)&nbsp;</td>
            <td style="color: #FF0000" class="style8">
                Amount in rupees how much customer recharge for this plan.</td>
        </tr>
    </table>
</asp:Content>

