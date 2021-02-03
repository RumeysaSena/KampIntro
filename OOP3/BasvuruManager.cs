using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
     class BasvuruManager
    {
        //Method injection- 
        public void BasvuruYap(IKrediManager krediManager, List<ILoggerService> loggerServices ) //kullanacağı managerin ne olacağını(hangi kredi türü olacağını) ve hangi loglayıcı olacağını enjekte ediyoruz.
        {
            // Başvuru bilgilerini değerlendirme, kredi hesaplama vs vs

            krediManager.Hesapla();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
