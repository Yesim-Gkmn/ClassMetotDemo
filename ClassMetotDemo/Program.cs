using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri MusteriBilgisi1 = new Musteri();

            MusteriBilgisi1.MusteriId = 123456789;
            MusteriBilgisi1.MusteriAdi = "Metin";
            MusteriBilgisi1.MusteriSoyadi = "M:O";
            MusteriBilgisi1.MusterininYasi = 26;

            Musteri MusteriBilgisi2 = new Musteri();

            MusteriBilgisi2.MusteriId = 985467;
            MusteriBilgisi2.MusteriAdi = "Dikdörtgen";
            MusteriBilgisi2.MusteriSoyadi = "L";
            MusteriBilgisi2.MusterininYasi = 60;

            Musteri MusteriBilgisi3 = new Musteri();

            MusteriBilgisi3.MusteriId = 325463245;
            MusteriBilgisi3.MusteriAdi = "Kare";
            MusteriBilgisi3.MusteriSoyadi = "K";
            MusteriBilgisi3.MusterininYasi = 28;


            
            Musteri[] Musteriler = new Musteri[] { MusteriBilgisi1, MusteriBilgisi2, MusteriBilgisi3 };

            
            foreach (Musteri MusteriListesi in Musteriler)
            {
                Console.WriteLine(MusteriListesi.MusteriId);
                Console.WriteLine(MusteriListesi.MusteriAdi);
                Console.WriteLine(MusteriListesi.MusteriSoyadi);
                Console.WriteLine(MusteriListesi.MusterininYasi);
                Console.WriteLine("********");
            }
          
            Console.WriteLine("---------------------------------");

            MusteriManager musterimanager = new MusteriManager();
            musterimanager.Ekle(MusteriBilgisi1);
            musterimanager.Ekle(MusteriBilgisi2);
            musterimanager.Ekle(MusteriBilgisi3);

            Console.WriteLine("///////////////////////////////////////////////////////");

            MusteriManager musteriimanager = new MusteriManager();

            musteriimanager.Sil(MusteriBilgisi1);
            musteriimanager.Sil(MusteriBilgisi2);
            musteriimanager.Sil(MusteriBilgisi3);

            Console.WriteLine("///////////////////////////////////////////////////////");


            MusteriManager musteriimanageri = new MusteriManager();
            musteriimanageri.Listele(MusteriBilgisi1);
            musteriimanageri.Listele(MusteriBilgisi2);
            musteriimanageri.Listele(MusteriBilgisi3);



        }
    }
}
