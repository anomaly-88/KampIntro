using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //Naming Convention
        //Syntax
        //Güzel örnek, olması gereken
        public void Ekle(Urun urun)
        {

            Console.WriteLine(urun.Adi + " -> Sepete Eklendi ve Satın Alıma Hazır.");
        
        }

        // kötü örnek, yapılmaması gereken;
        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine(urunAdi + " -> Sepete Eklendi ve Satın Alıma Hazır.");
        }
    }
}
