using HB.NTier.BL.Interfaces;
using HB.NTier.DAL.Uow;
using HB.NTier.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HB.NTier.BL.Manager
{
    public class OrderManager : GenericManager<Order>, IOrderService
    {
        public OrderManager(Iuow uow) : base(uow)
        {
        }

        public void SiparişAl(int müşteriID, int fiyat, string siparişIcerik)
        {

            //müşteriden fiyat düş
            var userRepo = _uow.GetRepo<AppUser>();
            var user = userRepo.Get(x => x.Id == müşteriID);

            if(user == null) { Console.WriteLine("hata"); return; }

            user.Balance -= fiyat;
            userRepo.Update(user);


       
             
            var orderRepo =  _uow.GetRepo<Order>();

            orderRepo.Add(new Order() { AppUserId = 4, OrderContent = siparişIcerik });



            _uow.SaveChanges();

            //orders manuel olara sipariş ekleyecez müşteriID
        }
    }
}
