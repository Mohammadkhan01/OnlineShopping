<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="management.aspx.cs" Inherits="Pages_management" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
   <div class="clearf"></div>
    
            
                <h3>Register New Member </h3>
      
           <asp:HiddenField  ID="hfContactID" runat="server" />

     <table>
        

        <tr>
            <td>
                <asp:Label ID="Label4" runat="server" Text="First Name"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtFirstName" runat="server" CssClass="inputs"></asp:TextBox>
            </td>
        </tr>
         <tr>
             <td>
                 <asp:Label ID="Label5" runat="server" Text="Last Name"></asp:Label>
             </td>
             <td>
                <asp:TextBox ID="txtLastName" runat="server" CssClass="inputs"></asp:TextBox>
             </td>
         </tr>
          <tr>
             <td>
                 <asp:Label ID="Label1" runat="server" Text="Unit No"></asp:Label>
             </td>
             <td>
                 <asp:TextBox ID="txtUnitNo" runat="server" CssClass="inputs"></asp:TextBox>
             </td>
         </tr>
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Street No"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtStreetNo" runat="server" CssClass="inputs" ></asp:TextBox>
            </td>
        </tr>
          <tr>
              <td>
                  <asp:Label ID="Label6" runat="server" Text="Street Name"></asp:Label>
              </td>
              <td>
                    <asp:TextBox ID="txtStreetName" runat="server" CssClass="inputs"></asp:TextBox>
              </td>
          </tr>
          
            <tr>
                <td>
                    <asp:Label ID="Label7" runat="server" Text="Postal Code"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtPostalCode" runat="server" CssClass="inputs"></asp:TextBox>
                </td>
            </tr>
         <tr>
             <td>
                  <asp:Label ID="Label3" runat="server" Text="Suburb"></asp:Label>
             </td>
             <td>
                <asp:TextBox ID="txtSuburb" runat="server" CssClass="inputs"></asp:TextBox>
             </td>
         </tr>
         <tr>
             <td>
                 <asp:Label ID="Label8" runat="server" Text="Phone"></asp:Label>
             </td>
             <td>
                 <asp:TextBox ID="txtphone" runat="server" CssClass="inputs"></asp:TextBox>
             </td>
         </tr>
         <div class="clearfix">
    </div>

        <tr>
            <td>

            </td>
            <td colspan ="4">
                <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Save" Height="30px" Width="108px" BackColor="#999966" />
        <asp:Button ID="btnUpdate" runat="server" OnClick="btnUpdate_Click" Text="Update" Height="30px" Width="108px" BackColor="#999966" />
         <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Clear" Height="30px" Width="108px" BackColor="#999966" />

            </td>
        </tr>

        
        <tr>
            <td></td><td colspan ="3"><asp:Label ID="litStatus" runat="server" ForeColor ="Green" ></asp:Label>
     </td>
        </tr>
  <tr>
      <td>

      </td>
      <td>
           <asp:GridView ID="gvContact" runat="server" AutoGenerateColumns ="False"   >
               <Columns>
                  
                   <asp:BoundField DataField ="ID" HeaderText="ID"  />
                   <asp:BoundField DataField ="FirstName" HeaderText="FirstName"  />
                   <asp:BoundField DataField ="LastName" HeaderText="LastName"  />
                   <asp:BoundField DataField ="UnitNo" HeaderText="UnitNo"  />
                   <asp:BoundField DataField ="StreetNo" HeaderText="StreetNo"  />
                   <asp:BoundField DataField ="StreetName" HeaderText="Street"  />
                  
                   <asp:BoundField DataField ="PostalCode" HeaderText="PostalCode"  />
                   <asp:BoundField DataField ="Phone" HeaderText="Phone"  />
                   <asp:BoundField DataField="Suburb" HeaderText="Suburb"/>
                   <asp:TemplateField>
                    <ItemTemplate>
                        <asp:LinkButton ID="listview" runat ="server" CommandArgument ='<%# Eval("ID") %>' OnClick="link_OnClick" >view</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
               </Columns>
                

           </asp:GridView><div class="clearfix">
    </div>
      </td>
  </tr>
         
           
  </table>
           <div class="clearfix">
   
       </div>
               
</asp:Content>

