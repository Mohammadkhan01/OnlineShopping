using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for HostelModel
/// </summary>
public class HostelModel
{
    public String InsertHostel(Hostel productType)
    {
        try
        {
            GarageDBEntities db = new GarageDBEntities();
            db.Hostels.Add(productType);
            db.SaveChanges();
            return productType.Address + "was successfully Inserted";
        }
        catch (Exception e)
        {
            return "Error : " + e;
        }
    }
    public String UpdateProduct(int id, Hostel productType)
    {
        try
        {
            GarageDBEntities db = new GarageDBEntities();
            Hostel p = db.Hostels.Find(id);
            p.NoOfRooms = productType.NoOfRooms;
            p.NoOfStudents = productType.NoOfStudents;
            p.Address = productType.Address;
            p.AnnualExpense = productType.AnnualExpense;
            // p.image = productType.image;
            db.SaveChanges();
            return productType.Address + " was successfully updated";
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
            Hostel productType = db.Hostels.Find(id);
            db.Hostels.Attach(productType);
            db.Hostels.Remove(productType);
            db.SaveChanges();
            return productType.HostelId + "was successfully deleted";
        }
        catch (Exception e)
        {
            return "Error : " + e;
        }
    }
    
}