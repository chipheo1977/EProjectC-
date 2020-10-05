using EProject.Models.EF;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace EProject.Models.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected jwelleryEntities _ctx;
        protected DbSet<T> tbl;
        public Repository()
        {
            _ctx = new jwelleryEntities();
            tbl = _ctx.Set<T>();
        }
            
        public virtual bool Add(T entity)
        {
            try
            {
                tbl.Add(entity);
                Save();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public virtual bool Edit(T entity)
        {
            try
            {
                _ctx.Entry(entity).State = EntityState.Modified;
                Save();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public virtual IEnumerable<T> Get()
        {
            return tbl;
        }

        public virtual IEnumerable<T> Get(Expression<Func<T, bool>> predicate)
        {
            return tbl.Where(predicate);
        }

        public virtual T Get(object id)
        {
            return tbl.Find(id);
        }

        public virtual bool Remove(object id)
        {
            try
            {
                tbl.Remove(Get(id));
                Save();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public virtual void Save()
        {
            _ctx.SaveChanges();
        }
    }
}