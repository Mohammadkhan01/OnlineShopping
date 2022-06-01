<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="NamazTIme.aspx.cs" Inherits="NamazTIme" %>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">

      
               
    <div>
    
               
                   <table>
                   
                    <h3>Time Table of daily Prayers
                    
                    <tr><td><asp:TextBox ID="Label1" runat="server" Text="Namaz"></asp:TextBox></td>
                        <td><asp:TextBox ID="TextBox1" runat="server" Height="16px" Width="109px" TextMode="Time">4:30 AM</asp:TextBox>
                        </td></tr>
                        
    </h3>
        <br />



        
        <tr>
            <td></td><td colspan ="3"><asp:Label ID="litStatus" runat="server" ForeColor ="Green" ></asp:Label>
     </td>
        </tr>
  <tr>
      <td>
          Namaz TImes</td>
      <td>
           <asp:GridView ID="gvContact" runat="server" AutoGenerateColumns ="False" CellPadding="4" ForeColor="#333333" GridLines="None" Width="449px"  >
               <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
               <Columns>
                  
                   <asp:BoundField DataField ="Namaz" HeaderText="Namaz Name"  />
                   <asp:BoundField DataField ="Namaz_Times" HeaderText="Time "  />
                    <asp:TemplateField>
                    <ItemTemplate>
                        <asp:LinkButton ID="listview" runat ="server" CommandArgument ='<%# Eval("Namaz") %>' OnClick="link_OnClick" >view</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
               </Columns>
                

               <EditRowStyle BackColor="#999999" />
               <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
               <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
               <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
               <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
               <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
               <SortedAscendingCellStyle BackColor="#E9E7E2" />
               <SortedAscendingHeaderStyle BackColor="#506C8C" />
               <SortedDescendingCellStyle BackColor="#FFFDF8" />
               <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                

           </asp:GridView><div class="clearfix">
    </div>
      </td>
  </tr>
                       
        <tr>
           <td></td>
            <td>
                <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text=""   Height="0px" Width="0px" BackColor="Transparent" />
        <asp:Button ID="btnUpdate" runat="server" OnClick="btnUpdate_Click" Text="Update" Height="30px" Width="108px" BackColor="#999966" />
         <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Clear" Height="30px" Width="108px" BackColor="#999966" />

            </td>
        </tr>
        
  </table>
           
                        

                      
    
    </div>
   
</asp:Content>
