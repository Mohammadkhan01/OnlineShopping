using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

using System.Data;

public partial class Pages_management : System.Web.UI.Page
{
    SqlConnection sqlcon = new SqlConnection("Data Source=148.72.232.167; Initial Catalog=GarageDB; User ID=mosiul; Password=mhkhan1A!;");
 
    protected void Page_Load(object sender, EventArgs e)
    {
        FillGridView();
    }
   

    protected void Button3_Click(object sender, EventArgs e)
    {
        hfContactID.Value = "";
        txtUnitNo.Text  =txtStreetNo.Text  =txtStreetName.Text  =txtSuburb.Text = txtFirstName.Text = txtLastName.Text   = "";
        Button3.Enabled = false;
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        if (sqlcon.State == System.Data.ConnectionState.Closed)
            sqlcon.Open();
        SqlCommand sqlCmd = new SqlCommand("ContactCreateUpdate", sqlcon);
        sqlCmd.CommandType = System.Data.CommandType.StoredProcedure;
  //      sqlCmd.Parameters.AddWithValue("@ID", (hfContactID.Value =="" ? 0 : Convert.ToInt16(hfContactID.Value)));
        sqlCmd.Parameters.AddWithValue("@FirstName", txtFirstName .Text.Trim ());
        sqlCmd.Parameters.AddWithValue("@LastName", txtLastName.Text.Trim());
        sqlCmd.Parameters.AddWithValue("@UnitNo", txtUnitNo.Text.Trim());
        sqlCmd.Parameters.AddWithValue("@StreetNo", txtStreetNo.Text.Trim());
        sqlCmd.Parameters.AddWithValue("@StreetName", txtStreetName.Text.Trim());

        sqlCmd.Parameters.AddWithValue("@Suburb", txtSuburb.Text.Trim());
        sqlCmd.Parameters.AddWithValue("@PostalCode", txtPostalCode.Text.Trim());
        sqlCmd.Parameters.AddWithValue("@Phone", txtphone .Text .Trim ());
        sqlCmd .ExecuteNonQuery ();
        sqlcon .Close ();
        litStatus .Text ="Saved Successfully";
        FillGridView();
    }
    void FillGridView()
    {
        if (sqlcon.State == System.Data.ConnectionState.Closed)
            sqlcon.Open();
        SqlDataAdapter sqlda = new SqlDataAdapter("ContactViewAll", sqlcon);
        sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataTable dtbl = new DataTable();
        sqlda.Fill(dtbl);
        
        gvContact.DataSource = dtbl;
        gvContact.DataBind();
        sqlcon.Close();
    }
    protected void link_OnClick(object sender, EventArgs e)
    {
        string ID = (sender as LinkButton).CommandArgument;
        if (sqlcon.State == ConnectionState.Closed)
            sqlcon.Open();
        SqlDataAdapter sqlda = new SqlDataAdapter("ContactViewByID", sqlcon);
        sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
        sqlda.SelectCommand.Parameters.AddWithValue("@ID", ID );
        DataTable dt = new DataTable();
        sqlda.Fill(dt);
        sqlcon.Close();
        hfContactID.Value = ID.ToString();
        txtFirstName.Text = dt.Rows[0]["FirstName"].ToString();
        txtLastName.Text = dt.Rows[0]["LastName"].ToString();
        txtUnitNo.Text = dt.Rows[0]["UnitNo"].ToString();
        txtStreetNo.Text = dt.Rows[0]["StreetNo"].ToString();
        txtStreetName.Text = dt.Rows[0]["StreetName"].ToString();

        txtSuburb.Text = dt.Rows[0]["Suburb"].ToString();
        txtPostalCode.Text = dt.Rows[0]["PostalCode"].ToString();
        txtphone.Text = dt.Rows[0]["Phone"].ToString();
    }
    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        if (sqlcon.State == ConnectionState.Closed)
            sqlcon.Open();
        SqlCommand sqlCmd = new SqlCommand("UpContactUpdate", sqlcon);
        sqlCmd.CommandType = CommandType.StoredProcedure;
       
       
        sqlCmd.Parameters.AddWithValue("@ID", (hfContactID.Value == "" ? 0 : Convert.ToInt16(hfContactID.Value)));
        sqlCmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text.Trim());
        sqlCmd.Parameters.AddWithValue("@LastName", txtLastName.Text.Trim());
        sqlCmd.Parameters.AddWithValue("@UnitNo", txtUnitNo.Text.Trim());
        sqlCmd.Parameters.AddWithValue("@StreetNo", txtStreetNo.Text.Trim());
        sqlCmd.Parameters.AddWithValue("@StreetName", txtStreetName.Text.Trim());

        sqlCmd.Parameters.AddWithValue("@Suburb", txtSuburb.Text.Trim());
        sqlCmd.Parameters.AddWithValue("@PostalCode", txtPostalCode.Text.Trim());
        sqlCmd.Parameters.AddWithValue("@Phone", txtphone.Text.Trim());
        sqlCmd.ExecuteNonQuery();
        sqlcon.Close();
        litStatus.Text = "Updated Successfully";
        FillGridView();

    }
   
}