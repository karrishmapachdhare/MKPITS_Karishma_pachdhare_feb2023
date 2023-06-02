<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="validation.Properties.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        .auto-style2 {
            width: 100%;
        }
        .auto-style5 {
            width: 240px;
            height: 29px;
        }
        .auto-style6 {
            width: 463px;
            height: 29px;
        }
        .auto-style7 {
            height: 29px;
        }
        .auto-style8 {
            margin-right: 66px;
        }
        .auto-style9 {
            width: 240px;
        }
        .auto-style10 {
            width: 463px;
        }
        .auto-style11 {
            width: 240px;
            height: 26px;
        }
        .auto-style12 {
            width: 463px;
            height: 26px;
        }
        .auto-style13 {
            height: 26px;
        }
        .auto-style14 {
            width: 240px;
            height: 33px;
        }
        .auto-style15 {
            width: 463px;
            height: 33px;
        }
        .auto-style16 {
            height: 33px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <strong>&nbsp;Validation Control</strong></div>
        <table class="auto-style2">
            <tr>
                <td class="auto-style9">First Name</td>
                <td class="auto-style10">
                    <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="RequiredFieldValidator">Enter First Name Please</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style9">&nbsp;</td>
                <td class="auto-style10">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">Password</td>
                <td class="auto-style6">
                    <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
                </td>
                <td class="auto-style7">
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox2" ControlToValidate="TextBox3" ErrorMessage="Password does not match">Enter Proper Password</asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style11"></td>
                <td class="auto-style12"></td>
                <td class="auto-style13"></td>
            </tr>
            <tr>
                <td class="auto-style5">Re-Enter Password</td>
                <td class="auto-style6">
                    <asp:TextBox ID="TextBox3" runat="server" TextMode="Password"></asp:TextBox>
                </td>
                <td class="auto-style7"></td>
            </tr>
            <tr>
                <td class="auto-style11">&nbsp; Enter Age</td>
                <td class="auto-style12">
                    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style13">
                    <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="TextBox4" Display="Dynamic" ErrorMessage="age should be between 18 and 100" MaximumValue="100" MinimumValue="18" Type="Integer">Enter Age Proper </asp:RangeValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style14">Email ID</td>
                <td class="auto-style15">
                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style16">
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox5" ErrorMessage="Enter Valid Email Id" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style9">&nbsp;</td>
                <td class="auto-style10">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style9">&nbsp;</td>
                <td class="auto-style10">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style9">
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                </td>
                <td class="auto-style10">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style9">
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" CssClass="auto-style8" />
                </td>
                <td class="auto-style10">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
