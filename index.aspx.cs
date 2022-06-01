using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet .Identity ;
using System.Collections;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class index : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        fillpages();
    }

    private void fillpages()
    {
       // Label3.Text = (ddlType.SelectedValue);
        //String mycon1 = "Data Source=148.72.232.167; Initial Catalog=GarageDB; User ID=mosiul; Password=mhkhan1A!";
        //SqlConnection scon1 = new SqlConnection(mycon1);
        //String myquery1 = "select max(Id) from Product ";
        //SqlCommand cmd1 = new SqlCommand();
        //cmd1.CommandText = myquery1;
        //cmd1.Connection = scon1;
        //SqlDataAdapter da1 = new SqlDataAdapter();
        //da1.SelectCommand = cmd1;
        //DataSet ds1 = new DataSet();
        //da1.Fill(ds1);
        //Label3.Text = ds1.Tables[0].Rows[0][0].ToString();
        //TextBox1.Text = ds1.Tables[0].Rows[0][0].ToString();
       
      
        //scon1.Close();
        

          
            //int id = Convert.ToInt32(Label3.Text);
        //ddlType.SelectedValue = 1;





        ProductModel productModel = new ProductModel();
        //Product product = productModel.GetProduct(1);
       // Product product = productModel.GetProduct(Label3.Text);
       // TextBox1.Text = product.Description;
            //lblPrice.Text = "Price per Unit: <br/>$ " + product.Price;
            //lblTitle.Text = product.Name;
           // Textbox1.Text = product.Description;
            //lblTemName.Text = id.ToString();
            //imgProduct.ImageUrl = "~/Images/Products/" + product.image;
           // int[] amount = Enumerable.Range(1, 20).ToArray();
            //ddlAmount.DataSource = amount;
           // ddlAmount.AppendDataBoundItems = true;
           // ddlAmount.DataBind();


        }
    
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("NamazTime.aspx");
    }
    protected void Button1_Click1(object sender, EventArgs e)
    {
        Response.Redirect("ManageProduct.aspx");
    }
}

    //protected void btnAdd_Click1(object sender, EventArgs e)
    //{
    //    if (!string.IsNullOrWhiteSpace(Request.QueryString["id"]))
    //    {
    //        string clientid = Context.User.Identity.GetUserId();

    //        if (clientid != null)
    //        {
    //            int id = Convert.ToInt32(Request.QueryString["id"]);
    //            int amount = Convert.ToInt32(ddlAmount.SelectedValue);
    //            Cart cart = new Cart
    //            {
    //                Amount = amount,
    //                ClientId = clientid,
    //                DatePurchased = DateTime.Now,
    //                IsInCart = true,
    //                ProductId = id
    //            };
    //            CartModel model = new CartModel();
    //            lblResult.Text = model.InsertCart(cart);
    //        }
    //    }
    //    else
    //    {
    //        lblResult.Text = "Please Log in";

    //    }
    //}
   
//    private void Delete_Item(object sender, EventArgs e)
//    {
//        Button selectLink = (Button)sender;
//        string link = selectLink.ID.Replace("del", "");
//        int productId = Convert.ToInt32(link);
//        // int cartId = Convert.ToInt32(link);
//        Label lblResult = new Label();

//        ContentPlaceHolder cph = (ContentPlaceHolder)Master.FindControl("ContentPlaceHolder2");
//        ControlFinder<DropDownList> cf = new ControlFinder<DropDownList>();
//        cf.FindChildControlRecursive(cph);

//        var btlist = cf.FoundControl;
//        foreach (DropDownList dp in btlist)
//        { 
//            int amount = Convert.ToInt32(dp.SelectedValue);
//            if (amount !=0)
//            {

//                string clientid = Context.User.Identity.GetUserId();


//                if (clientid != null)
//                {
//                    int id = productId;
//                    // int amount = Convert.ToInt32 (DropDownList)
//                    Cart cart = new Cart
//                    {
//                        Amount = amount,
//                        ClientId = clientid,
//                        DatePurchased = DateTime.Now,
//                        IsInCart = true,
//                        ProductId = id
//                    };
//                    CartModel model1 = new CartModel();
//                    lblResult.Text = model1.InsertCart(cart);
//                    lblResult.Text = "Successfully added";
//                    Response.Redirect("~/index.aspx");

//                }
//            }
            
//        }
//    }
//             public void ddlAmount_SelectedIndexChanged(object sender, EventArgs e)
//{
//    DropDownList selectedList = (DropDownList)sender;
//    int quantity = Convert.ToInt32(selectedList.SelectedValue);
//    //return quantity;
//             }
//      public void fillpage()
//    {
//       // pnlProducts.Controls.Clear();
//        ProductModel productModel = new ProductModel();
//       // List<Product> products = productModel.GetProductByType(Convert.ToInt32 (ddlType .SelectedValue) );
//        List<Product> products = productModel.GetAllProduct();

//        if(products !=null)
//        {
//            foreach (Product product in products)
//            {
//                Panel productPanel = new Panel();
//                ImageButton imagebutton = new ImageButton();
//                Label lblName = new Label();
//                Label price = new Label();
//                Button lnkDelete = new Button
//                {
//                    //PostBackUrl = string.Format("~/Pages/ShoppingCart.aspx?productId={0}", cart.Id),
//                    Text = "Add Item",
//                    ID = "del" + product.Id
//                };
//                lnkDelete.Click += Delete_Item;
//                int[] amount = Enumerable.Range(0, 10).ToArray();
//                DropDownList ddlAmount = new DropDownList
//                {
//                    DataSource = amount,
//                    AppendDataBoundItems = true,
//                    AutoPostBack = true,
//                    ID = product.Id.ToString()


//                };
                
//                 ddlAmount .DataBind ();
//           // ddlAmount .SelectedValue =cart.Amount .ToString ();
//            ddlAmount .SelectedIndexChanged +=ddlAmount_SelectedIndexChanged;

//                imagebutton.ImageUrl = "~/Images/" + product.image;
//                imagebutton.CssClass = "productImage";
//                imagebutton.PostBackUrl = "~/Pages/Product.aspx?id=" + product.Id;
               
               
//                lblName.Text = product.Name;
//                lblName.CssClass = "productName";
//                price.Text = "$ "+product.Price;
//                productPanel.Controls.Add(imagebutton);
//                productPanel.Controls.Add(new Literal { Text = "<br/>" });
//                productPanel.Controls.Add(lblName);
//                productPanel.Controls.Add(new Literal { Text = "<br/>" });
//                productPanel.Controls.Add(price);
//                productPanel.Controls.Add(new Literal { Text = "<br/>" });
//                productPanel.Controls.Add(ddlAmount );
//                //productPanel.Controls.Add(reg);
//                productPanel.Controls.Add(new Literal { Text = "<br/>" });
//                productPanel.Controls.Add(lnkDelete );
               
//                pnlProducts.Controls.Add(productPanel);
               

//            }
//        }else
//        {
//            pnlProducts.Controls.Add(new Literal { Text = "No Product Found" });
//        }

//    }
//    protected void ddlType_SelectedIndexChanged(object sender, EventArgs e)
//      {
//         // pnlProducts.Controls.Clear();
//         ProductModel productModel = new ProductModel();
//           List<Product> products = productModel.GetProductByType(Convert.ToInt32 (ddlType.SelectedValue) );
//         // List<Product> products = productModel.GetAllProduct();

//          if (products != null && ViewState ["controls"]==null)
//          {
//              foreach (Product product in products)
//              {
//                  Panel productPanel = new Panel();
//                  ImageButton imagebutton = new ImageButton();
//                  Label lblName = new Label();
//                  Label price = new Label();
//                  Button lnkDelete = new Button
//                  {
//                      //PostBackUrl = string.Format("~/Pages/ShoppingCart.aspx?productId={0}", cart.Id),
//                      Text = "Add Item",
//                      ID = "del" + product.Id
//                  };
//                  lnkDelete.Click += Delete_Item;
//                  int[] amount = Enumerable.Range(0, 10).ToArray();
//                  DropDownList ddlAmount = new DropDownList
//                  {
//                      DataSource = amount,
//                      AppendDataBoundItems = true,
//                      AutoPostBack = true,
//                      ID = product.Id.ToString()


//                  };

//                  ddlAmount.DataBind();
//                  // ddlAmount .SelectedValue =cart.Amount .ToString ();
//                  ddlAmount.SelectedIndexChanged += ddlAmount_SelectedIndexChanged;

//                  imagebutton.ImageUrl = "~/Images/" + product.image;
//                  imagebutton.CssClass = "productImage";
//                  imagebutton.PostBackUrl = "~/Pages/Product.aspx?id=" + product.Id;


//                  lblName.Text = product.Name;
//                  lblName.CssClass = "productName";
//                  price.Text = "$ " + product.Price;
//                  productPanel.Controls.Add(imagebutton);
//                  productPanel.Controls.Add(new Literal { Text = "<br/>" });
//                  productPanel.Controls.Add(lblName);
//                  productPanel.Controls.Add(new Literal { Text = "<br/>" });
//                  productPanel.Controls.Add(price);
//                  productPanel.Controls.Add(new Literal { Text = "<br/>" });
//                  productPanel.Controls.Add(ddlAmount);
//                  //productPanel.Controls.Add(reg);
//                  productPanel.Controls.Add(new Literal { Text = "<br/>" });
//                  productPanel.Controls.Add(lnkDelete);

//                  pnlProducts.Controls.Add(productPanel);


//              }
//          }
//          else
//          {
//              pnlProducts.Controls.Add(new Literal { Text = "No Product Found" });
//          }
//      }
//    protected void PayWithPayPal(string amount, string itemInfo, string name,
//             string phone, string email, string currency)
//    {
//        string redirecturl = "";

//        //Mention URL to redirect content to paypal site
//        redirecturl += "https://www.paypal.com/cgi-bin/webscr?cmd=_xclick&business=" +
//                       ConfigurationManager.AppSettings["paypalemail"].ToString();

//        //First name i assign static based on login details assign this value
//        redirecturl += "&first_name=" + name;

//        //City i assign static based on login user detail you change this value
//        redirecturl += "&city=bhubaneswar";

//        //State i assign static based on login user detail you change this value
//        redirecturl += "&state=Odisha";

//        //Product Name
//        redirecturl += "&item_name=" + itemInfo;

//        //Product Name
//        redirecturl += "&amount=" + amount;

//        //Phone No
//        redirecturl += "&night_phone_a=" + phone;

//        //Product Name
//        redirecturl += "&item_name=" + itemInfo;

//        //Address 
//        redirecturl += "&address1=" + email;

//        //Business contact id
//        // redirecturl += "&business=k.tapankumar@gmail.com";

//        //Shipping charges if any
//        redirecturl += "&shipping=0";

//        //Handling charges if any
//        redirecturl += "&handling=0";

//        //Tax amount if any
//        redirecturl += "&tax=0";

//        //Add quatity i added one only statically 
//        redirecturl += "&quantity=1";

//        //Currency code 
//        redirecturl += "&currency=" + currency;

//        //Success return page url
//        redirecturl += "&return=" +
//          ConfigurationManager.AppSettings["SuccessURL"].ToString();

//        //Failed return page url
//        redirecturl += "&cancel_return=" +
//          ConfigurationManager.AppSettings["FailedURL"].ToString();

//        Response.Redirect(redirecturl);
//    }
//    protected void btnPay_AsPerYourChoice(object sender, EventArgs e)
//    {
//        List<Cart> carts = (List<Cart>)Session[User.Identity.GetUserId()];
//        CartModel model = new CartModel();
//        String a = model.ToString();
//        PayWithPayPal(txtAmount.Text, a, txtName.Text, txtPhone.Text, txtEmail.Text, ddlCurrency.Text);
//    }
//    protected void Button1_Click(object sender, EventArgs e)
//    {
//        List<Cart> carts = (List<Cart>)Session[User.Identity.GetUserId()];
//        CartModel model = new CartModel();
//        String a = model.ToString();
//        PayWithPayPal(txtAmount.Text, a, txtName.Text, txtPhone.Text, txtEmail.Text, ddlCurrency.Text);
//       // PayWithPayPal(txtAmount.Text, txtSubject.Text, txtName.Text,
//        //     txtPhone.Text, txtEmail.Text, ddlCurrency.Text);
//        Label2.Text = "Successfully Paid. Thanks for your donation";
//    }
   
