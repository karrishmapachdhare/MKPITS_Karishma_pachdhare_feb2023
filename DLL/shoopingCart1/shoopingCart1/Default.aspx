<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="shoopingCart1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
<section class="row" aria-labelledby="aspnetTitle">
<h1 id="aspnetTitle">Meesho</h1>
<p class="lead">Lowest Prices
Best Quality Shopping</p>
<p></p>
</section>

<div class="row">
<section class="col-md-4" aria-labelledby="gettingStartedTitle">
<h2 id="gettingStartedTitle">Free Delivery</h2>
<p> Register as a Meesho Supplier

<br /><br />
Sell online to 14 Cr+ customers at

0% Commission
Become a Meesho seller and grow your business across India
</p>
<p>
<a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301948"></a>
</p>
</section>
<section class="col-md-4" aria-labelledby="librariesTitle">
<h2 id="librariesTitle">Cash on delivery</h2>
<p>
Register as a Meesho Supplier
</p>
<p>
<a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301949"></a>
</p>
</section>
<section class="col-md-4" aria-labelledby="hostingTitle">
<h2 id="hostingTitle"></h2>
<p>
<img src="image1.jpg" style="width:350px;height:250px;" />
</p>
<p>

<a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301950">Learn more &raquo;</a>
</p>
</section>
</div>
<hr />
<div class="row">
<h1 align=center>_________________Top Categories to choose from________________________</h1>

</div>
<hr />
<div class="row">

    <asp:DataList ID="DataList1" runat="server" RepeatColumns="4" Width="100%" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal">
    

        <AlternatingItemStyle BackColor="#F7F7F7" />
    

        <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
        <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
        <ItemStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
    

<ItemTemplate>
<table cellpadding="2" cellspacing="0" border="1" style="width: 300px; height: 100px;
border: dashed 2px #04AFEF; background-color: #FFFFFF">
<tr>
<td align="center">
<asp:Image ID="a1" ImageUrl='<%# Bind("prodimage", "~/imges/{0}") %>' runat="server"

Height="100"

Width="100" />

</td>
</tr>

<tr>
<td align="center">
<span > <%# Eval("prodname") %></span><br />
<span > <%# Eval("proddescription") %></span><br />
<span >Rs. <%# Eval("prodprice") %> onwards</span><br />

</td>
</tr>
</table>
</ItemTemplate>

        <SelectedItemStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />

</asp:DataList>
</div>

</main>

</asp:Content>