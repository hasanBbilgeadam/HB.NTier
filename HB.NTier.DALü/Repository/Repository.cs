using HB.NTier.DAL.Context;
using HB.NTier.Entity.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HB.NTier.DAL.Repository
{
    public class Repository<T> : IRepository<T> where T : class, ICustomEntity
    {
        public Repository(AppDbContext appDb)
        {
                _context = appDb;
        }
        public AppDbContext _context { get; set; }

        public void Add(T entity)
        {
         
            _context.Set<T>().Add(entity);

        }

        public T? Find(object id)  =>_context.Set<T>().Find(id);

        public T? Get(Expression<Func<T, bool>> filter) => _context.Set<T>().Where(filter).FirstOrDefault();
          

        public List<T> GetAll(bool tracking = true)
        => tracking ?  _context.Set<T>().ToList():_context.Set<T>().AsNoTracking().ToList();


        public List<T> GetAll(Expression<Func<T, bool>> filter) => _context.Set<T>().Where(filter).ToList();

        public IQueryable<T> GetQueryable() => _context.Set<T>().AsQueryable();
       

        public void Remove(T entity)
        {

            _context.Set<T>().Remove(entity);
                        
        }

        //
        public void Update(T entity)
        {
            _context.Update(entity);
        }
    }
}
