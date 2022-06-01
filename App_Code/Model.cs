﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

public partial class Booking
{
    public int BookingId { get; set; }
    public Nullable<int> HostelerId { get; set; }
    public Nullable<System.DateTime> DateBookingMade { get; set; }
    public Nullable<System.DateTime> BookedStartDate { get; set; }
    public Nullable<System.DateTime> BookedEndDate { get; set; }
    public Nullable<System.DateTime> PaymentDueDate { get; set; }
    public Nullable<int> PaymentDueAmount { get; set; }
    public Nullable<int> PaymentMadeOn { get; set; }
    public string BookingComments { get; set; }
}

public partial class BookingLink
{
    public int BookingId { get; set; }
    public Nullable<int> RoomId { get; set; }
    public Nullable<int> BookedBy { get; set; }
    public Nullable<System.DateTime> BookTime { get; set; }
}

public partial class Cart
{
    public int Id { get; set; }
    public string ClientId { get; set; }
    public int ProductId { get; set; }
    public int Amount { get; set; }
    public Nullable<System.DateTime> DatePurchased { get; set; }
    public bool IsInCart { get; set; }
    public string Receipt { get; set; }

    public virtual Product Product { get; set; }
}

public partial class ClientInfo
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public string Suburb { get; set; }
    public int Phone { get; set; }
    public System.DateTime DatePurchased { get; set; }
    public string PaymentMethod { get; set; }
    public int Amount { get; set; }
    public string Qty { get; set; }
    public bool OrderPlaced { get; set; }
}

public partial class Comment
{
    public int CommentId { get; set; }
    public string Commentss { get; set; }
    public string subject { get; set; }
    public Nullable<System.DateTime> date { get; set; }
    public string email { get; set; }
}

public partial class Furniture
{
    public int FurnitureId { get; set; }
    public string FurnitureName { get; set; }
    public Nullable<int> FurnitureCost { get; set; }
    public Nullable<int> RoomId { get; set; }
}

public partial class Hostel
{
    public int HostelId { get; set; }
    public Nullable<int> NoOfRooms { get; set; }
    public Nullable<int> NoOfStudents { get; set; }
    public Nullable<int> AnnualExpense { get; set; }
    public string Address { get; set; }
}

public partial class Hosteler
{
    public int HostelerId { get; set; }
    public string Name { get; set; }
    public string FatherName { get; set; }
    public string MotherName { get; set; }
    public string NationalIDCardNo { get; set; }
    public Nullable<int> Phone { get; set; }
    public string Address { get; set; }
    public Nullable<System.DateTime> DOB { get; set; }
    public Nullable<int> HostelBuildingId { get; set; }
    public Nullable<int> Room_Id { get; set; }
    public string Image { get; set; }
}

public partial class Product
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Product()
    {
        this.Carts = new HashSet<Cart>();
    }

    public int Id { get; set; }
    public int TypeId { get; set; }
    public string Name { get; set; }
    public Nullable<int> Price { get; set; }
    public string Description { get; set; }
    public string image { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<Cart> Carts { get; set; }
    public virtual ProductType ProductType { get; set; }
}

public partial class ProductType
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public ProductType()
    {
        this.Products = new HashSet<Product>();
    }

    public int Id { get; set; }
    public string Name { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<Product> Products { get; set; }
}

public partial class RoomPrice
{
    public int RoomPriceId { get; set; }
    public Nullable<int> RoomPrice1 { get; set; }
}

public partial class UserInformation
{
    public int ID { get; set; }
    public string GUID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Address { get; set; }
    public int PostalCode { get; set; }
    public Nullable<int> Phone { get; set; }
    public string Password { get; set; }
}

public partial class Visit
{
    public int VisitId { get; set; }
    public Nullable<int> VisitedPerson { get; set; }
    public Nullable<System.DateTime> date { get; set; }
    public Nullable<int> Visited_By { get; set; }
    public string Comments { get; set; }
    public string Visit_Status { get; set; }
}