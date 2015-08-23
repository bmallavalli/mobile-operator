<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="services.aspx.cs" Inherits="services" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        Prepaid</p>
    <p>
        Postpaid</p>
    <p>
        Internet</p>
    <p>
        Online Recharge</p>
    <p>
        Customer Care&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
        for more details(<asp:HyperLink ID="HyperLink1" runat="server" 
            NavigateUrl="~/contact.aspx">contact us</asp:HyperLink>
        )</p>
</asp:Content>

