using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticketing.Core.DTO.City;
using Ticketing.Core.Services.ServiceInterface;

namespace Ticketing.Core.Services
{
    public class CityService : CityServiceInterface
    {
        public Task Activate(long Id)
        {
            throw new NotImplementedException();
        }

        public Task Create(CityInsertDto dto)
        {
            throw new NotImplementedException();
        }

        public Task Deactivate(long Id)
        {
            throw new NotImplementedException();
        }

        public Task Update(CityUpdateDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
