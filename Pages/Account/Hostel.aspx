<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Hostel.aspx.cs" Inherits="Pages_Account_Hostel" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 268435552px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">

    <table>
     <tr>
        <td rowspan ="2">
            <asp:Label ID="Label8" runat="server" Text="No Of Rooms"></asp:Label>
<br />
<asp:TextBox ID="txtNoOfRooms" runat="server" CssClass="inputs"></asp:TextBox>
<br />
<asp:Label ID="Label5" runat="server" Text="No of Students"></asp:Label>
<br />
<asp:TextBox ID="txtNoOfStudent" runat="server" CssClass="inputs"></asp:TextBox>
<br />
<br />
<asp:Label ID="Label6" runat="server" Text="Address"></asp:Label>
<br />
<asp:TextBox ID="txtAddress" runat="server" CssClass="inputs"></asp:TextBox>
<br />
<br />
<asp:Label ID="Label7" runat="server" Text="Expense"></asp:Label>
<br />
<asp:TextBox ID="txtExpense" runat="server" CssClass="inputs"></asp:TextBox>
<br />
<asp:Button ID="Button2" runat="server" CssClass="button" OnClick="Button2_Click" Text="SAVE" Width="90px" />
<br />
<asp:Label ID="litStatus" runat="server"></asp:Label>
         </td>
       
        
    </tr>



     <tr>
        <td class="auto-style1">
            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="HostelId" DataSourceID="sdshostel">
                <Columns>
                    <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                    <asp:BoundField DataField="HostelId" HeaderText="HostelId" ReadOnly="True" SortExpression="HostelId" />
                    <asp:BoundField DataField="NoOfRooms" HeaderText="NoOfRooms" SortExpression="NoOfRooms" />
                    <asp:BoundField DataField="NoOfStudents" HeaderText="NoOfStudents" SortExpression="NoOfStudents" />
                    <asp:BoundField DataField="AnnualExpense" HeaderText="AnnualExpense" SortExpression="AnnualExpense" />
                    <asp:BoundField DataField="Address" HeaderText="Address" SortExpression="Address" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="sdshostel" runat="server" ConnectionString="Data Source=localhost\sqlexpress;Initial Catalog=GarageDB;Integrated Security=True" DeleteCommand="DELETE FROM [Hostel] WHERE [HostelId] = @HostelId" InsertCommand="INSERT INTO [Hostel] ([HostelId], [NoOfRooms], [NoOfStudents], [AnnualExpense], [Address]) VALUES (@HostelId, @NoOfRooms, @NoOfStudents, @AnnualExpense, @Address)" ProviderName="System.Data.SqlClient" SelectCommand="SELECT * FROM [Hostel]" UpdateCommand="UPDATE [Hostel] SET [NoOfRooms] = @NoOfRooms, [NoOfStudents] = @NoOfStudents, [AnnualExpense] = @AnnualExpense, [Address] = @Address WHERE [HostelId] = @HostelId">
                <DeleteParameters>
                    <asp:Parameter Name="HostelId" Type="Int32" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="HostelId" Type="Int32" />
                    <asp:Parameter Name="NoOfRooms" Type="Int32" />
                    <asp:Parameter Name="NoOfStudents" Type="Int32" />
                    <asp:Parameter Name="AnnualExpense" Type="Int32" />
                    <asp:Parameter Name="Address" Type="String" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter Name="NoOfRooms" Type="Int32" />
                    <asp:Parameter Name="NoOfStudents" Type="Int32" />
                    <asp:Parameter Name="AnnualExpense" Type="Int32" />
                    <asp:Parameter Name="Address" Type="String" />
                    <asp:Parameter Name="HostelId" Type="Int32" />
                </UpdateParameters>
            </asp:SqlDataSource>
            <asp:Label ID="Label1" runat ="server" Text ="Available" CssClass ="productPrice "></asp:Label>

        </td>
        
    </tr>
</table>
   
</asp:Content>

