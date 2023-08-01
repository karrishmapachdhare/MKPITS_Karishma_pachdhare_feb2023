<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="Admindashboard.aspx.cs" Inherits="ShoppingCart.Admindashboard" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        Welcome to products page</p>
    <table class="w-50">
        <tr>
            <td style="width: 190px">ProdName</td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 190px">ProdDescription</td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 190px">ProdPrice</td>
            <td>
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 190px">SelectImage</td>
            <td>
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
&nbsp;
                <asp:FileUpload ID="FileUpload1" runat="server" />
            </td>
        </tr>
        <tr>
            <td style="width: 190px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 190px">&nbsp;</td>
            <td>
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Save" />
            </td>
        </tr>
        <tr>
            <td style="width: 190px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 190px">&nbsp;</td>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 190px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Prodid" DataSourceID="SqlDataSource2" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" GridLines="Horizontal">
        <Columns>
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowSelectButton="True" />
            <asp:BoundField DataField="Prodid" HeaderText="Prodid" InsertVisible="False" ReadOnly="True" SortExpression="Prodid" />
            <asp:BoundField DataField="ProdName" HeaderText="ProdName" SortExpression="ProdName" />
            <asp:BoundField DataField="Proddescription" HeaderText="Proddescription" SortExpression="Proddescription" />
            <asp:BoundField DataField="Catid" HeaderText="Catid" SortExpression="Catid" />
            <asp:BoundField DataField="ProdPrice" HeaderText="ProdPrice" SortExpression="ProdPrice" />
            <asp:BoundField DataField="Qty" HeaderText="Qty" SortExpression="Qty" />
            <asp:BoundField DataField="ProdImage" HeaderText="ProdImage" SortExpression="ProdImage" />
        </Columns>
        <FooterStyle BackColor="White" ForeColor="#333333" />
        <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="White" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F7F7F7" />
        <SortedAscendingHeaderStyle BackColor="#487575" />
        <SortedDescendingCellStyle BackColor="#E5E5E5" />
        <SortedDescendingHeaderStyle BackColor="#275353" />
</asp:GridView>
<asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:shoppingcartConnectionString %>" DeleteCommand="DELETE FROM [Products] WHERE [Prodid] = @Prodid" InsertCommand="INSERT INTO [Products] ([ProdName], [Proddescription], [Catid], [ProdPrice], [Qty], [ProdImage]) VALUES (@ProdName, @Proddescription, @Catid, @ProdPrice, @Qty, @ProdImage)" ProviderName="<%$ ConnectionStrings:shoppingcartConnectionString.ProviderName %>" SelectCommand="SELECT [Prodid], [ProdName], [Proddescription], [Catid], [ProdPrice], [Qty], [ProdImage] FROM [Products]" UpdateCommand="UPDATE [Products] SET [ProdName] = @ProdName, [Proddescription] = @Proddescription, [Catid] = @Catid, [ProdPrice] = @ProdPrice, [Qty] = @Qty, [ProdImage] = @ProdImage WHERE [Prodid] = @Prodid">
    <DeleteParameters>
        <asp:Parameter Name="Prodid" Type="Decimal" />
    </DeleteParameters>
    <InsertParameters>
        <asp:Parameter Name="ProdName" Type="String" />
        <asp:Parameter Name="Proddescription" Type="String" />
        <asp:Parameter Name="Catid" Type="Decimal" />
        <asp:Parameter Name="ProdPrice" Type="Decimal" />
        <asp:Parameter Name="Qty" Type="Decimal" />
        <asp:Parameter Name="ProdImage" Type="String" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="ProdName" Type="String" />
        <asp:Parameter Name="Proddescription" Type="String" />
        <asp:Parameter Name="Catid" Type="Decimal" />
        <asp:Parameter Name="ProdPrice" Type="Decimal" />
        <asp:Parameter Name="Qty" Type="Decimal" />
        <asp:Parameter Name="ProdImage" Type="String" />
        <asp:Parameter Name="Prodid" Type="Decimal" />
    </UpdateParameters>
</asp:SqlDataSource>
<asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
</asp:Content>
