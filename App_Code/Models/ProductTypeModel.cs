using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ProductTypeTypeModel
/// </summary>
public class ProductTypeModel
{
    public String InsertProductType(ProductType productType)
    {
        try
        {
            GarageDBEntities db = new GarageDBEntities();
            db.ProductTypes.Add(productType);
            db.SaveChanges();
            return productType.Name + "was successfully Inserted";
        }
        catch (Exception e)
        {
            return "Error : " + e;
        }
    }
    public String UpdateProductType(int id, ProductType productType)
    {
        try
        {
            GarageDBEntities db = new GarageDBEntities();
            ProductType p = db.ProductTypes.Find(id);
            p.Name = productType.Name;
           
            db.SaveChanges();
            return productType.Name + " was successfully updated";
        }
        catch (Exception e)
        {
            return "Error : " + e;
        }

    }
    public String DeleteProductType(int id)
    {
        try
        {
            GarageDBEntities db = new GarageDBEntities();
            ProductType productType = db.ProductTypes.Find(id);
            db.ProductTypes.Attach(productType);
            db.ProductTypes.Remove(productType);
            db.SaveChanges();
            return productType.Name + "was successfully deleted";
        }
        catch (Exception e)
        {
            return "Error : " + e;
        }
    }
}