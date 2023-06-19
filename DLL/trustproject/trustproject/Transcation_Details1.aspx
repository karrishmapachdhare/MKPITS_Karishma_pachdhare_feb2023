<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Transcation_Details1.aspx.cs" Inherits="trustproject.Transcation_Details1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p style="font-size: large">
        <strong>Management Store System</strong></p>
    <p style="font-size: medium">
        <strong>Transcation Details</strong></p>
    <p style="font-size: medium">
        <asp:RadioButton ID="RadioButton1" runat="server" Text="Issue" Checked="True" />
&nbsp;&nbsp;
        <asp:RadioButton ID="RadioButton2" runat="server" OnCheckedChanged="RadioButton2_CheckedChanged" Text="Purches" />
    </p>
    <p style="font-size: medium">
        <strong>TranscationID&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </strong>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </p>
    <p style="font-size: medium">
        <strong>ItemID&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </strong>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    </p>
    <p style="font-size: medium">
        <strong>Transcation Date</strong>&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    </p>
    <p style="font-size: medium">
        DepartmentID&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
    </p>
    <p style="font-size: medium">
        VendorID&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
    </p>
    <p style="font-size: medium">
        Quantity&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
    </p>
    <p style="font-size: medium">
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Insert" />
&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Text="Update" />
&nbsp;&nbsp;
        <asp:Button ID="Button3" runat="server" Text="Delete" />
&nbsp;&nbsp;
        <asp:Button ID="Button4" runat="server" Text="Search" />
    </p>
    <p style="font-size: medium">
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </p>
</asp:Content>
