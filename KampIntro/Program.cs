using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Type Safety - Tip Güvenliği
            string kategoriEtiketi = "Kategori";
            bool girisYaptiMi = false;
            double bucukluMucuklu = 0.3;
            int sayisal = 12;

            // yukarı-aşağı eşit ok örneği.
            double dolarDun = 7.35;
            double dolarBugun = 7.60;

            String yukariOk = "YukarıOk.SVG";
            String asagiOk = "AşağıOk.SVG";
            String esittirSembolu = "EsittirSembolü.SVG";


            if (dolarBugun > dolarDun)
            {
                Console.WriteLine(yukariOk);
            } else if (dolarBugun < dolarDun)
            {
                Console.WriteLine(asagiOk);

            } else
            {
                Console.WriteLine(esittirSembolu);
            }


            
        }
    }
}
