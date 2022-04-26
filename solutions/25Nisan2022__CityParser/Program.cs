using System;
using System.Collections.Generic;
using System.IO;

namespace cities;


public class Country
{
    public string Name { get; set; }
}


public class City
{
    public Country country { get; set; }
    public string CityName { get; set; }
}

public class cities
{
    public cities(string path)
    {
        string[] allFileContent = File.ReadAllLines(path);
        foreach (var c in allFileContent)
        {
            var parsed = c.Split(", ");
            var cty = new City();
            cty.country = new Country();
            cty.country.Name = parsed[1];
            cty.CityName = parsed[0];
            cityList.Add(cty);

        }
    }
    public List<City> cityList = new List<City>();
}

class Program
{
    static void Main()
    {
        var collectionOfCity = new cities("cities.txt");
        foreach (var c in collectionOfCity.cityList)
        {
            Console.WriteLine("City: {0} - Country: {1}", c.CityName, c.country.Name);
        }


    }
}

