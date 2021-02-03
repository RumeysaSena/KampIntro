using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Rumeysa ÖZdemir

            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Rumeysa";
            musteri1.Soyadi = "Özdemir";
            musteri1.TcNo = "12345678910";

            // Kodlama.io

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "123465";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "12345695870";



            //Gerçek Müşteri-Tüzel Müşteri: İkiside Müşteri ama farklı müşteri tipleridir, birbirine benziyor diye birbirlerinin yerine kullanılamazlar.
            //SOLID

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri1);
            musteriManager.Add(musteri2);
            musteriManager.Add(musteri3);
            musteriManager.Add(musteri4);
        }

    }
}
