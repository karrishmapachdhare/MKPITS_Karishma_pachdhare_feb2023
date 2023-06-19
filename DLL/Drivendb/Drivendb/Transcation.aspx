<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Transcation.aspx.cs" Inherits="Drivendb.Transcation" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p class="text-center" style="font-size: large">
        <strong>Transcation Form</strong></p>
    <p class="text-start" style="font-size: large">
        <strong><span style="font-size: medium">Itemid&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>
        <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource4" DataTextField="Itemdesc" DataValueField="ItemId">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource4" runat="server" ConnectionString="<%$ ConnectionStrings:DrivenitdbConnectionString2 %>" SelectCommand="SELECT [ItemId], [Itemdesc] FROM [ItemMaster]"></asp:SqlDataSource>
        </strong>
    </p>
    <p class="text-start" style="font-size: medium">
        <strong>Trancsation type&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:RadioButton ID="RadioButton1" runat="server" GroupName="tt" Text="Issue" />
&nbsp;
        <asp:RadioButton ID="RadioButton2" runat="server" GroupName="tt" Text="Recived" />
        </strong>
    </p>
    <p class="text-start" style="font-size: large">
        <strong><span style="font-size: medium">Transcation quantity&nbsp;&nbsp;&nbsp;&nbsp; </span></strong>&nbsp;<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    </p>
    <p class="text-start" style="font-size: large">
        <strong><span style="font-size: medium">Transcation Date&nbsp;&nbsp;&nbsp;&nbsp; </span></strong>&nbsp;
        <asp:TextBox ID="TextBox3" runat="server" TextMode="Date"></asp:TextBox>
    </p>
    <p class="text-start" style="font-size: large">
        &nbsp; <strong>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="font-weight: bold; font-size: medium" Text="Add" />
        </strong>&nbsp; <strong>
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" style="font-weight: bold; font-size: medium" Text="Edit" />
        </strong>&nbsp; <strong>
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" style="font-weight: bold; font-size: medium" Text="Delete" />
        </strong>
    </p>
    <p class="text-start" style="font-size: large">
        <strong>
        <asp:Label ID="Label1" runat="server" style="font-size: medium" Text="Label"></asp:Label>
        </strong>
    </p>
    <p class="text-start" style="font-size: large">
        &nbsp;</p>
    <p class="text-start" style="font-size: large">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="Transid" DataSourceID="SqlDataSource3" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowSelectButton="True" />
                <asp:BoundField DataField="Transid" HeaderText="Transid" InsertVisible="False" ReadOnly="True" SortExpression="Transid" />
                <asp:BoundField DataField="ItemId" HeaderText="ItemId" SortExpression="ItemId" />
                <asp:BoundField DataField="TransType" HeaderText="TransType" SortExpression="TransType" />
                <asp:BoundField DataField="TransQty" HeaderText="TransQty" SortExpression="TransQty" />
                <asp:BoundField DataField="TranseDate" HeaderText="TranseDate" SortExpression="TranseDate" />
            </Columns>
            <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#FFCC66" ForeColor="Navy" Font-Bold="True" />
            <SortedAscendingCellStyle BackColor="#FDF5AC" />
            <SortedAscendingHeaderStyle BackColor="#4D0000" />
            <SortedDescendingCellStyle BackColor="#FCF6C0" />
            <SortedDescendingHeaderStyle BackColor="#820000" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:DrivenitdbConnectionString %>" DeleteCommand="DELETE FROM [Transactions] WHERE [Transid] = @Transid" InsertCommand="INSERT INTO [Transactions] ([ItemId], [TransType], [TransQty], [TranseDate]) VALUES (@ItemId, @TransType, @TransQty, @TranseDate)" SelectCommand="SELECT [Transid], [ItemId], [TransType], [TransQty], [TranseDate] FROM [Transactions]" UpdateCommand="UPDATE [Transactions] SET [ItemId] = @ItemId, [TransType] = @TransType, [TransQty] = @TransQty, [TranseDate] = @TranseDate WHERE [Transid] = @Transid">
            <DeleteParameters>
                <asp:Parameter Name="Transid" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="ItemId" Type="Int32" />
                <asp:Parameter Name="TransType" Type="String" />
                <asp:Parameter Name="TransQty" Type="Int32" />
                <asp:Parameter Name="TranseDate" Type="DateTime" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="ItemId" Type="Int32" />
                <asp:Parameter Name="TransType" Type="String" />
                <asp:Parameter Name="TransQty" Type="Int32" />
                <asp:Parameter Name="TranseDate" Type="DateTime" />
                <asp:Parameter Name="Transid" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server"></asp:SqlDataSource>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
    </p>
    <p class="text-start" style="font-size: large">
        &nbsp;</p>
    <p class="text-start" style="font-size: large">
        &nbsp;</p>
    <p class="text-start" style="font-size: large">
        &nbsp;</p>
    <p class="text-start" style="font-size: large">
        &nbsp;</p>
    <p class="text-start" style="font-size: large">
        &nbsp;</p>
    <p class="text-start" style="font-size: large">
        &nbsp;</p>
</asp:Content>
