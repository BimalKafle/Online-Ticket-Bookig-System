using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticketing.Data.Base
{
    public interface BaseRepositoryInterface<T> where T : class
    {
        Task<T?> GetById(long id);
        Task<IEnumerable<T>> GetAll();
        IQueryable<T> GetQueryable();
        Task Insert(T entity);
        Task Update(T entity);
        Task Delete(T entity);

    }
}
