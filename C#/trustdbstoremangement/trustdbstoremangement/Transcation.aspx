<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Transcation.aspx.cs" Inherits="trustdbstoremangement.Transcation" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <strong><span style="font-size: x-large">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Store Management Store</span></strong></p>
    <asp:Panel ID="Panel1" runat="server" CssClass="auto-style2" Height="211px" Width="597px">
        <div class="auto-style3">
            <div class="text-center">
                <strong>Transcation Entry<br /> </strong>
            </div>
            <table class="w-100">
                <tr>
                    <td class="auto-style4">Item Name</td>
                    <td>
                        <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="Department_id" DataValueField="Department_id">
                        </asp:DropDownList>
                        <br />
                        <br />
                        <br />
                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:TrustDBConnectionString %>" ProviderName="<%$ ConnectionStrings:TrustDBConnectionString.ProviderName %>" SelectCommand="SELECT [Department_id], [Department_name] FROM [Department_mast]"></asp:SqlDataSource>
                        <br />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">Transcation Date</td>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server" TextMode="DateTime"></asp:TextBox>
                        <br />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <br />
                        <br />
                        <br />
                        Department Name</td>
                    <td>
                        <asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="SqlDataSource2" DataTextField="Department_id" DataValueField="Department_id">
                        </asp:DropDownList>
                        <br />
                        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:TrustDBConnectionString2 %>" ProviderName="<%$ ConnectionStrings:TrustDBConnectionString2.ProviderName %>" SelectCommand="SELECT [Department_id], [Department_name] FROM [Department_mast]"></asp:SqlDataSource>
                        <br />
                        <br />
                        <br />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4" style="height: 24px">
                        <br />
                        <br />
                        Vendor Name</td>
                    <td style="height: 24px">
                        <asp:DropDownList ID="DropDownList3" runat="server" DataSourceID="SqlDataSource3" DataTextField="Department_id" DataValueField="Department_id">
                        </asp:DropDownList>
                        <br />
                        <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:TrustDBConnectionString3 %>" ProviderName="<%$ ConnectionStrings:TrustDBConnectionString3.ProviderName %>" SelectCommand="SELECT [Department_id], [Department_name] FROM [Department_mast]"></asp:SqlDataSource>
                    </td>
                </tr>
                <tr>
                    <td class="text-center" colspan="2" style="height: 27px">
                        <table class="w-100">
                            <tr>
                                <td style="width: 293px">&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td style="width: 293px">Quantity</td>
                                <td>
                                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 293px">&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td style="width: 293px">&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td style="width: 293px">&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td style="width: 293px">&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                        </table>
                        <asp:Button ID="Button1" runat="server" Text="Insert" OnClick="Button1_Click" />
                        <asp:Button ID="Button2" runat="server" Text="Update" OnClick="Button2_Click" />
                        <asp:Button ID="Button3" runat="server" Text="Delete" OnClick="Button3_Click" />
                        <asp:Button ID="Button4" runat="server" Text="Search" OnClick="Button4_Click" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <br />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                        <br />
                        <br />
                        <asp:GridView ID="GridView1" runat="server">
                        </asp:GridView>
                        <br />
                        <br />
                        <br />
                    </td>
                    <td>
                        <br />
                        <br />
                        <br />
                        <br />
                        <br />
                        <br />
                        <br />
                        <br />
                        <br />
                    </td>
                </tr>
            </table>
        </div>
    </asp:Panel>
    <p>
        <br />
    </p>
    <p>
    </p>
</asp:Content>
