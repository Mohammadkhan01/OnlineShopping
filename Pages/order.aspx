<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="order.aspx.cs" Inherits="Pages_order" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <ajaxToolkit:TabContainer ID="TabContainer1" runat="server" ActiveTabIndex="0" Height="106px" Width="496px">
        <ajaxToolkit:TabPanel runat="server" HeaderText="TabPanel1" ID="TabPanel1">
            <HeaderTemplate>
                Open Orders
            </HeaderTemplate>
            <ContentTemplate>
                &nbsp;Show Order Between&nbsp;&nbsp;&nbsp;<asp:TextBox ID="txtOpenOrders1" runat="server"></asp:TextBox>
                <ajaxToolkit:CalendarExtender ID="txtOpenOrders1_CalendarExtender" runat="server" TargetControlID="txtOpenOrders1" />
                &nbsp;And <asp:TextBox ID="txtOpenOrders2" runat="server"></asp:TextBox>
                <ajaxToolkit:CalendarExtender ID="txtOpenOrders2_CalendarExtender" runat="server" TargetControlID="txtOpenOrders2" />
                <br />
                <asp:Label ID="lblOpenOrders" runat="server"></asp:Label>
                <asp:ScriptManager ID="ScriptManager1" runat="server">
                </asp:ScriptManager>
            </ContentTemplate>
        </ajaxToolkit:TabPanel>
        <ajaxToolkit:TabPanel ID="TabPanel2" runat="server" HeaderText="TabPanel2">
            <HeaderTemplate>
                Close Orders
            </HeaderTemplate>
        </ajaxToolkit:TabPanel>
        <ajaxToolkit:TabPanel ID="TabPanel3" runat="server" HeaderText="TabPanel3">
            <HeaderTemplate>
                Analyticx
            </HeaderTemplate>
        </ajaxToolkit:TabPanel>
    </ajaxToolkit:TabContainer>
</asp:Content>

