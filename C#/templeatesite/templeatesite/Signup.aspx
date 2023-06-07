<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="Signup.aspx.cs" Inherits="templeatesite.Signup" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

     <style type="text/css">
        .auto-style1 {
            width: 100%;
            border-collapse: collapse;
        }
        .auto-style3 {
            text-align: left;
            width: 188px;
        }
        .auto-style4 {
            width: 188px;
        }
        .auto-style5 {
            text-align: left;
            width: 253px;
        }
         .auto-style7 {
             width: 43%;
             border-collapse: collapse;
             font-size: large;
             height: 189px;
         }
    </style>
    </asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<h1 align="center">Sign Up Form<br />
         <table class="auto-style7" align="center">
             <tr>
                 <td class="auto-style3">Name</td>
                 <td class="auto-style5">
                     <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                 </td>
             </tr>
             <tr>
                 <td class="auto-style3">Password</td>
                 <td class="auto-style5">
                     <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
                 </td>
             </tr>
             <tr>
                 <td class="auto-style4">&nbsp;</td>
                 <td class="auto-style5">
                     <asp:Button ID="Button1" runat="server" Text="Sign Up" />
                 </td>
             </tr>
         </table>
         <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
         <table class="auto-style1">
         </table>
     </h1>
    </asp:Content>
