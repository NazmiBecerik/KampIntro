using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.KursEgitmeni = "Engin Demirog";
            kurs1.KursIzlenmeOrani = 5000;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.KursEgitmeni = "Kerem";
            kurs2.KursIzlenmeOrani = 64;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.KursEgitmeni = "Berkay";
            kurs3.KursIzlenmeOrani = 80 ;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "C++";
            kurs4.KursEgitmeni = "Murat";
            kurs4.KursIzlenmeOrani = 100;
            //
            //
            //Console.WriteLine("Kurs Adı : "+ kurs1.KursAdi+": "+"Kurs Eğitmeni : "+ kurs1.KursEgitmeni+": "+"Kurs Izlenme Oranı: "+kurs1.KursIzlenmeOrani);
            // string[] Kurs = new Kurs[]; bu şekilde tutarsak sadece string tutarız. 
            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3,kurs4};
            // ama şimdi içerisinde her şeyi kullanabiliriz.
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi+" "+" : "+kurs.KursEgitmeni);
                
            }
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string KursEgitmeni { get; set; }
        public int KursIzlenmeOrani { get; set; }

    }
}
