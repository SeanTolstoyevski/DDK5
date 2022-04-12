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








        }

    }
}

