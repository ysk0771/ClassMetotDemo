using GameSalePlatform.Abstract;
using System;
using GameSalePlatform.Concrete;

namespace GameSalePlatform
{
    public class Program
    {
        static void Main(string[] args)
        {

            BaseCustomerManager customerManager1 = new SteamCustomerManager();
            customerManager1.save(new Customer {Ad="Furkan Yasin",Soyad="Keskin",Tc="78945123641",DogumTarihi=new DateTime(1998,11,16) });
            BaseCustomerManager customerManager2 = new UplayCustomerManager();
            customerManager2.save(new Customer { Ad = "Aslı Han", Soyad = "kalbimde beya kalbimde", Tc = "Valla bilene sormak lazım", DogumTarihi = new DateTime(1999, 6, 11) });
        
        }
    }
}
