<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ShoppingCart.aspx.cs" Inherits="Pages_ShoppingCart" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <asp:Panel ID="pnlShoppingCart" runat="server">


    </asp:Panel>
    <table>
        <tr>
            <td> <b>Total:</b></td>
            <td> <asp:Literal ID="litTotal" runat="server"></asp:Literal></td>
        </tr>
         <tr>
            <td> <b>Vat:</b></td>
            <td> <asp:Literal ID="litVat" runat="server"></asp:Literal></td>
        </tr>
         <tr>
            <td> <b>Shipping:</b></td>
            <td> $10</td>
        </tr>
         <tr>
            <td> <b>Total Amount:</b></td>
            <td> <asp:Literal ID="litTotalAmount" runat="server"></asp:Literal></td>
        </tr>

        <tr>
            <td>
                <asp:LinkButton ID="lnkContinue" runat="server" PostBackUrl ="~/index.aspx" Text ="Continue Shopping"/>
                or
                <asp:Button ID="btnCheckOut" runat="server" PostBackUrl="~/Pages/Success.aspx" CssClass ="button" Width ="250px" Text="Continue Checkout" OnClick="btnCheckOut_Click" />
            </td>
        </tr>
    </table>
</asp:Content>

