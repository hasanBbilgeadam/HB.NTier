using HB.NTier.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HB.NTier.DAL.Repository
{
    public interface IRepository<T> where T: class,ICustomEntity
    {

        T Find(object id);

        T Get(Expression<Func<T, bool>> filter);
        List<T> GetAll(bool tracking = true);
        List<T> GetAll(Expression<Func<T,bool>> filter);
        IQueryable<T> GetQueryable();

        void Remove(T entity);
        void Add(T entity);
        void Update(T entity);  




    }
}
