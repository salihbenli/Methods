using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] meyveler = new string[] { };

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklma = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklma = "Diyabakır karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklma);
                Console.WriteLine("---------------");
            }

            Console.WriteLine("---------------Methodlar------------------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("armut", "yeşil", 12);
            sepetManager.Ekle2("elma", "yeşil", 12);
            sepetManager.Ekle2("karpuz", "yeşil", 12);
        }
    }
}
//Dont repeat yourself