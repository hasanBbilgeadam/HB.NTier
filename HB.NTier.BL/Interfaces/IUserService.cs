using HB.NTier.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HB.NTier.BL.Interfaces
{
    public interface IUserService:IService<AppUser>
    {
        bool RoleAssing(string RoleName,int id);
        bool RoleRemove(string RoleName,int id);
        bool Login(string userName,string passsword);
    }
}
