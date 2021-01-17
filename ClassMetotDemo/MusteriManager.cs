using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle( Musteri musteri)
        {
           Console.WriteLine("Müşteri Eklendi"+musteri.MusteriId+ " *"+musteri.MusteriAdi+ " *" + musteri.MusteriSoyadi+ " *"+musteri.MusterininYasi);


        }
        
        public void Sil(Musteri Musteri) 
        {

            Console.WriteLine("Müşteri Silindi");
        
        }

        public void Listele(Musteri MusteriListesi) 
        {

            Console.WriteLine( "Müşterilerin listesi :::::"+MusteriListesi.MusteriId +" *"+MusteriListesi.MusteriAdi+"*"+MusteriListesi.MusteriSoyadi+"*"+ MusteriListesi.MusterininYasi);
        
        }
        

       
    }
}
