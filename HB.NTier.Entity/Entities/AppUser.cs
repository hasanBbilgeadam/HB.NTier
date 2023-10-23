using HB.NTier.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HB.NTier.Entity.Entities
{
    public class AppUser: ICustomEntity
    {


        public AppUser()
        {
            Orders = new();
        }
        public int Id { get; set; }
        public string UserName { get; set;}
        public string Password { get; set;}
        public int Balance { get; set; }


        //fk
        public int CategoryId { get; set; }
        public AppUserCategory AppUserCategory { get; set; }

        public List<Order> Orders { get; set; }

    }
}
