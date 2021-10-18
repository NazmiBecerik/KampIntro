using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            // ARRAY - DİZİ
            string kurs1 = "Yazılım Geliştirici Kampı";
            string kurs2 = "Programlamaya başlangıç için temel kurs";
            string kurs3 = "Java";
            string kurs4 = "Python";
            string kurs5 = "C++";

            string[] kurslar = new string[] { "Yazılım Geliştirici Kampı", "Programlamaya başlangıç için temel kurs", "Java","Python","C++","C#" };

            for (int i = 0; i < kurslar.Length ; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("---for bitti---");
            Console.WriteLine("---for each başladı---");
            // foreach dizilerde kullanılır .
            foreach (string kurs in kurslar )
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("---Sayfa Sonu---");
        }
    }
}
