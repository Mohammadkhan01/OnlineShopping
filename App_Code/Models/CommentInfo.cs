using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Comment
/// </summary>
public class CommentInfo
{
   
    public String  InsertComment(Comment info)
    {
        GarageDBEntities db = new GarageDBEntities();
        db.Comments.Add(info);
       
        db.SaveChanges();
        return info.CommentId + "was successfully Inserted";
    }

    public String UpdateUser(int id, Comment  u)
    {
        try
        {

            GarageDBEntities db = new GarageDBEntities();

            Comment  p = db.Comments.Find(id);
            
            p.Commentss = u.Commentss;
            p.subject = u.subject;
            p.date = u.date;
            p.email = u.email;
           

            db.SaveChanges();
            return u.CommentId + " was successfully updated";
        }
        catch (Exception e)
        {
            return "Error : " + e;
        }

    }
}