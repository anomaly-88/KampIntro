using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {

            // Simulasyon, bunları açılır kutu olarak düşün - butonla başvuru çağırılıyor, ekranlar çok kolay.
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();


            //Logger Service'lerin referansını oluşturalım;
            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            //BasvuruManager basvuruManager is new BasvuruManager diyorum ve referansımı alıyorum;
            // 2 tane loglama alternatifim var, ben database i seçtim.
            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(new EsnafKrediManager(), new List<ILoggerService> { databaseLoggerService, fileLoggerService, new SmsLoggerService() });
            /*
             * Loglama servislerini direkt olarak parametrede de oluşturabilirdik, şu şekilde;
             * basvuruManager.BasvuruYap(ihtiyacKrediManager, new DatabaseLoggerService());
             * Bizim için önemli olan şey, referans numarası.
             */


            // Bankadaki görevli kredi ön bilgilendirmesi yapmak için kredileri yolluyor;
            List<IKrediManager> krediler = new List<IKrediManager>() { tasitKrediManager, ihtiyacKrediManager};
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);

        }
    }
}
