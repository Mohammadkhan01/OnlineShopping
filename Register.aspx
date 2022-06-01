<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Pages_Account_Register" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="inner-wrapper">
                           
    
       <table >
           

               
            <tr>
                <td>
                     
                  <b>User Name :</b>
                </td>
                 <td>
                     <asp:TextBox ID="txtUserName" Width ="200px" runat="server"></asp:TextBox>
                </td>
                <td rowspan =10>
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="ID" DataSourceID="SqlDataSource1" OnRowEditing="GridView1_RowEditing" >
             <Columns>
                 <asp:CommandField ShowEditButton="True" />
                 <asp:BoundField DataField="FirstName" HeaderText="FirstName" SortExpression="FirstName" />
                 <asp:BoundField DataField="LastName" HeaderText="LastName" SortExpression="LastName" />
                 <asp:BoundField DataField="Address" HeaderText="Address" SortExpression="Address" />
                 <asp:BoundField DataField="PostalCode" HeaderText="PostalCode" SortExpression="PostalCode" />
                 <asp:BoundField DataField="Phone" HeaderText="Phone" SortExpression="Phone" />
                 <asp:BoundField DataField="ID" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="ID" />
             </Columns>
         </asp:GridView>
         <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:GarageDBConnectionString %>" DeleteCommand="DELETE FROM [UserInformation] WHERE [ID] = @original_ID AND (([FirstName] = @original_FirstName) OR ([FirstName] IS NULL AND @original_FirstName IS NULL)) AND (([LastName] = @original_LastName) OR ([LastName] IS NULL AND @original_LastName IS NULL)) AND [Address] = @original_Address AND [PostalCode] = @original_PostalCode AND (([Phone] = @original_Phone) OR ([Phone] IS NULL AND @original_Phone IS NULL)) AND (([Password] = @original_Password) OR ([Password] IS NULL AND @original_Password IS NULL))" InsertCommand="INSERT INTO [UserInformation] ([FirstName], [LastName], [Address], [PostalCode], [Phone], [Password]) VALUES (@FirstName, @LastName, @Address, @PostalCode, @Phone, @Password)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT [FirstName], [LastName], [Address], [PostalCode], [Phone], [Password], [ID] FROM [UserInformation]" UpdateCommand="UPDATE [UserInformation] SET [FirstName] = @FirstName, [LastName] = @LastName, [Address] = @Address, [PostalCode] = @PostalCode, [Phone] = @Phone, [Password] = @Password WHERE [ID] = @original_ID AND (([FirstName] = @original_FirstName) OR ([FirstName] IS NULL AND @original_FirstName IS NULL)) AND (([LastName] = @original_LastName) OR ([LastName] IS NULL AND @original_LastName IS NULL)) AND [Address] = @original_Address AND [PostalCode] = @original_PostalCode AND (([Phone] = @original_Phone) OR ([Phone] IS NULL AND @original_Phone IS NULL)) AND (([Password] = @original_Password) OR ([Password] IS NULL AND @original_Password IS NULL))">
             <DeleteParameters>
                 <asp:Parameter Name="original_ID" Type="Int32" />
                 <asp:Parameter Name="original_FirstName" Type="String" />
                 <asp:Parameter Name="original_LastName" Type="String" />
                 <asp:Parameter Name="original_Address" Type="String" />
                 <asp:Parameter Name="original_PostalCode" Type="Int32" />
                 <asp:Parameter Name="original_Phone" Type="Int32" />
                 <asp:Parameter Name="original_Password" Type="String" />
             </DeleteParameters>
             <InsertParameters>
                 <asp:Parameter Name="FirstName" Type="String" />
                 <asp:Parameter Name="LastName" Type="String" />
                 <asp:Parameter Name="Address" Type="String" />
                 <asp:Parameter Name="PostalCode" Type="Int32" />
                 <asp:Parameter Name="Phone" Type="Int32" />
                 <asp:Parameter Name="Password" Type="String" />
             </InsertParameters>
             <UpdateParameters>
                 <asp:Parameter Name="FirstName" Type="String" />
                 <asp:Parameter Name="LastName" Type="String" />
                 <asp:Parameter Name="Address" Type="String" />
                 <asp:Parameter Name="PostalCode" Type="Int32" />
                 <asp:Parameter Name="Phone" Type="Int32" />
                 <asp:Parameter Name="Password" Type="String" />
                 <asp:Parameter Name="original_ID" Type="Int32" />
                 <asp:Parameter Name="original_FirstName" Type="String" />
                 <asp:Parameter Name="original_LastName" Type="String" />
                 <asp:Parameter Name="original_Address" Type="String" />
                 <asp:Parameter Name="original_PostalCode" Type="Int32" />
                 <asp:Parameter Name="original_Phone" Type="Int32" />
                 <asp:Parameter Name="original_Password" Type="String" />
             </UpdateParameters>
         </asp:SqlDataSource>
                </td>
                
                
            </tr>

             <tr>
                <td>
                  <b>Password :</b>
                </td>
                 <td>
                     <asp:TextBox ID="txtPassword" Width ="200px" runat="server"></asp:TextBox>
                </td>
                
                
            </tr>


             <tr>
                <td>
                  <b>Confirm Password :</b>
                </td>
                 <td>
                     <asp:TextBox ID="txtConfirmPassword" Width ="200px" runat="server"></asp:TextBox>
                </td>
            </tr>
        <tr>
                <td>
                  <b>First Name :</b>
                </td>
                 <td>
                     <asp:TextBox ID="txtFirstName" Width ="207px" runat="server" ></asp:TextBox>
                </td>
                
            </tr>
           <tr>
                <td>
                  <b>Last Name :</b>
                </td>
                 <td>
                     <asp:TextBox ID="txtLastName" Width ="207px" runat="server" ></asp:TextBox>
                </td>
            </tr>
                    
           <tr>
                <td>
                  <b>Address :</b>
                </td>
                 <td>
                     <asp:TextBox ID="txtAddress" Width ="207px" runat="server" ></asp:TextBox>
                </td>
            </tr>
           <tr>
                <td>
                  <b>Postal Code :</b>
                </td>
                 <td>
                     <asp:TextBox ID="txtPostalCode" Width ="207px" runat="server" ></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                  <b>Phone :</b>
                </td>
                 <td>
                     <asp:TextBox ID="txtPhone" Width ="207px" runat="server" ></asp:TextBox>
                </td>
            </tr>
            
            <tr>
                <td colspan ="3">
                    <asp:Label ID="litStatus" runat="server"></asp:Label>
                    <asp:Button ID="Button3" runat="server" Text="Button" />
                    <asp:Button ID="Button2" runat="server" Text="Submit" OnClick="Button2_Click" style="color: #FFFFFF; font-weight: 700; background-color: #000066" Width="301px" Height ="52px" />
                </td>
            </tr>
          
  </table>
    </div>
 
   <br /><br />

     
         
    

         <br />
        
  

    
</asp:Content>

