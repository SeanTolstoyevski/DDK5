using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;

using System.ComponentModel.DataAnnotations;

using System.Diagnostics.CodeAnalysis;


namespace EFCoreEntry;



public class SiemensContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost; Database=SiPro; trusted_connection=true");
    }


}


public class Product
{
    public int id { get; set; }

    public string Name { get; set; }
    public decimal UnitPrice { get; set; }
}

public class Category
{
    public int id { get; set; }

    public int? CategoryID { get; set; }

    [StringLength(40)]
    public string Name { get; set; }

}

class EFProgram
{
    static void Main()
    {

    }
}