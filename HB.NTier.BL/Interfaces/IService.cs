using HB.NTier.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HB.NTier.BL.Interfaces
{
    public interface IService<T> where T : class,ICustomEntity
    {
        T Get(object id);
        List<T> GetAll();
        void Update(T entity);
        void Delete(T entity);
        void   Add(T entity);
        
    }



}
