using HB.NTier.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HB.NTier.Entity.Entities
{
    public class Order:ICustomEntity
    {
        public int Id { get; set; }
        public string OrderContent { get; set; }

        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }
    }
}
