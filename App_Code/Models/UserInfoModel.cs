using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for UserInfoModel
/// </summary>
public class UserInfoModel
{
	public UserInformation GetUserInformation(int guid)
    {
        GarageDBEntities db = new GarageDBEntities();
        UserInformation info = (from x in db.UserInformations
                                where x.ID == guid
                                select x).FirstOrDefault();
        return info;
    }

    public void InsertUserInformation(UserInformation info)
    {
        GarageDBEntities db = new GarageDBEntities();
        db.UserInformations.Add(info);
        db.SaveChanges();
    }

        public String UpdateUser(int id,UserInformation u)

    {
            try{
       
            GarageDBEntities db = new GarageDBEntities();
            UserInformation p = db.UserInformations .Find (id);
            p.FirstName = u.FirstName;
            p.LastName = u.LastName;
            p.Address = u.Address;
            p.PostalCode= u.PostalCode;
            p.Password = u.Password;
                p.Phone=u.Phone;
           
            db.SaveChanges();
            return u.LastName + " was successfully updated";
        }
        catch (Exception e)
        {
            return "Error : " + e;
        }

    }
    
}