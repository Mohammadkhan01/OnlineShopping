using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


/// <summary>
/// Summary description for CartModel
/// </summary>
public class CartModel
{
    public String InsertCart(Cart cart)
    {
        try
        {
            GarageDBEntities db = new GarageDBEntities ();
            db.Carts.Add(cart);
            db.SaveChanges();
            return cart.DatePurchased  + "was successfully Inserted";
        }
        catch (Exception e)
        {
            return "Error : " + e;
        }
    }
    public String UpdateCart(int id, Cart cart)
    {
        try
        {
            GarageDBEntities db = new GarageDBEntities();
            Cart p = db.Carts.Find(id);
            p.DatePurchased = cart.DatePurchased;
            p.ClientId = cart.ClientId;
            p.Amount = cart.Amount;
            p.IsInCart = cart.IsInCart;
            p.ProductId = cart.ProductId;

            db.SaveChanges();
            return cart.DatePurchased  + " was successfully updated";
        }
        catch (Exception e)
        {
            return "Error : " + e;
        }

    }
    public String DeleteCart(int id)
    {
        try
        {
            GarageDBEntities db = new GarageDBEntities();
            Cart cart = db.Carts.Find(id);
            db.Carts.Attach(cart);
            db.Carts.Remove(cart);
            db.SaveChanges();
            return cart.DatePurchased  + "was successfully deleted";
        }
        catch (Exception e)
        {
            return "Error : " + e;
        }
    }

    public List<Cart > GetOrdersInCart(string userId)
    {
        GarageDBEntities db = new GarageDBEntities();
        List<Cart> orders = (from x in db.Carts
                             where x.ClientId == userId
                             && x.IsInCart
                             orderby x.DatePurchased
                             select x).ToList();
        return orders;
    }
    public int GetAmountOfOrders(string userId)
    {
        try
        {
            GarageDBEntities db = new GarageDBEntities();
            int amount = (from x in db.Carts
                          where x.ClientId == userId
                          && x.IsInCart
                          select x.Amount ).Sum();
            return amount;
        }
        catch
        {
            return 0;
        }
    }
    public void UpdateQuantity(int id, int quantity)
    {
        GarageDBEntities db = new GarageDBEntities();
        Cart cart = db.Carts.Find(id);
        cart.Amount = quantity;
        db.SaveChanges();
    }
    public void MarkOrdersAsPaid(List<Cart> carts)
    {
        GarageDBEntities db=new GarageDBEntities ();
        if(carts !=null)
        {
            foreach (Cart cart in carts)
            {
                Cart oldcart = db.Carts.Find(cart.Id);
                oldcart.DatePurchased = DateTime.Now;
                
            }
        }

    }
}