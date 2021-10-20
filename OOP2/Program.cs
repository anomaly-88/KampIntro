using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {

            //GercekMusteri
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "GM1";
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "Demiroğ";
            musteri1.TcNo = "12345678910";

            //TuzelMusteri
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "TM1";
            musteri2.SirketAdi = "Macrosoft";
            musteri2.VergiNo = "123456789";


            //Olay
            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);
            musteriManager.Ekle(musteri4);


            ////Böyle de ekleyebilirdik.
            //GercekMusteri musterix = new GercekMusteri { Id = 3, MusteriNo = "GM2", Adi = "Aykan", Soyadi = "Akduman", TcNo = "12345678911" };
            //TuzelMusteri musteriy = new TuzelMusteri { Id = 4, MusteriNo = "TM2", SirketAdi = "ZuzuSoft", VergiNo = "12345678910" };
            

        }
    }
}
