using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;


namespace EFCoreEntry;



public class Northwind : DbContext
{
    public DbSet<Category> Categories { get; set; }

    public DbSet<Product> Products { get; set; }
    
    public DbSet<Customer> Customers { get; set; }

    public DbSet<CustomerDemographic> CustomerDemographics { get; set; }
    
    public DbSet<CustomerCustomerDemo> CustomerCustomerDemos { get; set; }

    public DbSet<Employee> Employees { get; set; }

    public DbSet<EmployeeTerritory> EmployeeTerritories { get; set; }

    public DbSet<Order> Orders { get; set; }

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

public class Customer
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


public class CustomerDemographic
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


public class Employee
{

    [Required]
    public int ID { get; set; }
    [Required]
    [StringLength(20)]
    public string LastName { get; set; }
    [StringLength(10)]
    public string FirstName { get; set; }
    [StringLength(30)]
    public string Title { get; set; }
    [StringLength(25)]
    public string TitleOfCourtesy { get; set; }

    public DateTime BirthDate { get; set; }

    public DateTime HireDate { get; set; }
    [StringLength(60)]

    public string Adress { get; set; }
    [StringLength(15)]

    public string City { get; set; }
    [StringLength(15)]

    public string Region { get; set; }
    [StringLength(10)]

    public string PostalCode { get; set; }

    [StringLength(15)]
    public string Country { get; set; }

    [StringLength(24)]
    public string HomePhone { get; set; }

    [StringLength(4)]
    public string Extension { get; set; }

    public string Notes { get; set; }

    public int ReportTo { get; set; }
}


public class EmployeeTerritory
{
    public int id { get; set; }

    [StringLength(20)]
    [Key]
    public string TerritoryID { get; set; }
}

public class Order
{
    public int id { get; set; }

    [StringLength(5)]
    public string CustomerID { get; set; }

    public string? EmployeeID { get; set; }

    public DateTime OrderDate { get; set; }

    public DateTime RequiredDate { get; set; }

    public DateTime ShippedDate { get; set; }

    public int? ShipVia { get; set; }

    public decimal Freight { get; set; }

    [StringLength(40)]
    public string ShipName { get; set; }

    [StringLength(60)]
    public string ShipAddress { get; set; }

    [StringLength(15)]
    public string ShipCity { get; set; }

    [StringLength(15)]
    public string ShipRegion { get; set; }

    [StringLength(10)]
    public string ShipPostalCode { get; set; }

    [StringLength(15)]
    public string ShipCountry { get; set; }

}


class program
{

    static void Main()
    {


    }
}