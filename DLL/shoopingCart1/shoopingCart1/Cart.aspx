<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="shoopingCart1.Cart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p class="text-center" style="font-size: large">
        <strong>Sign Up To Save Your Order</strong></p>
    <p class="text-center" style="font-size: large">
        <strong>Enter Mobile No&nbsp;&nbsp; </strong>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </p>
    <p class="text-center" style="font-size: large">
        <strong>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="font-weight: bold" Text="Contiue" />
        </strong>
    </p>
</asp:Content>
