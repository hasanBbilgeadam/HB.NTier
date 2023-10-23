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


        public int Id { get; set; }
        public string UserName { get; set;}
        public string Password { get; set;}


        //fk
        public int CategoryId { get; set; }
        public AppUserCategory AppUserCategory { get; set; }


    }
}
