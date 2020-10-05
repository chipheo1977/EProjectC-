using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EProject.Models.Repositories
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> Get();
        IEnumerable<T> Get(Expression<Func<T, bool>> predicate);
        T Get(object id);
        bool Add(T entity);
        bool Edit(T entity);
        bool Remove(object id);
        void Save();
    }
}
