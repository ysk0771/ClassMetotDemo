using System;

namespace ClassMetotDemo
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
            Musteri a1 = new Musteri();
            Musteri a2 = new Musteri();
            Musteri a3 = new Musteri();
            Musteri a4 = new Musteri();
            
            MusteriManager.ekle(a1, "0","Aslı","Han");
            
            MusteriManager.ekle(a2, "1", "Furkan", "Yasin");
            
            MusteriManager.ekle(a3, "2", "Ali", "Koç");
            
            MusteriManager.ekle(a4, "3", "Merve", "as");
            
            MusteriManager.listele(a1);
            
            MusteriManager.listele(a1,a2,a3,a4);
 
            MusteriManager.sil(a1);

            MusteriManager.listele(a1);
        }
    }
}
