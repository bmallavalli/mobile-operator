<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage1.master" AutoEventWireup="true" CodeFile="empreg.aspx.cs" Inherits="empreg" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
            height: 46px;
        }
        .style3
        {
            width: 543px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="style1">
        <tr>
            <td style="font-family: 'Bell MT'; font-size: x-large; font-weight: bold; font-style: normal; color: #FFFFFF; height: 46px; width: 543px;" 
                class="title" bgcolor="#000099">
                &nbsp;&nbsp;&nbsp;&nbsp; Welcome&nbsp;
                <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                &nbsp;</td>
            <td class="style2" bgcolor="#000099">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="font-family: 'Bell MT'; font-size: x-large; font-weight: bold; font-style: normal; color: #660033; height: 46px; width: 543px;" 
                class="title">
                &nbsp;</td>
            <td class="style2">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="font-family: 'Bell MT'; font-size: x-large; font-weight: bold; font-style: normal; color: #660033; height: 46px; width: 543px;" 
                class="title">
                Employee Registration Form</td>
            <td class="style2">
                </td>
        </tr>
        <tr>
            <td style="font-family: 'Bell MT'; font-size: x-large; font-weight: bold; font-style: normal; color: #660033; height: 46px; width: 543px;" 
                class="title">
                <asp:Label ID="Label1" runat="server" Text="Label" Visible="False"></asp:Label>
            </td>
            <td class="style2">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="font-family: 'Bell MT'; font-size: medium; font-weight: bold; font-style: normal; color: #CC0066; height: 46px; width: 543px;" 
                class="title">
                * Represented fields are Mandatory </td>
            <td class="style2">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="font-family: 'Bell MT'; font-size: large; font-weight: bold; font-style: normal; color: #CC0000; height: 46px; width: 543px;" 
                class="title">
                Employee id</td>
            <td class="style2">
                <asp:TextBox ID="empid" runat="server" ReadOnly="True" Enabled="False">1</asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" 
                    ControlToValidate="empid" ErrorMessage="*"></asp:RequiredFieldValidator>
                </td>
        </tr>
        <tr>
            <td style="font-family: 'Bell MT'; font-size: large; font-weight: bold; font-style: normal; color: #CC0000" 
                class="style3">
                Full Name</td>
            <td>
                <asp:TextBox ID="name" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="name" ErrorMessage="*"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="font-family: 'Bell MT'; font-size: large; font-weight: bold; font-style: normal; color: #CC0000" 
                class="style3">
                UID</td>
            <td>
                <asp:TextBox ID="uid" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                    ControlToValidate="uid" ErrorMessage="RequiredFieldValidator">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="font-family: 'Bell MT'; font-size: large; font-weight: bold; font-style: normal; color: #CC0000" 
                class="style3">
                User Id</td>
            <td>
                <asp:TextBox ID="usid" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                    ControlToValidate="usid" ErrorMessage="*"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="font-family: 'Bell MT'; font-size: large; font-weight: bold; font-style: normal; color: #CC0000" 
                class="style3">
                Password</td>
            <td>
                <asp:TextBox ID="pswd" runat="server" TextMode="Password"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                    ControlToValidate="pswd" ErrorMessage="*"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="font-family: 'Bell MT'; font-size: large; font-weight: bold; font-style: normal; color: #CC0000" 
                class="style3">
                Confirm Password</td>
            <td>
                <asp:TextBox ID="cpswd" runat="server" TextMode="Password"></asp:TextBox>
                <asp:CompareValidator ID="CompareValidator1" runat="server" 
                    ControlToCompare="pswd" ControlToValidate="cpswd" ErrorMessage="must match"></asp:CompareValidator>
            </td>
        </tr>
        <tr>
            <td style="font-family: 'Bell MT'; font-size: large; font-weight: bold; font-style: normal; color: #CC0000" 
                class="style3">
                Designation</td>
            <td>
                <asp:TextBox ID="dsg" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                    ControlToValidate="dsg" ErrorMessage="*"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="font-family: 'Bell MT'; font-size: large; font-weight: bold; font-style: normal; color: #CC0000" 
                class="style3">
                Date Of Join</td>
            <td>
                <asp:TextBox ID="doj" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                    ControlToValidate="doj" ErrorMessage="*"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="font-family: 'Bell MT'; font-size: large; font-weight: bold; font-style: normal; color: #CC0000" 
                class="style3">
                Date Of Birth</td>
            <td>
                <asp:TextBox ID="dob" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="font-family: 'Bell MT'; font-size: large; font-weight: bold; font-style: normal; color: #CC0000" 
                class="style3">
                Full address</td>
            <td>
                <asp:TextBox ID="fadd" runat="server" TextMode="MultiLine"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
                    ControlToValidate="fadd" ErrorMessage="*"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="font-family: 'Bell MT'; font-size: large; font-weight: bold; font-style: normal; color: #CC0000" 
                class="style3">
                Mobile No</td>
            <td>
                <asp:TextBox ID="mobno" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" 
                    ControlToValidate="mobno" ErrorMessage="*"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                    ControlToValidate="mobno" ErrorMessage="10digits,start with 7-9" 
                    ValidationExpression="^[7-9]{1}[0-9]{9}$"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td style="font-family: 'Bell MT'; font-size: large; font-weight: bold; font-style: normal; color: #CC0000" 
                class="style3">
                Email Id</td>
            <td>
                <asp:TextBox ID="email" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="font-family: 'Bell MT'; font-size: large; font-weight: bold; font-style: normal; color: #CC0000" 
                class="style3">
                Work Location</td>
            <td>
                <asp:TextBox ID="wloc" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" 
                    ControlToValidate="wloc" ErrorMessage="*"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="font-family: 'Bell MT'; font-size: large; font-weight: bold; font-style: normal; color: #CC0000" 
                class="style3">
                Photo</td>
            <td>
                <asp:FileUpload ID="FileUpload1" runat="server" />
            </td>
        </tr>
        <tr>
            <td class="style3">
                <asp:Button ID="btnUpload" runat="server" Text="Save" BackColor="#FFFF99" 
                    ForeColor="#000099" onclick="btnUpload_Click" Width="85px" />
            </td>
            <td>
                <asp:Button ID="canc" runat="server" Text="Cancel" BackColor="#FF99FF" 
                    ForeColor="Red" onclick="canc_Click" />
                <br />
            </td>
        </tr>
        <tr>
            <td class="style3">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Back" />
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>

