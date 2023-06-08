<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default1.aspx.cs" Inherits="cookieex2.default1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Register Form<br />
            <br />
&nbsp;
            <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/default1.aspx">Register</asp:LinkButton>
&nbsp;&nbsp;
            <asp:LinkButton ID="LinkButton2" runat="server">View Info</asp:LinkButton>
            <br />
            <br />
            <br />
            Username&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;&nbsp;
            <br />
            <br />
        </div>
    </form>
</body>
</html>
