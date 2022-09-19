using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticketing.Core.Entity;

namespace Ticketing.Core.Repository
{
    public interface UserRepositoryInterface
    {
        public Task Insert(User user);
        public Task Update(User user);
        public Task<User?> GetById(long Id);
        public Task<IEnumerable<User>> GetAll();

        public Task Delete(User user);
    }
}
