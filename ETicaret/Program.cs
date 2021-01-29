using System;

namespace ETicaret
{
    //Herhangi bir e-ticaret sistemine giriniz.

    //Genellikle bir e-ticaret sistemine girdiğinizde ürünler listelenir.Siz de Urun(Product) isimli bir class oluşturup, oluşturduğunuz bir kaç ürünü bir diziye ekleyiniz.

    //Ürünlerinizi for, foreach ve while döngüleri ile ayrı ayrı listeleyiniz.
    class Program
    {
        private static int urun;

        static void Main(string[] args)
        {
            string urunAdi = "Nevresim Takımı";
            double urunFiyati = 85;
            string aciklama = "Fenerbahçe Lisanslı Nevresim Takımı";

            Urun urun1 = new Urun();
            urun1.Adi = "Nevresim Takımı";
            urun1.Fiyati = 85;
            urun1.Aciklama ="Fenerbahçe Lisanslı Nevresim Takımı";

            Urun urun2 = new Urun();
            urun2.Adi = "Nevresim Takımı";
            urun2.Fiyati = 105;
            urun2.Aciklama = "Beşiktaş Lisanslı Nevresim Takımı";

            Urun urun3 = new Urun();
            urun3.Adi = "Nevresim Takımı";
            urun3.Fiyati = 85;
            urun3.Aciklama = "Bursaspor Lisanslı Nevresim Takımı";

            Urun urun4 = new Urun();
            urun4.Adi = "Nevresim Takımı";
            urun4.Fiyati = 50;
            urun4.Aciklama = "Eskişehirspor Lisanslı Nevresim Takımı";

            Urun urun5 = new Urun();
            urun5.Adi = "Nevresim Takımı";
            urun5.Fiyati = 60;
            urun5.Aciklama = "Başakşehir Lisanslı Nevresim Takımı";
            Urun[] urunler = new Urun[] { urun1, urun2, urun3, urun4, urun5 };

            Console.WriteLine("----------foreach Döngüsü------------");

            foreach (Urun urun in urunler) 
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-----------------------------");
                Console.WriteLine("\n");

            }
            
            Console.WriteLine("----------------FOR Döngüsü----------");
            for (int i = 0; i < urunler.Length; i++)
            {

                Console.WriteLine(urunler[i]);
              
            }
            Console.WriteLine("----------- While Döngüsü--------------");
            int x = 1;
            while (x < 3)
            {
                Console.WriteLine("Nevresim Takımı");
                x++;
            }
            Console.ReadKey();
            


        }
    }
}
