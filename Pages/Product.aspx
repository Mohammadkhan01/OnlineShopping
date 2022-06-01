<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Product.aspx.cs" Inherits="Pages_Product" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">

    <table>
     <tr>
        <td rowspan ="4">
            <asp:Image ID="imgProduct" runat ="server" CssClass ="detailsImage" />
         </td>
         <td><h2>
             <asp:Label ID="lblTitle" runat ="server" Text="Label1"></asp:Label>
             </h2>

            <asp:Label ID="lblDescription" runat="server" cssClass="detailsDescription"></asp:Label>
        </td>
         </tr>

      <tr>
            <td>
            <asp:Label ID="lblPrice" runat="server" cssClass="detailsPrice"></asp:Label>
        <br />
         Quantity:
         <asp:DropDownList ID="ddlAmount" runat ="server"></asp:DropDownList><br />
         <asp:Label ID ="lblResult" runat ="server" Text=""></asp:Label>
                
                <asp:Button ID="btnAdd" runat="server" CssClass="button " Text ="Add on Cart" OnClick="btnAdd_Click1" />
 </td>
             </tr>
   


     <tr>
        <td>

            Product Number:<asp:Label ID="lblTemName" runat ="server" Text ="Label"></asp:Label>
        </td>
        
    </tr>



     <tr>
        <td>
            <asp:Label ID="Label1" runat ="server" Text ="Available" CssClass ="productPrice "></asp:Label>

        </td>
        
    </tr>
</table>
</asp:Content>

