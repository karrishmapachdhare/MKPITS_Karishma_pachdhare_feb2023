<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="vendor.aspx.cs" Inherits="trustproject.vendor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p style="font-size: large">
    <strong>Vendor Master</strong></p>
<p style="font-size: medium">
    Vendor ID&nbsp;
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;
    <asp:Button ID="Button1" runat="server" Text="Search" OnClick="Button1_Click" />
</p>
<p style="font-size: medium">
    Vendor Name&nbsp;
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
</p>
<p style="font-size: medium">
    &nbsp;</p>
<p style="font-size: medium">
    <asp:Button ID="Button2" runat="server" Text="Add" OnClick="Button2_Click" />
&nbsp;
    <asp:Button ID="Button3" runat="server" Text="Modify" OnClick="Button3_Click" />
&nbsp;
    <asp:Button ID="Button4" runat="server" Text="Delete" OnClick="Button4_Click" />
</p>
<p style="font-size: medium">
    &nbsp;</p>
<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
</asp:Content>
