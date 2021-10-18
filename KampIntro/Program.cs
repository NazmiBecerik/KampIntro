using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            /** değişken nedir ? string nedir ?
             type safety - tip güvenliği**/
            // kategori etiketi bir değer tutucu , aliastır 
            //string kategoriEtiketi = "kategori";
            // int tam sayıları tutar sınırı vardır.
            //int ogrenciSayisi = 32000;
            //double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true ;
            // if in yanında ki normal parantez şart kısmı süslü kısım blok kısmı.
            double dolarBugun = 7.45;
            double dolarDun = 7.35;
            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi Butonu");
            }
            //
            //
            if (sistemeGirisYapmisMi==true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu ");
            }
        }
    }
}
