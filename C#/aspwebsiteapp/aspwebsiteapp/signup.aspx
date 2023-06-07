<@% Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="signup.aspx.cs" Inherits="aspwebsiteapp.signup1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            font-size: large;
            color: #FFFFFF;
        }
        .auto-style2 {
            background-color: #CCCCCC;
        }
        .auto-style3 {
            width: 217px;
        }
        .auto-style4 {
            width: 217px;
            height: 25px;
            font-size: medium;
        }
        .auto-style5 {
            height: 25px;
        }
        .auto-style6 {
            width: 217px;
            font-size: medium;
        }
        .auto-style7 {
            width: 217px;
            height: 28px;
        }
        .auto-style8 {
            height: 28px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p class="text-center">
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <span class="auto-style1"><strong><span class="auto-style2">&nbsp;Sign Up Form</span></strong></span></p>
    <table align="center" class="w-50">
        <tr>
            <td class="auto-style4"><strong>Name</strong></td>
            <td class="auto-style5">
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style6"><strong>Password</strong></td>
            <td class="text-left">
                <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style7"></td>
            <td class="auto-style8">
                <asp:Button ID="Button1" runat="server" Text="Signup" />
            </td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
