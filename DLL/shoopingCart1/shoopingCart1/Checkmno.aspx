<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Checkmno.aspx.cs" Inherits="shoopingCart1.Checkmno" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p class="text-center" style="font-size: large">
        <strong>Enter OTP&nbsp;&nbsp; </strong>
        <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
    </p>
    <p class="text-center" style="font-size: large">
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Ok" />
    </p>
    <p class="text-center" style="font-size: large">
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </p>
</asp:Content>
