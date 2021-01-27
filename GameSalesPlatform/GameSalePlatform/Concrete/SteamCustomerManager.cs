using GameSalePlatform.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSalePlatform.Concrete
{
    public class SteamCustomerManager : BaseCustomerManager
    {
        ICustumerChechService _custumerChechService;

        public SteamCustomerManager(ICustumerChechService custumerChechService)
        {
            _custumerChechService = custumerChechService;
        }

        public override void save(Customer customer)
        {
            if (_custumerChechService.CheckİfRealPerson(customer))
            {
                base.save(customer);
            }
            else
            {
                throw new Exception("Geçerli bir kişi değil");
            }
            
        }

        

       
    }
}
