using System;
using System.Collections.Generic;
using System.Text;

namespace GameSalePlatform.Abstract
{
    public abstract class  BaseCustomerManager : ICustomerService
    {
        public virtual void save(Customer customer)
        {
            Console.WriteLine("veritabanına kaydedildi --gitmiş mi bi bak-- "+customer.Ad+" "+customer.Soyad);
        }
    }
}
