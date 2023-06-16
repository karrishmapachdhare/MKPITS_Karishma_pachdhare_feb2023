<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Department_mast.aspx.cs" Inherits="trustproject.Department_mast" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p style="font-size: large">
        <strong>Store Management System</strong></p>
    <p style="font-size: medium">
        <strong>Department Entry</strong></p>
    <p style="font-size: medium">
        <strong>DepartmentID&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </strong>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </p>
    <p style="font-size: medium">
        <strong>DepartmentName</strong>&nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    </p>
    <p style="font-size: medium">
        &nbsp;
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Insert" />
        &nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Update" />
&nbsp;&nbsp;
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Delete" />
&nbsp;&nbsp;
        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Search" />
    </p>
    <p style="font-size: medium">
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </p>
</asp:Content>
