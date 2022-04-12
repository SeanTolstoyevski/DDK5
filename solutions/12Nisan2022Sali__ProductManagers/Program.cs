using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace HelloCSharp
{
    class Program
    {
        static async Task Main(string[] args)
        {

            List<Product> products = new List<Product>();

            using (var httpClient = new HttpClient())
            {
                var streamTask = httpClient.GetStreamAsync("https://northwind.vercel.app/api/products");
                products = await JsonSerializer.DeserializeAsync<List<Product>>(await streamTask);
            }

            int less50PriceCount = products.Where(v => v.unitPrice < 50.0m).ToList().Count();
            Console.WriteLine($"fiyati 50'den az {less50PriceCount} urun var.");

            int Category3AndSuplier2Count = products.Where(v => v.supplierId == 2 && v.categoryId == 3).ToList().Count();
            Console.WriteLine($"Kategorisi 3 ve tedarikçi'si 2 olan {Category3AndSuplier2Count} var");


            int Price50_100RangeCount = products.Where(v => v.unitPrice >= 50.0m && v.unitPrice <= 100.0m).ToList().Count();
            Console.WriteLine($"Fiyati 50-100 arasinda {Price50_100RangeCount} urun var.");

            Console.WriteLine("a harfi ile baslayan urunler:");
            var fieeldedStartA = products.Where(v => v.name[0].ToString().ToLower() == "a").ToList();
            foreach(var i in fieeldedStartA)
                Console.WriteLine(i.name);

            Console.WriteLine("a harfi ile biten urunler:");
            var fieeldedEndA = products.Where(v => v.name[v.name.Length - 1].ToString().ToLower() == "a").ToList();
            foreach(var i in fieeldedEndA )
                Console.WriteLine(i.name);

            Console.WriteLine("a harfi iceren urunler:");
            var fieldedContainsALetter = products.Where(v => v.name.ToLower().Contains('a')).ToList();
            foreach(var i in fieldedContainsALetter )
                Console.WriteLine(i.name);

            int lesStock10 = products.Where(v => v.unitsInStock < 10).ToList().Count();
            Console.WriteLine($"Stok adedi 10'dan az olan urun sayisi {lesStock10}");











        }

    }
}



