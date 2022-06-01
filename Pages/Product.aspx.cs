using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Identity;
public partial class Pages_Product : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        fillpages();
    }
   
    private void fillpages()
    {
        if(!String.IsNullOrWhiteSpace (Request .QueryString ["id"]))
        {
            int id=Convert.ToInt32 (Request .QueryString ["id"]);
            ProductModel productModel=new ProductModel();
            Product  product=productModel .GetProduct(id);

            lblPrice.Text ="Price per Unit: <br/>$ "+product.Price;
            lblTitle.Text = product.Name ;
            lblDescription.Text = product.Description;
            lblTemName.Text = id.ToString();
            imgProduct.ImageUrl = "~/Images/Products/" + product.image;
            int[] amount = Enumerable.Range(1, 20).ToArray();
            ddlAmount.DataSource = amount;
            ddlAmount.AppendDataBoundItems = true;
            ddlAmount.DataBind();


        }
    }

protected void btnAdd_Click1(object sender, EventArgs e)
{
    if (!string.IsNullOrWhiteSpace(Request.QueryString["id"]))
    {
        string clientid = Context.User.Identity.GetUserId();

        if (clientid != null)
        {
            int id = Convert.ToInt32(Request.QueryString["id"]);
            int amount = Convert.ToInt32(ddlAmount.SelectedValue);
            Cart cart = new Cart
            {
                Amount = amount,
                ClientId = clientid,
                DatePurchased = DateTime.Now,
                IsInCart = true,
                ProductId = id
            };
            CartModel model = new CartModel();
            lblResult.Text = model.InsertCart(cart);
        }
    }
    else
    {
        lblResult.Text = "Please Log in";

    }
}
}