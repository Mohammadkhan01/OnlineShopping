<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default1.aspx.cs" Inherits="Pages_Account_Default1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <fieldset>
     <asp:Label ID="Label1" runat="server" Text="UserName"></asp:Label>

<asp:TextBox ID="txtUserName" runat="server" CssClass="inputs"></asp:TextBox>

<br />
<asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>

<asp:TextBox ID="txtPassword" runat="server" CssClass="inputs" TextMode="Password"></asp:TextBox>

<br />
<asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="Button" />
<br />
<asp:Label ID="litStatus" runat="server"></asp:Label>

</fieldset>
    </div>
    </form>
</body>
</html>
