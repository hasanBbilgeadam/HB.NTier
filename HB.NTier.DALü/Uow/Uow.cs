using HB.NTier.DAL.Context;
using HB.NTier.DAL.Repository;
using HB.NTier.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HB.NTier.DAL.Uow
{
    public class Uow : Iuow
    {

        AppDbContext _context;

        public Uow(AppDbContext context)
        {
            _context = context;
        }

        public void SaveChanges()
        {
           _context.SaveChanges();
        }

        public IRepository<T> GetRepo<T>() where T : class,ICustomEntity
        {
            return new Repository<T>(_context);
        }
    }
}
