using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class Pages_Account_Register : System.Web.UI.Page
{
    SqlConnection sqlcon = new SqlConnection("Data Source=148.72.232.167; Initial Catalog=GarageDB; User ID=mosiul; Password=mhkhan1A!;");

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)

            if (!String.IsNullOrWhiteSpace(Request.QueryString["id"]))
            {
                int id = Convert.ToInt32(Request.QueryString["id"]);
                FillPage(id);

            }
    }
    private void FillPage(int id)
    {
        UserInfoModel productMode = new UserInfoModel();
        UserInformation product = productMode.GetUserInformation(id);
        // txtUserName.Text = product;
        txtFirstName.Text = product.FirstName;
        txtLastName.Text = product.LastName;
        txtAddress.Text = product.Address;
        txtPostalCode.Text = product.PostalCode.ToString();
        txtPhone.Text = product.Phone.ToString();


    }

    protected void Button2_Click(object sender, EventArgs ex)
    {

        UserStore<IdentityUser> userStore = new UserStore<IdentityUser>();
        userStore.Context.Database.Connection.ConnectionString =
    System.Configuration.ConfigurationManager.
        ConnectionStrings["GarageDBConnectionString"].ConnectionString;

        UserManager<IdentityUser> manager = new UserManager<IdentityUser>(userStore);

        IdentityUser user = new IdentityUser();
        user.UserName = txtUserName.Text;
        if (txtPassword.Text == txtConfirmPassword.Text)
        {
            try
            {
                IdentityResult result = manager.Create(user, txtPassword.Text);
                if (result.Succeeded)
                {
                    UserInformation info = new UserInformation
                    {
                        Address = txtAddress.Text,
                        FirstName = txtFirstName.Text,
                        LastName = txtLastName.Text,
                        PostalCode = Convert.ToInt32(txtPostalCode.Text),
                        GUID = user.Id,
                        Phone = Convert.ToInt32(txtPhone.Text),
                        Password = txtPassword.Text
                    };

                    UserInfoModel model = new UserInfoModel();
                    model.InsertUserInformation(info);
                    var authenticationManager = HttpContext.Current.GetOwinContext().Authentication;
                    var userIdentity = manager.CreateIdentity(user, DefaultAuthenticationTypes.ApplicationCookie);
                    authenticationManager.SignIn(new AuthenticationProperties(), userIdentity);
                    // Response.Redirect("~/Index.aspx");
                    litStatus.Text = "User Has Created Successfully";
                }
                else
                {
                    litStatus.Text = result.Errors.FirstOrDefault();
                }
            }
            catch (Exception e)
            {
                litStatus.Text = e.ToString();
            }
        }

    }
    void FillGridView()
    {
        if (sqlcon.State == System.Data.ConnectionState.Closed)
            sqlcon.Open();
        SqlDataAdapter sqlda = new SqlDataAdapter("ContactViewAll", sqlcon);
        sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataTable dtbl = new DataTable();
        sqlda.Fill(dtbl);
        sqlcon.Close();
    }
    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        //Get selected row
        GridViewRow row = GridView1.Rows[e.NewEditIndex];

        //Get Id of selected product
        int rowId = Convert.ToInt32(row.Cells[6].Text);

        //Redirect user to ManageProducts along with the selected rowId
        FillPage(rowId);
        Button2.Visible = false;
        Button3.Visible = true;

    }

    private UserInformation CreateProduct()
    {
        UserInformation info = new UserInformation
        {
            Address = txtAddress.Text,
            FirstName = txtFirstName.Text,
            LastName = txtLastName.Text,
            PostalCode = Convert.ToInt32(txtPostalCode.Text),

            Phone = Convert.ToInt32(txtPhone.Text),

        };
        return info;


    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        Button2.Visible = true;
        Button3.Visible = false;
        UserInfoModel productModel = new UserInfoModel();
        UserInformation product = CreateProduct();

        int id = Convert.ToInt32(Request.QueryString["id"]);
        litStatus.Text = productModel.UpdateUser(id, product);


    }

}