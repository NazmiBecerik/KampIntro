using System;

namespace Methotlar__Methods_
{
    class Program
    {
        static void Main(string[] args)
        {
            // classımızdan yararlanarak urunlerin bilgilerini girelim ve ürünler oluşturalım.

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 10;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            // oluşturduğumuz ürünleri bir listeye atalım
            Urun[] urunler = new Urun[] {urun1,urun2};

            // var yerine Urun yazmamızın sebebi o classta çalışacağını bilmesi için var da kullanılabilir ama Urun yazmak daha iyi bizim için.
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine("-------------");

                
                
            }
            // methot bana tekrar tekrar aynı şeyi kullanma imkanı verdi.
            Console.WriteLine("------------Metotlar-----------------");
            SepetManager sepetManager = new SepetManager(); // metodumuzu kullanabilmek için classımızı çağırdık
            sepetManager.Ekle(urun2); // metodumuzu çağırdık bu şekilde.
            sepetManager.Ekle(urun1);
            sepetManager.Ekle2("Armut", "Ayılar yer", 20);
            sepetManager.Ekle2("Karpız", "Sulu", 44);
            sepetManager.Ekle2("Elma", "Kırmızı", 13);

        }
        // Methodlar tekrar kullanılmayı sağlayan kod bloğu oluşturmamızı sağlar. Do not repeat yourself prensibi için çok önemlidir.
    }

}
