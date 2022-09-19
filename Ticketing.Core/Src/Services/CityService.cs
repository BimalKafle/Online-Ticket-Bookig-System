using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using Ticketing.Core.DTO.City;
using Ticketing.Core.Entity;
using Ticketing.Core.Exception.City;
using Ticketing.Core.Helper;
using Ticketing.Core.Repository;
using Ticketing.Core.Services.ServiceInterface;

namespace Ticketing.Core.Services
{
    public class CityService : CityServiceInterface
    {
        private readonly CityRepositoryInterface cityRepositoryInterface;

        public CityService(CityRepositoryInterface _cityRepositoryInterface)
        {
            this.cityRepositoryInterface = _cityRepositoryInterface;
        }

        public async Task Activate(long Id)
        {
            using TransactionScope scope = TransactionScopeHelper.GetInstance();
            var city = await cityRepositoryInterface.GetById(Id).ConfigureAwait(false) ?? throw new CityNotFoundException();
            city.Activate();
            scope.Complete();
        }

        public async Task Create(CityInsertDto dto)
        {
            using TransactionScope scope = TransactionScopeHelper.GetInstance();
            ValidateCity(dto.Name);
            var city = new City(dto.Name);
            await cityRepositoryInterface.Insert(city).ConfigureAwait(false);
            scope.Complete();

        }

        public async Task Deactivate(long Id)
        {
            using TransactionScope scope = TransactionScopeHelper.GetInstance();
            var city = await cityRepositoryInterface.GetById(Id).ConfigureAwait(false) ?? throw new CityNotFoundException();
            city.Deactivate();
            scope.Complete();
        }

        public Task Update(CityUpdateDto dto)
        {
            throw new NotImplementedException();
        }

        private async void ValidateCity(string name)
        {
            var city =await cityRepositoryInterface.GetByName(name).ConfigureAwait(false);
            if (city != null)
            {
                throw new CityAlreadyExistException();
            }
        }
    }
}
