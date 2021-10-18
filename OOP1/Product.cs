using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product
    {
        public int Id { get; set; } // nesneleri ayırt etmek için veri tabanında kullanılan isim
        public int CategoryId { get; set; } // hangi kategoride olduğu
        public string ProductName { get; set; } // ürün ismi
        public double UnitPrice{ get; set; } // ürün fiyatı
        public int UnitsInStock { get; set; } // ürün stok adeti
        //CRUD (CRATE READ UPTADE DELETE ) Kısaca kullanılan methodlar.
    }
}
