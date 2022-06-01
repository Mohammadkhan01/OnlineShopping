<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Pages_Account_Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server"></asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <div id="inner-wrapper">
   <fieldset>
       <br />
     <asp:Label ID="Label1" runat="server" Text="UserName"></asp:Label>

<asp:TextBox ID="txtUserName" runat="server" CssClass="inputs"></asp:TextBox>

<br />
<asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>

<asp:TextBox ID="txtPassword" runat="server" CssClass="inputs" TextMode="Password"></asp:TextBox>

<br />
<asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="Submit" BackColor="#CC6600" ForeColor="#000099" Height="16px" Width="187px" />
       <br />
<br />
<asp:Label ID="litStatus" runat="server"></asp:Label>

</fieldset>
        </div>
</asp:Content>

