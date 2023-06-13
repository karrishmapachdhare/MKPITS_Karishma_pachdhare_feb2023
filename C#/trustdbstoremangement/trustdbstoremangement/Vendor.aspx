<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Vendor.aspx.cs" Inherits="trustdbstoremangement.Vendor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    </p>
    <p>
        <strong><span style="font-size: x-large">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Store Management Store</span></strong></p>
    <asp:Panel ID="Panel1" runat="server" CssClass="auto-style2" Height="211px" Width="597px">
        <div class="auto-style3">
            <div class="text-center">
                <strong>Vendor Entry<br /> </strong>
            </div>
            <table class="w-100">
                <tr>
                    <td class="auto-style4">Vendor&nbsp; ID</td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">Vendor Name</td>
                    <td>
                        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">&nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4" style="height: 24px">-</td>
                    <td style="height: 24px">
                    </td>
                </tr>
                <tr>
                    <td class="text-center" colspan="2" style="height: 27px">
                        <asp:Button ID="Button1" runat="server" Text="Insert" OnClick="Button1_Click" />
                        <asp:Button ID="Button2" runat="server" Text="Update" />
                        <asp:Button ID="Button3" runat="server" Text="Delete" />
                        <asp:Button ID="Button4" runat="server" Text="Search" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </asp:Panel>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
</asp:Content>
