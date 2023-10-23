using HB.NTier.BL.Interfaces;
using HB.NTier.DAL.Repository;
using HB.NTier.DAL.Uow;
using HB.NTier.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HB.NTier.BL.Manager
{
    public class UserManager : GenericManager<AppUser>, IUserService
    {
        public UserManager(Iuow uow) : base(uow)
        {
        }


        public override void Add(AppUser entity)
        {
            var repo = _uow.GetRepo<AppUser>();
            var data =  repo.Get(x=>x.UserName == entity.UserName);

            if (data != null)
            {
                Console.WriteLine("hata!");
                return;
            }

            repo.Add(entity);




            _uow.SaveChanges();
        }
        public bool Login(string userName, string passsword)
              =>
                _uow.GetRepo<AppUser>().GetAll(a => a.UserName == userName && a.Password == passsword).Count == 1;


        public bool RoleAssing(string RoleName,int id)
        {
            //böyle bir rol varmı
            //kullanıcıda bu rol
            //yoksa ekle


            var data   = _uow.GetRepo<AppUserCategory>().Get(x => x.AppUserCategoryName == RoleName);

            if (data == null) return false;

            var user = _uow.GetRepo<AppUser>().GetQueryable().Where(x=>x.Id == id).Include(x=>x.AppUserCategory).FirstOrDefault();

            if(user == null) return false;

            if (user.AppUserCategory.AppUserCategoryName == RoleName) return false;
            user.AppUserCategory.AppUserCategoryName = RoleName;

            _uow.SaveChanges();

            return true;
        }

        public bool RoleRemove(string RoleName,int id)
        {
            throw new NotImplementedException();
        }
    }
}
