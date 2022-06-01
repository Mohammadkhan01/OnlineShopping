using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_Account_Hostel : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
   
    protected void Button2_Click(object sender, EventArgs e)
    {
        Hostel cart = new Hostel
        {
           NoOfStudents =Convert.ToInt32(txtNoOfStudent .Text),
           NoOfRooms =Convert.ToInt32(txtNoOfRooms .Text),
           AnnualExpense =Convert.ToInt32(txtExpense .Text) ,
           Address =txtAddress .Text 
        };
        HostelModel model = new HostelModel();
        litStatus .Text = model.InsertHostel(cart);
        txtNoOfStudent.Text = "";
        txtNoOfRooms.Text = "";
        txtAddress.Text = "";
        txtExpense.Text = "";


    }
}