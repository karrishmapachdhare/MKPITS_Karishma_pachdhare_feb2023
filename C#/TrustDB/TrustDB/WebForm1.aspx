<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="TrustDB.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        .newStyle1 {
            font-size: xx-large;
        }
        .auto-style2 {
            width: 100%;
        }
        .auto-style3 {
            width: 643px;
        }
        .auto-style4 {
            width: 348px;
        }
        .auto-style5 {
            width: 625px;
        }
        .auto-style6 {
            width: 100%;
            height: 99px;
        }
        .auto-style7 {
            width: 625px;
            height: 110px;
        }
        .auto-style8 {
            height: 110px;
        }
        .auto-style9 {
            height: 26px;
        }
        .auto-style10 {
            width: 100%;
            height: 104px;
        }
    </style>
</head>
<body style="height: 290px">
    <form id="form1" runat="server">
        <div class="auto-style1">
            <span class="newStyle1"><strong>&nbsp;&nbsp;&nbsp; Store Management System</strong></span></div>
        <table class="auto-style2">
            <tr>
                <td class="auto-style3">
                    <asp:Panel ID="Panel1" runat="server" Width="628px">
                        <table class="auto-style10">
                            <tr>
                                <td class="auto-style1" colspan="2">Item</td>
                            </tr>
                            <tr>
                                <td class="auto-style4">Item Id </td>
                                <td>
                                    <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style4">Category</td>
                                <td>
                                    <asp:DropDownList ID="DropDownList1" runat="server">
                                    </asp:DropDownList>
                                </td>
                            </tr>
                        </table>
                    </asp:Panel>
                </td>
                <td>
                    <asp:Panel ID="Panel2" runat="server">
                        <table class="auto-style2">
                            <tr>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                        </table>
                    </asp:Panel>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <table class="auto-style2">
            <tr>
                <td class="auto-style7">
                    <table class="auto-style6">
                        <tr>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style9"></td>
                            <td class="auto-style9"></td>
                        </tr>
                        <tr>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                    </table>
                </td>
                <td class="auto-style8"></td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
