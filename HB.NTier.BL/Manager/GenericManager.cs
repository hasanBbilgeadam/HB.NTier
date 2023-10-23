using HB.NTier.BL.Interfaces;
using HB.NTier.DAL.Repository;
using HB.NTier.DAL.Uow;
using HB.NTier.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HB.NTier.BL.Manager
{
    public class GenericManager<T> : IService<T> where T : class, ICustomEntity
    {

        protected Iuow _uow;

        public GenericManager(Iuow uow)
        {
            _uow = uow;
        }

        public virtual void  Add(T entity) =>_uow.GetRepo<T>().Add(entity);
        public void Delete(T entity) => _uow.GetRepo<T>().Remove(entity);
        public T Get(object id) => _uow.GetRepo<T>().Find(id);
        public List<T> GetAll() => _uow.GetRepo<T>().GetAll();    
        public void Update(T entity) => _uow.GetRepo<T>().Update(entity);
        
       
        
    }
}
