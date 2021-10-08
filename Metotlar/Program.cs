using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Portakal";
            urun2.Fiyati = 20;
            urun2.Aciklama = "Washington Portakal";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (var urun in urunler)
            {
                Console.WriteLine("Meyve Adı : " + urun.Adi +
                                "\nMeyve Fiyatı : " + urun.Fiyati +
                                "\nMeyve Açıklaması : " + urun.Aciklama + "\n");
            }

            Console.WriteLine("------Meteotlar------");
            //instance - örnek
            SepetManager sepetManager = new SepetManager();
            // Encapsulation
            // Güzel örnek, yapılması gereken;
            Console.WriteLine("-------------- Ekle Metodu Devrede ----------");
            sepetManager.Ekle(urun1);
            //başka sayfa 1
            sepetManager.Ekle(urun2);
            //başka sayfa 2
            sepetManager.Ekle(urun2);
            //başka sayfa 3
            sepetManager.Ekle(urun1);
            //başka sayfa x..
            sepetManager.Ekle(urun2);

            Console.WriteLine("-------------- Ekle 2 Metodu Devrede ----------");

            // kötü örnek, yapılmaması gereken;
            sepetManager.Ekle2("Kayısı", "Kayseri Kayısı", 25, 100);
            // Başka sayfa 1
            sepetManager.Ekle2("Armut", "Deveci Armudu", 20, 70);
            // Başka sayfa 2
            sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 10, 30);
            // Başka sayfa 3
            sepetManager.Ekle2("Erik", "Papaz Erik", 15, 22);
        }
    }
}
