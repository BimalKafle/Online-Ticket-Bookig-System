using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticketing.Core.Entity;

namespace Ticketing.Core.Repository
{
    public interface VehicleCategoryRepositoryInterface
    {
        public Task Insert(VehicleCategory category);
        public Task Update(VehicleCategory category);
        public Task<VehicleCategory?> GetById(long Id);
        public Task<IEnumerable<VehicleCategory>> GetAll();
    }
}
