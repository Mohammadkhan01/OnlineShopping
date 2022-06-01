<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <div style="color: #324143; margin: 0px 0 0 0px; font-family: Arial; width: 485px;">
     <asp:Panel ID="pnlProducts" runat="server" Direction ="RightToLeft" Height="0px" Width="4px">
</asp:Panel></div>


       

<div class="clearfix">
    </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
   
    <asp:Panel ID="Panel1" runat="server" Direction ="RightToLeft" Height="1px" Width="312px">
</asp:Panel>
    <div id="inner-wrapper">
    <!--Start animation-->
        <section class="staggered-animation-container">
            <section class="os-animation" data-os-animation="zoomInLeft" data-os-animation-delay=".3">
                <section class="one-third">
                    <div class="circle">
                        <td>
                            <i class="fa fa-users"></i>
                        </td>
                    </div>
                    <h3>Daily Prayers </h3>
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Namaz" DataSourceID="SqlDataSource1" Width="311px" BackColor="#EAEAEA" BorderColor="#FF6A00" BorderStyle="Groove">
                        <Columns>
                            <asp:BoundField DataField="Namaz" HeaderText="Namaz" ReadOnly="True" SortExpression="Namaz" />
                            <asp:BoundField DataField="Namaz_Times" HeaderText="Namaz Times" SortExpression="Namaz_Times" />
                        </Columns>
                        <SelectedRowStyle BackColor="White" BorderColor="#000066" />
                        </asp:GridView>
                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:GarageDBConnectionString %>" SelectCommand="SELECT * FROM [Namaz_Time] ORDER BY [Namaz_Times]"></asp:SqlDataSource>
                   

                    <table>
                        <tr>
           <td></td>
            <td>
                <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Update" Height="30px" Width="108px" BackColor="#999966" />
       
            </td>
        </tr>
                        <tr><a href="https://gopray.com.au/place/ryde-musallah/"> For More Info : GOPRAY </a></tr>
                    </table>
                    

                        </section>
            </section>
            <section class="one-third">
                <section class="os-animation" data-os-animation="zoomInLeft" data-os-animation-delay=".3">

                    <div class="circle">
                        <td>
                            <i class="fa fa-map-marker">
                            </i>
                        </td>
                    </div>
                    <h3>Jummah </h3>
                    
                        <table align="center" cellpadding="2" cellspacing="2" border="0" bgcolor="#EAEAEA" >
      <tr align="left" style="background-color:#004080;color:White;" >
     
          <td>  178 Blaxland Road, Ryde </td><td> 1pm</td></tr>
      <tr align="left" style="background-color:#ff6a00;color:White;" >           
          <td>North Ryde Library - 201 Coxs Road, North Ryde </td><td> 1PM & 1:30PM</td></tr>
     <tr align="left" style="background-color:rgb(21, 59, 77);color:White;" >
         <td> 142 Blaxland Rd,&nbsp;

Ryde (Masonic Temple level 2 )</td><td>  1:30PM</td></tr>
                       
                        </table>
                   
                    
                </section>
</section>
            <section class="one-third">
                <section class="os-animation" data-os-animation="zoomInLeft" data-os-animation-delay=".3">

                    <div class="circle">
                        <td>
                            <i class="fa fa-check-square-o"></i>
                        </td>
                    </div>
                    <h3>Weekly Activities </h3>
                    <table align="center" cellpadding="2" cellspacing="2" border="0" bgcolor="#EAEAEA" >
                      <tr align="left" style="background-color:rgb(21, 59, 77);color:White;" >
                       
                         <td>Bukhari Hadis reminder</td><td>After every Fazr & Magrib</td> </tr>
                    <tr align="left" style="background-color:#ff6a00;color:White;" >   
                            <td>Hifz Class for Men/Women &amp; Children</td>
                        <td>Every Tuesday and Thursday after Asr</td></tr>
                    
                                     </table>
                     <span style="color: rgb(255, 255, 255); font-family: Verdana, Geneva, sans-serif; font-size: 11px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: justify; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(21, 59, 77); text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">Quran Taught by: Sheikh Rehan<span>&nbsp;</span></span></p>
   <span style="color: rgb(0, 255, 0); font-family: Verdana, Geneva, sans-serif; font-size: 11px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: justify; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(0, 0, 255); text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">Hadis Taught by: Sheikh Tanzil</span></p>

                    <span style="color: rgb(255, 0, 0); font-family: Verdana, Geneva, sans-serif; font-size: smaller; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: justify; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">Fiqah, Hadis, Fatwa, Question & Answer: Sheikh Salman</span></p>
                </section>
                </section>
            <div class="clearfix"></div>
            <section class="os-animation" data-os-animation="fadeInRightzoomInLeft" data-os-animation-delay=".3">

                <article>
                   
    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:GarageDBConnectionString %>" SelectCommand="SELECT [Description] FROM [Product] ORDER BY [Id] DESC"></asp:SqlDataSource>
                    <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource2">
                        <Columns>
                            <asp:BoundField DataField="Description" HeaderText="Description" SortExpression="Description" />
                        </Columns>
                    </asp:GridView>
                    <br />
                    <br />
                    &nbsp;<asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="ANNOUNCEMENT" BackColor="#CC6600" ForeColor="#000099" Height="26px" Width="187px" />
                    <br />
                </article>
                    
                    <h4 >Five pillar of Islam ?</h4>
                <aside>
                    
                    <br>

                    <ul class="gym">
                        <li><h5>Kalima</h5></li>
                        <li><h5>Namaj </h5></li>
                        <li><h5>Saom</h5></li>
                        <li><h5>Hazz</h5></li>
                        <li><h5>Zakat</h5></li>
                    </ul>
                    For more info pls visit <a href="http://navedz.com/category/islam" />Informaiton </a>

                </aside>
                </section>
            <div class="clearfix"></div>
            
                
                   
            <section class="os-animation" data-os-animation="zoomInLeft" data-os-animation-delay=".3">

                <section class="one-third">
                    <h3>Recent News</h3>
                    
                    <p>
                         <p><strong>Ramadan</strong></p>
<p>&nbsp;Ramadan 2019 will begin on Monday, 6th May 2019 (according to Saudi Arabia) and end on Tuesday, 4th June 2019. Eid al Fitr 2019 will be on Wednesday, 5th June 2019. This is the tentative date as the actual date is contingent on the sighting of the moon of Ramadan 2019, the 9th month in the Islamic calendar (Hijri 1440). The length of the Month varies between 29 and 30 days depending on the sighting of the Shawwal Moon which leads to the awaited festival of Eid ul Fitr on the 1st of Shawwal.</p>
<p>Fasting was made obligatory on all adult Muslims in the Second Year of Hijri (Migration from Makkah to Madinah of Muslims). The only people exempted from keeping a fast are the ones who are travelling, aged, pregnant, diabetic, chronically ill, menstruating or breast feeding. Many children endeavour to complete as many fasts as possible as practice for later life.</p>    
      

</p>

                </section>
                </section>
            <section class="os-animation" data-os-animation="zoomInLeft" data-os-animation-delay=".3">

                <section class="one-third">
                    <h3>Ryde Musallah Info</h3>
                    &nbsp;<p> 


Facilities
Wudu in back yard area with 3 toilets.

Sisters prayer room at back. Sister’s wudu area available. Entry through side entrance opposite of driveway.
                </section>
                </section>
            <section class="os-animation" data-os-animation="zoomInLeft" data-os-animation-delay=".3">

                <section class="one-third">
                    <h3>Tablig jamat</h3>
                    <img src="../img/logo mosque1.jpg" />
                    <p>Tablig Jamat : Tablighi Jamaat is a very spiritual, religious and movement (optional travel is a lot) based group of Muslims, inspiring people to come to the religion like it should be done (like the Prophets spread the Deen) and motivating the spread of Amaal (actions).</br>
                        Calling people towards Allah is every peoples duty. We have jawla every saturday. Every month, A group of people from this mosque are going out for tablig for 3 days atleast.</p>

                </section>
                </section>

            </section>

    </div><!----end inner wrapper-->
    <div class="clearfix"></div>
    
</asp:Content>

