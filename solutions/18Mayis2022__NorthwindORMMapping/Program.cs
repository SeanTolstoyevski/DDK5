using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

using System.Diagnostics.CodeAnalysis;


namespace EFCoreEntry;



public class Northwind : DbContext
{
    public DbSet<Category> Categories { get; set; }



    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost; Database=NorthwindMapping; trusted_connection=true");
    }

}

public class Category
{
    public int id { get; set; }

    public string CategoryName { get; set; }

    public string Description { get; set; }

}


public class Product
{
    public int ID { get; set; }

    public string ProductName { get; set; }

    public int SupplierID { get; set; }

    public int CategoryID { get; set; }

    [StringLength(20)]
    public string QuantityPerUnit { get; set; }

    public decimal UnitPrice { get; set; }

    public int UnitsInStock { get; set; }

    public int UnitsOnOrder { get; set; }

    public int ReorderLevel { get; set; }


    public bool Discontinued { get; set; }




}

public class CUstomer
{
    public int id { get; set; }

    [StringLength(40)]
    public string CompanyName { get; set; }

    [StringLength(30)]
    public string ContactName { get; set; }

    [StringLength(30)]
    public string ContactTitle { get; set; }

    [StringLength(60)]
    public string Address { get; set; }

    [StringLength(15)]
    public string City { get; set; }

    [StringLength(15)]
    public string Region { get; set; }

    [StringLength(10)]
    public string PostalCode { get; set; }

    [StringLength(15)]
    public string Country { get; set; }

    [StringLength(24)]
    public string PhoneNumber { get; set; }

    [StringLength(24)]
    public string Fax { get; set; }

}




public class CustomerDemographics
{
    [StringLength(20)]
    public int ID { get; set; }
    public string CustomerDesc { get; set; }
}


public class CustomerCustomerDemo
{
    public int Id { get; set; }
    public int CustomerID { get; set; }
    public int CustomerTypeID { get; set; }
}





class program
{

    static void Main()
    {


    }
}