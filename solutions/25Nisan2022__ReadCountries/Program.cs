using System.IO;

namespace countries;

class Program
{
    static void Main()
    {
        string path = @"countries";
        string[] allCountries = File.ReadAllLines(path);


        // ülkeleri ekrana yazdır.
        foreach (var c in allCountries)
            Console.WriteLine(c);

        // kaç ülke var?
        Console.WriteLine("Number of countries: {0}", allCountries.Length);

        //  a harfiyle başlayan ülkeleri ekrana yazdır.
        foreach (var c in allCountries)
        {
            if (c.StartsWith("A"))
                Console.WriteLine(c);
        }

        // a harfiyle biten ülkeleri ekrana yazdır
        foreach (var c in allCountries)
        {
            if (c.EndsWith("a"))
                Console.WriteLine(c);
        }

    } // foreach block



}


