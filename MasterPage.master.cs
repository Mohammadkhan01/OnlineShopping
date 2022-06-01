using System;

using System.Web;
using Microsoft.Owin.Security;
using Microsoft.AspNet.Identity;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Data;
using System.Data.SqlClient;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {        /*var user = Context.User.Identity;
        if (user.IsAuthenticated )
        {
            litStatus.Text = Context.User.Identity.Name;
            lnkLogin.Visible = false;
            lnkRegister.Visible = false;

            lnkLLogout.Visible = true;
            litStatus.Visible = true;

            CartModel model = new CartModel();
            string UserId = HttpContext.Current.User.Identity.GetUserId();
            litStatus.Text = string.Format("{0} ({1})", Context.User.Identity.Name,
                model.GetAmountOfOrders(UserId));

        }
        else
        {
            lnkLogin.Visible = true;
            lnkRegister.Visible = true;

            lnkLLogout.Visible = false;
            litStatus.Visible = false;
        }
         */
    }
    protected void lnkLLogout_Click(object sender, EventArgs e)
    {
        var authenticationManager = HttpContext.Current.GetOwinContext().Authentication;
        authenticationManager.SignOut();
        Response.Redirect("~/index.aspx");

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        String mycon1 = "Data Source=148.72.232.167; Initial Catalog=GarageDB; User ID=mosiul; Password=mhkhan1A!";
        SqlConnection scon1 = new SqlConnection(mycon1);
        String myquery1 = "select max(Id) from ProductTypes";
        SqlCommand cmd1 = new SqlCommand();
        cmd1.CommandText = myquery1;
        cmd1.Connection = scon1;
        SqlDataAdapter da1 = new SqlDataAdapter();
        da1.SelectCommand = cmd1;
        DataSet ds1 = new DataSet();
        da1.Fill(ds1);
        Label2.Text = ds1.Tables[0].Rows[0][0].ToString();
        int a;
        a = Convert.ToInt16(Label2.Text);
        a = a + 1;
        Label2.Text = a.ToString();
        scon1.Close();
         ProductType  info = new ProductType
            {
                Id= Convert.ToInt16(Label2 .Text),
                Name  = TxtSubject0 .Text 

            };

            ProductTypeModel model = new ProductTypeModel ();
            model.InsertProductType (info);
            Label1.Text = "successfully Saved";
            Label2.Text = "";
            TxtSubject0.Text = "";
        
        //try
        //{
        //    MailMessage mailMessage = new MailMessage();
        //    mailMessage.From = new MailAddress("info@rydemussallah.com");
        //    mailMessage.To.Add("info@rydemussallah.com");
        //    mailMessage.Subject = TxtSubject0.Text;
        //    mailMessage.Body = "<b> sender name :</b> " + TxtName.Text + "</br>"
        //    + "<b> sender email :</b> " + TxtSubject0.Text + "</br>"
        //    + "<b> Comments :</b> " + TxtComment.Text;
        //    mailMessage.IsBodyHtml = true;

        //    //SmtpClient client = new SmtpClient();

        //    // client.UseDefaultCredentials = false;
        //    // client.Credentials = new NetworkCredential("uploader1177@sg2nwvpweb009.shr.prod.sin2.secureserver.net", "mhkhann1A!");


        //    SmtpClient client = new SmtpClient();
        //    client.Host = "smtp.office365.com";
        //    client.EnableSsl = false;
        //    client.UseDefaultCredentials = false;
        //    client.Port = 25;
        //    client.Host = "relay-hosting.secureserver.net";
        //     client .Credentials =new System .Net .NetworkCredential("info@rydemussallah.com","mussallah1!");
        //    client.Port = 25;
        //    client.EnableSsl = true;

        //    client.Send(mailMessage);
        //    Label1.ForeColor = System.Drawing.Color.Blue;
        //    Label1.Text = "Thank you for contacting us";

        //    TxtName.Enabled = false;
        //    TxtEmail.Enabled = false;
        //    TxtSubject.Enabled = false;
        //    TxtComment.Enabled = false;
        //    Button1.Enabled = false;
        //}
        //catch (Exception ex)
        //{
        //    Label1.ForeColor = System.Drawing.Color.Blue;
        //    Label1.ForeColor = System.Drawing.Color.Red;
        //    Label1.Text = "There is unknown problem. Please try again later" + ex.ToString();
        //}

        
    }
    
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            DateTime dt = DateTime.Today; // Or whatever
            // DateTime s = dt.ToString("yyyyMMdd");
            Comment info = new Comment
            {
                Commentss = TxtComment.Text,
                subject = TxtSubject.Text,
                email = TxtEmail.Text,
                date = dt

            };

            CommentInfo model = new CommentInfo();
            model.InsertComment(info);
            Label1.Text = "successfully Saved";
            TxtComment.Text = "";
            TxtEmail.Text = "";
            TxtName.Text = "";
            TxtSubject.Text = "";
        }
        catch (Exception ex)
        {
            Label1.ForeColor = System.Drawing.Color.Blue;
            Label1.ForeColor = System.Drawing.Color.Red;
            Label1.Text = "There is unknown problem. Please try again later" + ex.ToString();
        }
    }
}
