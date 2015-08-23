<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage1.master" AutoEventWireup="true" CodeFile="customer.aspx.cs" Inherits="customer" %>

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
        <td bgcolor="#000099">
            &nbsp;</td>
        <td bgcolor="#000099" 
            
            style="font-family: 'Times New Roman', Times, serif; font-size: x-large; color: #FFFFFF">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
            Welcome&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
    </tr>
    <tr>
        <td bgcolor="#000099">
            &nbsp;</td>
        <td bgcolor="#000099">
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
        <td>
            <asp:Label ID="Label3" runat="server" Text="Label" Visible="False"></asp:Label>
        </td>
    </tr>
    <tr>
        <td>
            Transaction Id</td>
        <td>
            <asp:TextBox ID="tid" runat="server" ReadOnly="True" Width="22%" 
                Visible="False"></asp:TextBox>
            <asp:DropDownList ID="DropDownList2" runat="server" 
                onselectedindexchanged="DropDownList2_SelectedIndexChanged">
                <asp:ListItem Value="select call/msg/internet/voicecall">select call/msg/internet/voicecall</asp:ListItem>
                <asp:ListItem Value="call">call</asp:ListItem>
                <asp:ListItem Value="message">message</asp:ListItem>
                <asp:ListItem Value="voicecall">voicecall</asp:ListItem>
                <asp:ListItem Value="internet">internet</asp:ListItem>
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td>
            Customer Id</td>
        <td>
            <asp:TextBox ID="cid" runat="server" ReadOnly="True"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            Sim Number</td>
        <td>
            <asp:TextBox ID="sim" runat="server" ReadOnly="True"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </td>
    </tr>
    <tr>
        <td>
            Mobile Number</td>
        <td>
            <asp:TextBox ID="mobno" runat="server" ReadOnly="True"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </td>
    </tr>
    <tr>
        <td>
            Status</td>
        <td>
            <asp:TextBox ID="Statuss" runat="server" ReadOnly="True"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </td>
    </tr>
    <tr>
        <td>
            Customer Type</td>
        <td>
            <asp:TextBox ID="ctype" runat="server" ReadOnly="True"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox4" runat="server" Width="37px"></asp:TextBox>
            </td>
    </tr>
    <tr>
        <td>
            State</td>
        <td>
            <asp:TextBox ID="state" runat="server" ReadOnly="True"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </td>
    </tr>
    <tr>
        <td>
            Plan no</td>
        <td>
            <asp:TextBox ID="TextBox2" runat="server" ReadOnly="True"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            Service Type</td>
        <td>
            <asp:DropDownList ID="DropDownList1" runat="server" 
                onselectedindexchanged="DropDownList1_SelectedIndexChanged" 
                AutoPostBack="True">
                <asp:ListItem>select local/std/isd</asp:ListItem>
                <asp:ListItem Value="local">local</asp:ListItem>
                <asp:ListItem Value="STD">STD</asp:ListItem>
                <asp:ListItem Value="ISD">ISD</asp:ListItem>
                <asp:ListItem>none</asp:ListItem>
            </asp:DropDownList>
            &nbsp;&nbsp;
            <asp:TextBox ID="typeno" runat="server" ReadOnly="True" Width="13%" 
                Visible="False"></asp:TextBox>
            &nbsp;<asp:Label ID="Label5" runat="server" Text="Please select none for Internet " 
                Visible="False"></asp:Label>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Button ID="Button1" runat="server" Text="Button" onclick="Button1_Click" />
        </td>
        <td>
            <asp:TextBox ID="TextBox1" runat="server" ReadOnly="True" Visible="False"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            Startup Time</td>
        <td>
            <asp:TextBox ID="sttime" runat="server" ReadOnly="True"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            End Time</td>
        <td>
            <asp:TextBox ID="endtime" runat="server" ReadOnly="True"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </td>
    </tr>
    <tr>
        <td>
            Duration</td>
        <td>
            <asp:TextBox ID="duration" runat="server" ReadOnly="True"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </td>
    </tr>
    <tr>
        <td>
            Cost</td>
        <td>
            <asp:TextBox ID="amount" runat="server" ReadOnly="True"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            Amount Charged</td>
        <td>
            <asp:TextBox ID="bill" runat="server" ReadOnly="True"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            Bill</td>
        <td>
            <asp:TextBox ID="totbill" runat="server" ReadOnly="True" Visible="False"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Button ID="Button2" runat="server" onclick="Button2_Click" 
                Text="Add to Offer" Visible="False" />
        </td>
        <td>
            <asp:TextBox ID="TextBox6" runat="server" Visible="False" Width="73px">Planno</asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TextBox8" runat="server" Visible="False" 
                Width="95px">Amount</asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button3" runat="server" onclick="Button3_Click" Text="Submit" 
                Visible="False" />
        </td>
    </tr>
    <tr>
        <td>
            <asp:Button ID="bal" runat="server" Text="Balance" onclick="bal_Click" 
                Visible="False" />
        </td>
        <td>
            <asp:TextBox ID="balamt" runat="server" ReadOnly="True" Visible="False"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Button ID="Button4" runat="server" onclick="Button4_Click" 
                Text="Offer Balance" />
        </td>
        <td>
            <asp:TextBox ID="TextBox7" runat="server" ReadOnly="True" Visible="False">0</asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Button ID="recharge" runat="server" Text="Recharge" 
                onclick="recharge_Click" Visible="False" />
        </td>
        <td>
            <asp:TextBox ID="rechamt" runat="server" Visible="False" Width="87px">Amount</asp:TextBox>
            &nbsp;&nbsp;
            <asp:TextBox ID="TextBox5" runat="server" Width="80px" Visible="False">planno</asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="submit" runat="server" Text="Submit" onclick="submit_Click" 
                Visible="False" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;<asp:Label 
                ID="Label6" runat="server" ForeColor="#660033" 
                Text="enter 0 in planno if no plan is wanted" Visible="False"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
        <td>
            <asp:Label ID="Label2" runat="server" Text="Label" Visible="False"></asp:Label>
        </td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            <asp:Button ID="cpswd" runat="server" onclick="cpswd_Click" 
                Text="Change Password" />
        </td>
        <td>
            <asp:TextBox ID="npswd" runat="server" Visible="False" TextMode="Password">new password</asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
        <td>
            <asp:Button ID="submt" runat="server" onclick="submt_Click" Text="Submit" 
                Visible="False" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label4" runat="server" Text="Label" Visible="False"></asp:Label>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Button ID="offr" runat="server" onclick="offr_Click" 
                Text="Available Offers" Width="157px" />
        </td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
        <td>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </td>
    </tr>
</table>
</asp:Content>

