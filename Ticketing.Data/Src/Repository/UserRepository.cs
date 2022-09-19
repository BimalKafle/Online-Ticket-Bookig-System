using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticketing.Core.Entity;
using Ticketing.Core.Repository;
using Ticketing.Data.Base;
using Ticketing.Data.DataAccess;

namespace Ticketing.Data.Repository
{
    public class UserRepository : BaseRepository<User>, UserRepositoryInterface
    {
        public UserRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
