using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ColorfulListWebApp.Data.Base
{
    public interface IEntityBaseRepository<T> where T: class, IEntityBase, new()
    {
        IEnumerable<T> GetAll();
        IEnumerable<T> GetAll(params Expression<Func<T, object>>[] includeProperties);
        Task<T> GetById(int id);
        Task Update(int id, T entity);
        void Add(T entity);
        void Delete(int id);
    }
}
