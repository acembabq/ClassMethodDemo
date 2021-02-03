using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class MusteriManager
    {
        public void Add(Musteri musteri) {
            Console.WriteLine("Müşteri eklendi> "+ musteri.ad+" "+musteri.soyad);
        }

        public void Delete(Musteri musteri)
        {
            Console.WriteLine("Müşteri silindi> "+ musteri.ad + " " + musteri.soyad);
        }

        public void List(Musteri musteri, Musteri musterix, Musteri musteriy)
        {
            Musteri[] musteriler = new Musteri[] {musteri,musterix,musteriy};
            foreach (Musteri i in musteriler)
            {
                Console.WriteLine(i.ad+" "+i.soyad);
            }
          
            
        }
    }
}
