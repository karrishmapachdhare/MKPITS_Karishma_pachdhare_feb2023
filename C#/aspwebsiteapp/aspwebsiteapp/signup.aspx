<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="signup.aspx.cs" Inherits="aspwebsiteapp.signup" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style1 {
        text-align: center;
        width: 231px;
    }
    .auto-style2 {
        width: 231px;
    }
    .auto-style3 {
        left: 451px;
        top: 6px;
        width: 730px;
        margin-right: 730;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 class="auto-style3">
    <div class="text-center">
        Sign up Form<br />
    </div>
    <table class="w-100">
        <tbody class="text-left">
            <tr>
                <td class="auto-style1">Name</td>
                <td class="text-left">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Password</td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </tbody>
    </table>
</h1>
</asp:Content>
