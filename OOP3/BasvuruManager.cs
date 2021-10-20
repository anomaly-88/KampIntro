using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {

        // Başvurunun değerlendirmeye alınıp yapıldığı yer
        // +Method injection yaptık
        public void BasvuruYap(IKrediManager krediManager, List<ILoggerService> loggerServices)
        {
            // Simülasyon: Başvuran bilgilerini değerlendirme
            // vs..
            // Krediyi

            krediManager.Hesapla();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }

        // Başvuru yapmadan önce Kredi şartlarının/bilgilerinin/tutarının Müşteriye sunulduğu yer
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }

        }
    }
}
