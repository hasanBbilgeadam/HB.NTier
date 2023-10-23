using HB.NTier.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HB.NTier.Entity.Entities
{
    public class AppUserCategory:ICustomEntity
    {


        public AppUserCategory()
        {
                AppUsers = new List<AppUser>(); 

        }
        public int Id { get; set; }
        public string AppUserCategoryName { get; set; }

        public List<AppUser> AppUsers { get; set; }



    }
}
