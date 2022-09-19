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
    public class VehicleCategoryRepository : BaseRepository<VehicleCategory>, VehicleCategoryRepositoryInterface
    {
        public VehicleCategoryRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
