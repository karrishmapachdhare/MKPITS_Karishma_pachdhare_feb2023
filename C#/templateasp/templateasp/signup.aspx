<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="signup.aspx.cs" Inherits="templateasp.signup" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            width: 50%;
            border-style: solid;
            border-width: 1px;
        }
        .auto-style3 {
            width: 215px;
            text-align: left;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <h1 align="center">Sign Up Form<br />
         <table class="auto-style2">
             <tr>
                 <td class="auto-style3">Name</td>
                 <td class="text-left">
                     <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                 </td>
             </tr>
             <tr>
                 <td class="auto-style3">Password</td>
                 <td class="text-left">
                     <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
                 </td>
             </tr>
             <tr>
                 <td class="auto-style3">&nbsp;</td>
                 <td class="text-left">
                     <asp:Button ID="Button1" runat="server" Text="Sign UP" />
                 </td>
             </tr>
         </table>
     </h1>
</asp:Content>
