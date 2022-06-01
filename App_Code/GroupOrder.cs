using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for GroupOrder
/// </summary>
public class GroupOrder
{
	public string Client{get;set;}
    public DateTime Date{get;set;}
    public double Total{get;set;}
	public GroupOrder (string client,DateTime date,double total)
    {
        Client = client;
        Date = date;
        Total = total;
    }
}