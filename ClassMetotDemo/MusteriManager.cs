using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        static string a = "Müsteri silindi!!!";
        static string b = "Müşteri eklendi!!!";

        public static void ekle(Musteri i,  string id, string ad, string soyad)
        {
            
            i.id = id;
            i.ad = ad;
            i.soyad = soyad;

            Console.WriteLine(b);
        }
        public static void sil(Musteri i)
        {
            i.id = null;

            i.ad = null;

            i.soyad = null;

            Console.WriteLine(a);

        }

        public static void listele(Musteri i, Musteri y , Musteri z , Musteri f )
        {
            Musteri[] Musteriler = new Musteri[] { i, y, z, f };

            foreach (var musteri in Musteriler)
            {
                Console.WriteLine(i.id + " " + musteri.ad + " " + musteri.soyad);
            }
       
        }

        public static void listele(Musteri i)
        {
            Musteri[] Musteriler = new Musteri[] { i };

            foreach (var musteri in Musteriler)
            {
                Console.WriteLine(i.id + " " + musteri.ad + " " + musteri.soyad);
            }

        }





    }
}
