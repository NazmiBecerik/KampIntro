using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        public void Add(Product product) //Product product bana ürün classında bir ürün ver demek yani string nazmi ile aynı
        {
            Console.WriteLine(product.ProductName+ " eklendi.");
        }
        public void Uptade(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.");
        }
    }
}
