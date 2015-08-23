<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage1.master" AutoEventWireup="true" CodeFile="updateplan.aspx.cs" Inherits="updateplan" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
            width: 100%;
        }
        .style7
        {
            width: 213px;
        }
        .style8
        {
            width: 196px;
        }
        .style9
        {
            width: 198px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        <br />
        <table class="style1">
            <tr>
                <td bgcolor="#000099" style="color: #FFFFFF; font-size: large">
                    Welcome&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <br />
    <table class="style2">
        <tr>
            <td class="style9">
                Enter Plan No:<asp:TextBox ID="plnno" runat="server" 
                    Width="47px"></asp:TextBox>
            &nbsp;<asp:Button ID="ok" runat="server" onclick="ok_Click" Text="Ok" 
                    Width="37px" />
&nbsp;</td>
            <td class="style7">
                Sub Plan:<asp:TextBox ID="sp0" runat="server" ReadOnly="True" Width="45px">local</asp:TextBox>
            </td>
            <td class="style8">
                Cost:&nbsp;&nbsp;
                <asp:TextBox ID="cst0" runat="server" Width="83px"></asp:TextBox>
                <asp:RangeValidator ID="RangeValidator1" runat="server" 
                    ControlToValidate="cst0" ErrorMessage="0.0-0.9" MaximumValue="0.9" 
                    MinimumValue="0.0"></asp:RangeValidator>
            </td>
        </tr>
        <tr>
            <td class="style9">
                <asp:RadioButtonList ID="RadioButtonList1" runat="server" Width="180px" 
                    onselectedindexchanged="RadioButtonList1_SelectedIndexChanged">
                    <asp:ListItem>AndhraPradesh</asp:ListItem>
                    <asp:ListItem>Other</asp:ListItem>
                </asp:RadioButtonList>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox5" runat="server" Width="119px"></asp:TextBox>
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
            </td>
        </tr>
        <tr>
            <td class="style9">
                <asp:RadioButtonList ID="RadioButtonList2" runat="server" 
                    onselectedindexchanged="RadioButtonList2_SelectedIndexChanged">
                    <asp:ListItem>prepaid</asp:ListItem>
                    <asp:ListItem>postpaid</asp:ListItem>
                </asp:RadioButtonList>
            &nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox6" runat="server" Width="112px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
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
            </td>
        </tr>
        <tr>
            <td class="style9">
                &nbsp;&nbsp; Amount:<asp:TextBox ID="TextBox1" runat="server" Width="56px"></asp:TextBox>
            </td>
            <td class="style7">
                Offer Availability:
                <asp:TextBox ID="TextBox2" runat="server" Width="28px"></asp:TextBox>
                (in days)</td>
            <td class="style8">
                Offer Validity:
                <asp:TextBox ID="TextBox3" runat="server" Width="36px"></asp:TextBox>
                (in days)</td>
        </tr>
        <tr>
            <td class="style9">
                &nbsp;</td>
            <td class="style7">
                &nbsp;</td>
            <td class="style8">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style9">
                &nbsp;</td>
            <td class="style7">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="canc" runat="server" onclick="canc_Click" Text="Update" />
                &nbsp;</td>
            <td class="style8">
                <asp:Label ID="Label2" runat="server" Text="Label" Visible="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style9" style="color: #FF0000">
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
                </td>
            </tr>
        </table>
    </p>
</asp:Content>

