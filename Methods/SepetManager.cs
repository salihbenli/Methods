using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class SepetManager
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine("sepete eklendi= "+urun.Adi);
        }

        //Alternatif
        public void Ekle2(string urunAdi, string aciklama, double fiyat)
        {
            Console.WriteLine("sepete eklendi= " + urunAdi);
        }
    }
}
