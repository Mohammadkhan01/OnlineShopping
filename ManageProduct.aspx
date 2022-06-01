<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ManageProduct.aspx.cs" Inherits="Pages_ManageProduct" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <h3><asp:Label ID="Label5" runat="server" Text="Add latest Announcement"></asp:Label></h3>
    <asp:Label ID="lblName" runat="server" Text="topic"></asp:Label>
    <br />
    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
    <br />
    <%--
    <asp:Label ID="Label1" runat="server" Text="Type"></asp:Label>
    <br/>
    <asp:DropDownList ID="ddlType" runat="server" DataSourceID="SqlDataSource1" DataTextField="Name" DataValueField="Id">
    </asp:DropDownList>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=GarageDB;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework" ProviderName="System.Data.SqlClient" SelectCommand="SELECT * FROM [ProductTypes] ORDER BY [Name]"></asp:SqlDataSource>
    <br />--%>
    <asp:Label ID="Label4" runat="server" Text="Price"></asp:Label>
    <br />
    <asp:TextBox ID="txtPrice" runat="server" Text="0"></asp:TextBox>
    <br />
    <asp:Label ID="Label2" runat="server" Text="image"></asp:Label>
    <br />
    <asp:DropDownList ID="ddlpicture" runat="server" Width="234px" OnSelectedIndexChanged="ddlpicture_SelectedIndexChanged">
    </asp:DropDownList>
    <br />
    <asp:Label ID="Label3" runat="server" Text="Description"></asp:Label>
    <br />
    <asp:TextBox ID="TextBox1" runat="server" Height="173px" TextMode="MultiLine" Width="620px"></asp:TextBox>
    <br /><br />

    <asp:Button ID="Button1" runat="server" Text="Submit" Width="126px" OnClick="Button1_Click" />

    <br />
    <asp:Label ID="lblResult" runat="server"></asp:Label>

</asp:Content>

