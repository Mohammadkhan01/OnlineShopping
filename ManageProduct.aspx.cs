using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_ManageProduct : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
            GetImages();
        if (!String.IsNullOrWhiteSpace (Request.QueryString ["id"]))
        {
            int id = Convert.ToInt32(Request.QueryString["id"]);
            FillPage(id);
           
        }
        
    }

    private void FillPage(int id)
    {
        ProductModel productMode = new ProductModel();
        Product product = productMode.GetProduct(id);
        TextBox1.Text = product.Description;
        txtName.Text = product.Name;
        txtPrice.Text = product.Price.ToString ();
        ddlpicture.SelectedValue = product.image;
       // ddlType.SelectedValue = product.TypeId .ToString ();
    }
    private void GetImages()
    {
        try
        {
            string[] images = Directory.GetFiles(Server.MapPath("~/Images/Products/"));
            ArrayList imagelist = new ArrayList();
            foreach (string image in images)
            {
                string imageName = image.Substring(image.LastIndexOf(@"\", StringComparison.Ordinal) + 1);
                imagelist.Add(imageName);
            }
            ddlpicture.DataSource = imagelist;
            ddlpicture.AppendDataBoundItems = true;
            ddlpicture.DataBind();
        }
        catch(Exception e)
        {
            lblResult.Text = e.ToString();
        }

    }

    private Product CreateProduct()
    {
        Product product = new Product();
        product.Name = txtName.Text;
        product.TypeId = 1;//Convert.ToInt32(ddlType.SelectedValue);
        product.Price = Convert.ToInt32(txtPrice.Text );
        product.Description = TextBox1.Text;
        product.image = ddlpicture.SelectedValue;
        return product;


    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        ProductModel productModel = new ProductModel();
        Product product = CreateProduct();
        if (!String.IsNullOrWhiteSpace(Request.QueryString["id"]))
        {
            int id = Convert.ToInt32(Request.QueryString["id"]);
            lblResult.Text = productModel.UpdateProduct(id, product);
        }
        else { 
        lblResult.Text = productModel.InsertProduct(product);
        }
        }
    protected void ddlpicture_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}