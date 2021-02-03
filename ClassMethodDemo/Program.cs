using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args) {
            MusteriManager musteriManager = new MusteriManager();

            Musteri musteri1 = new Musteri();
            musteri1.id = 301;
            musteri1.ad = "Eren";
            musteri1.soyad = "Karayel";
            musteri1.yas = 15;
            musteri1.eMail = "erenkarayl@gmail.com";

            Musteri musteri2 = new Musteri();
            musteri2.id = 302;
            musteri2.ad = "Doğukan";
            musteri2.soyad = "Koral";
            musteri2.yas = 16;
            musteri2.eMail = "dogukankoral53@gmail.com";

            Musteri musteri3 = new Musteri();
            musteri3.id = 303;
            musteri3.ad = "Samet";
            musteri3.soyad = "Köksoy";
            musteri3.yas = 20;
            musteri3.eMail = "koksoysamet@gmail.com";

            musteriManager.Add(musteri1);
            musteriManager.Delete(musteri1);
            musteriManager.List(musteri1, musteri2, musteri3);

        }
    }
}
