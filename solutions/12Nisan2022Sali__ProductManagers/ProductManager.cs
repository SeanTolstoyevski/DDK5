using System;
using System.Collections.Generic;
using System.Linq;

namespace HelloCSharp
{
    public class ProductManager
    {


        //Dışarıdan fiyat alan ve o fiyattan yüksek ÜRÜNLERİ bana veren metot
        public List<Product> GetProductsByPrice(List<Product> products, decimal price)
        {
            List<Product> filteredProducts = products.Where(q => q.unitPrice > price).ToList();

            return filteredProducts;
        }

    }
}
