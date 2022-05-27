using System.Collections.Generic;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace EFCoreEntry;

public class SupplierRepository
{
    NorthwindContext db = new NorthwindContext();

    public List<string> GetSupplierCities()
    {
        List<string> cities = new List<string>();
        var suppliers = db.Suppliers.ToList();
        foreach (var s in suppliers)
            cities.Add(s.City);
        return cities;
    }

    public void Delete7ID()
    {
        var id7 = db.Suppliers.FirstOrDefault(v => v.SupplierID == 7);
        db.Suppliers.Remove(id7);
        db.SaveChanges();
    }

    public List<Supplier> SearchSupplierTitle(string title)
    {
        return db.Suppliers.Where(v => v.ContactTitle.Contain(title));
    }

    public List<Supplier> GetFirst5Supplier()
    {
        return db.Suppliers.Take(5);
    }

    void SearchRegion(string reg)
    {
        var regs = db.Suppliers.Where(v => v.Region.Contain(reg));
        foreach (var s in regs)
            Console.WriteLine("{0}", s.Region);
    }

    public List<string> GetAllAdresses()
    {
        List<string> addrs = new List<string>();
        var saddrs = db.Suppliers.ToList();
        foreach (var s in saddrs)
            addrs.Add(s.Address);
        return addrs;
    }





}