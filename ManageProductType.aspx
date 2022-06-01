<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ManageProductType.aspx.cs" Inherits="Pages_ManageProductType" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
     <br />
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" Text="SAVE" OnClick="Button1_Click" Width="126px" />
    <br />
    <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
</asp:Content>

