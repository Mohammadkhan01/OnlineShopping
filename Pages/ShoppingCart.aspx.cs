using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Identity;


public partial class Pages_ShoppingCart :Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string userId = User.Identity.GetUserId();
        GetPurchaseInCart(userId);
    }

    private void GetPurchaseInCart(string userId)
    {
        CartModel model = new CartModel();
        double subTotl = 0;
        List<Cart> purchaseList = model.GetOrdersInCart(userId);
        CreateShopTable(purchaseList, out  subTotl);

        double vat=subTotl *0.21;
        double totalAmount=subTotl +vat+10;

        litTotal .Text="$"+subTotl ;
        litVat.Text ="$"+vat;
        litTotalAmount.Text ="$"+totalAmount ;

    }

    private void CreateShopTable(List<Cart> purchaseList, out double subTotl)
    {
        subTotl = new double();
        ProductModel model = new ProductModel();
        foreach(Cart cart in purchaseList )
        {
            Product product = model.GetProduct(cart.ProductId);
            ImageButton btnimage=new ImageButton 
            {
                ImageUrl =string.Format ("~/Images/{0}",product.image  ),
                PostBackUrl=string.Format ("~/Pages/Product.aspx?id={0}",product.Id )
        
        };
            LinkButton lnkDelete=new LinkButton 
            {
                PostBackUrl =string.Format ("~/Pages/ShoppingCart.aspx?productId={0}",cart.Id ),
                Text ="Delete Item",
                ID ="del"+cart.Id 
            };
            lnkDelete .Click +=Delete_Item;
            int[]amount=Enumerable .Range (1,20).ToArray();
            DropDownList ddlAmount=new DropDownList 
            {
                DataSource =amount,
                AppendDataBoundItems =true,
                AutoPostBack =true,
                ID =cart.Id.ToString ()


            };

            ddlAmount .DataBind ();
            ddlAmount .SelectedValue =cart.Amount .ToString ();
            ddlAmount .SelectedIndexChanged +=ddlAmount_SelectedIndexChanged;

           // Table table=new Table{CssClass ="cartTable"};
            Table table = new Table();
            TableRow a=new TableRow ();
            TableRow b=new TableRow ();
            

            TableCell a1=new TableCell{RowSpan =2, Width=50};
            TableCell a2=new TableCell {Text =string.Format ("<h4>{0}</h4><br/>{1}</br>In stock",
                product .Name , "Item No : "+product .Id ),
            HorizontalAlign =HorizontalAlign .Left , Width =350};

            TableCell a3=new TableCell {Text="Unit price<hr/>"};
            TableCell a4=new TableCell {Text="Quantity<hr/>"};
            TableCell a5=new TableCell {Text ="Item Total<hr/>"};
            TableCell a6=new TableCell {};

            TableCell b1=new TableCell {};
            TableCell b2=new TableCell {Text="$ "+product.Price };
            TableCell b3=new TableCell {};
            TableCell b4=new TableCell {Text="$ "+ (cart.Amount * product.Price)};
            TableCell b5=new TableCell {};
            TableCell b6=new TableCell {};
            
            a1.Controls .Add(btnimage );
            a6.Controls .Add(lnkDelete );
            b3.Controls .Add (ddlAmount );

            
            a.Cells .Add(a1);
            a.Cells .Add(a2);
            a.Cells .Add(a3);
            a.Cells .Add(a4);
            a.Cells .Add(a5);
            a.Cells .Add(a6);

            b.Cells .Add(b1);
             b.Cells .Add(b2);
             b.Cells .Add(b3);
             b.Cells .Add(b4);
             b.Cells .Add(b5);
             b.Cells .Add(b6);


            // table.Rows.Add(a);
           // table.Rows .Add(b);
           // pnlShoppingCart.Controls.Add(table);
           // pnlShoppingCart.Controls.Add(table);
            subTotl +=Convert.ToInt32 (cart.Amount *product .Price );
             

            Session[User.Identity .GetUserId ()]=purchaseList ;


        
        }
        }

private void ddlAmount_SelectedIndexChanged(object sender, EventArgs e)
{
    DropDownList selectedList = (DropDownList)sender;
    int quantity = Convert.ToInt32(selectedList.SelectedValue);
    int cartid = Convert.ToInt32(selectedList.ID);

    CartModel model = new CartModel();
    model.UpdateQuantity(cartid, quantity);
    Response.Redirect("~/Pages/ShoppingCart.aspx");
}

private void Delete_Item(object sender, EventArgs e)
{
    LinkButton selectLink = (LinkButton)sender;
    string link = selectLink.ID.Replace("del", "");
    int cartId = Convert.ToInt32(link);

    CartModel model = new CartModel();
    model.DeleteCart(cartId);
    Response.Redirect("~/Pages/ShoppingCart.aspx");

}
protected void btnCheckOut_Click(object sender, EventArgs e)
{
    
    Response.Redirect("~/Pages/Success.aspx");
}
}
