using HB.NTier.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HB.NTier.BL.Interfaces
{
    public interface IOrderService:IService<Order>
    {
        //sipariş al
        //müşteri id
        //para miktari
        //sipariş içerik


        void SiparişAl(int müşteriID, int fiyat, string siparişIcerik);

    }
}
