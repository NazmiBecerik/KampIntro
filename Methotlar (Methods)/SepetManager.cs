using System;
using System.Collections.Generic;
using System.Text;

namespace Methotlar__Methods_
{
    class SepetManager
    {
        // Method oluşturalım.
        // Normal parantez gördüğümüzde orada bir method çalıştığını anlamalıyız.
        public void Ekle(Urun urun)
            // içeride yazanlar parametre ilk Urun tipi ikinci urun kullanım için.
        {
            Console.WriteLine("Tebrikler! Sepete Eklendi: "+urun.Adi);

        }

        public void Ekle2(string urunAdi,string aciklama,double fiyat)
        {
            Console.WriteLine("Tebrikler! Sepete Eklendi : "+urunAdi);
        }
    }
}
