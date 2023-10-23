using HB.NTier.DAL.Repository;
using HB.NTier.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HB.NTier.DAL.Uow
{
    public interface Iuow
    {
        //

       public IRepository<T> GetRepo<T>() where T : class , ICustomEntity;

        //commit -- savechanges

        void SaveChanges();


    }
}
