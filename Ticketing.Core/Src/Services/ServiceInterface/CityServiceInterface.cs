using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticketing.Core.DTO.City;

namespace Ticketing.Core.Services.ServiceInterface
{
    public interface CityServiceInterface
    {
        public Task Create(CityInsertDto dto);
        public Task Update(CityUpdateDto dto);

        public Task Activate(long Id);
        public Task Deactivate(long Id);
    }
}
