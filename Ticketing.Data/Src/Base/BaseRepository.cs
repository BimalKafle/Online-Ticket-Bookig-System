using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticketing.Data.DataAccess;

namespace Ticketing.Data.Base
{
    public class BaseRepository<T> : BaseRepositoryInterface<T> where T : class
    {
        private readonly ApplicationDbContext _context;

        public BaseRepository(ApplicationDbContext dbContext)
        {
            this._context = dbContext;
        }

        public async Task Delete(T entity)
        {
            await Task.Run(() => _context.Set<T>().Remove(entity)).ConfigureAwait(false);
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _context.Set<T>().ToListAsync().ConfigureAwait(false);
        }

        public async Task<T?> GetById(long id)
        {
            return await _context.Set<T>().FindAsync(id).ConfigureAwait(false);
        }

        public  IQueryable<T> GetQueryable()
        {
            return _context.Set<T>();
        }

        public async Task Insert(T entity)
        {
            await _context.AddAsync(entity).ConfigureAwait(false);
        }

        public async Task Update(T entity)
        {
            EntityEntry entry =  _context.Entry<T>(entity);
            entry.State = EntityState.Modified;
        }
    }
}
