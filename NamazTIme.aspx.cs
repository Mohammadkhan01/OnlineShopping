using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class NamazTIme : System.Web.UI.Page
{
    SqlConnection sqlcon = new SqlConnection("Data Source=148.72.232.167; Initial Catalog=GarageDB; User ID=mosiul; Password=mhkhan1A!;");

    protected void Page_Load(object sender, EventArgs e)
    {
        FillGridView();
    }


    protected void Button3_Click(object sender, EventArgs e)
    {

        TextBox1.Text = "";
        Button3.Enabled = false;
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        if (sqlcon.State == System.Data.ConnectionState.Closed)
            sqlcon.Open();
        SqlCommand sqlCmd = new SqlCommand("AddNamazTime", sqlcon);
        sqlCmd.CommandType = System.Data.CommandType.StoredProcedure;
        sqlCmd.Parameters.AddWithValue("@Namaz", Label1.Text.Trim());
        sqlCmd.Parameters.AddWithValue("@Namaz_Times", TextBox1.Text.Trim());
        sqlCmd.ExecuteNonQuery();
        sqlcon.Close();
        litStatus.Text = "Saved Successfully";
        FillGridView();
    }
    void FillGridView()
    {
        if (sqlcon.State == System.Data.ConnectionState.Closed)
            sqlcon.Open();
        SqlDataAdapter sqlda = new SqlDataAdapter("NamazViewAll", sqlcon);
        sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataTable dtbl = new DataTable();
        sqlda.Fill(dtbl);

        gvContact.DataSource = dtbl;
        gvContact.DataBind();
        sqlcon.Close();
    }
    protected void link_OnClick(object sender, EventArgs e)
    {
        var ID = (sender as LinkButton).CommandArgument;
        if (sqlcon.State == ConnectionState.Closed)
            sqlcon.Open();
        SqlDataAdapter sqlda = new SqlDataAdapter("NamazViewByID", sqlcon);
        sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
        sqlda.SelectCommand.Parameters.AddWithValue("@Namaz", ID);
        DataTable dt = new DataTable();
        sqlda.Fill(dt);
        sqlcon.Close();

        Label1.Text = dt.Rows[0]["Namaz"].ToString();

        TextBox1.Text = dt.Rows[0]["Namaz_Times"].ToString();
        
    }
    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        if (sqlcon.State == ConnectionState.Closed)
            sqlcon.Open();
        SqlCommand sqlCmd = new SqlCommand("UpNamazTime", sqlcon);
        sqlCmd.CommandType = CommandType.StoredProcedure;


        sqlCmd.Parameters.AddWithValue("@Namaz", Label1.Text.Trim());

        sqlCmd.Parameters.AddWithValue("@Namaz_Times", TextBox1.Text.Trim());
        sqlCmd.ExecuteNonQuery();
        sqlcon.Close();
        litStatus.Text = "Updated Successfully";
        FillGridView();

    }


   
}