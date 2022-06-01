using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ProductModel
/// </summary>
public class ProductModel
{
	public String InsertProduct(Product productType)
    {
        try {
            GarageDBEntities db = new GarageDBEntities();
            db.Products.Add(productType);
            db.SaveChanges();
            return productType.Name + "was successfully Inserted";
        }
        catch(Exception e)
        {
            return "Error : " + e;
        }
    }
    public String UpdateProduct(int id, Product productType)

    {
        try
        {
            GarageDBEntities db = new GarageDBEntities();
            Product p = db.Products.Find(id);
            p.Name = productType.Name;
            p.Price = productType.Price;
            p.TypeId = productType.TypeId;
            p.Description = productType.Description;
            p.image = productType.image;
            db.SaveChanges();
            return productType.Name + " was successfully updated";
        }
        catch (Exception e)
        {
            return "Error : " + e;
        }

    }
    public String DeleteProduct(int id)

    {
        try 
        {
            GarageDBEntities db = new GarageDBEntities();
            Product productType = db.Products.Find(id);
            db.Products.Attach(productType);
            db.Products.Remove(productType);
            db.SaveChanges();
            return productType.Name + "was successfully deleted";
        }
        catch (Exception e)
        {
            return "Error : " + e;
        }
    }
    public Product GetProduct(int id)
    {
        try
        {
            using (GarageDBEntities db = new GarageDBEntities())
            {
                Product product = db.Products.Find(id);
                return product;
            }
        }
        catch(Exception )
        {
            return null;
        }
    }
    public Product GetProductS(string Name)
    {
        try
        {
            using (GarageDBEntities db = new GarageDBEntities())
            {
                Product product = db.Products.Find(Name);
                return product;
            }
        }
        catch (Exception)
        {
            return null;
        }
    }
    public List<Product > GetAllProduct()
    {
        try
        {
            using(GarageDBEntities db=new GarageDBEntities ())
            {
                List<Product> products = (from x in db.Products
                                          select x).ToList();
                return products;
            }
        }
        catch(Exception )
        {
            return null;
        }
    }

    public List<Product> GetProductByType(int typeid)
    {
        try
        {
            using (GarageDBEntities db = new GarageDBEntities())
            {
                List<Product> products = (from x in db.Products
                                          where x.TypeId  ==typeid  select x). ToList();
                return products;
            }
        }
        catch (Exception)
        {
            return null;
        }
    }
}