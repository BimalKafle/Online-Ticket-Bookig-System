using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using Ticketing.Core.DTO.VehicleCategory;
using Ticketing.Core.Entity;
using Ticketing.Core.Exception.VehicleCategory;
using Ticketing.Core.Helper;
using Ticketing.Core.Repository;
using Ticketing.Core.Services.ServiceInterface;

namespace Ticketing.Core.Services
{
    public class VehicleCategoryService : VehicleCategoryServiceInterface
    {
        private readonly VehicleCategoryRepositoryInterface vehicleCategoryRepository;

        public VehicleCategoryService(VehicleCategoryRepositoryInterface _vehicleCategoryRepository)
        {
            this.vehicleCategoryRepository = _vehicleCategoryRepository;
        }

        public async Task Activate(long Id)
        {
            using TransactionScope scope = TransactionScopeHelper.GetInstance();
            var vehicleCategory = await vehicleCategoryRepository.GetById(Id).ConfigureAwait(false) ?? throw new VehicleCategoryNotFoundException();
            vehicleCategory.Activate();
            scope.Complete();
        }

        public async Task Create(VehicleCategoryInsertDto dto)
        {
            using TransactionScope scope = TransactionScopeHelper.GetInstance();
            Validate(dto.Name);
            var vehicleCategory = new VehicleCategory(dto.Name);
            await vehicleCategoryRepository.Insert(vehicleCategory).ConfigureAwait(false);
            scope.Complete();
        }

        public async Task Deactivate(long Id)
        {
            using TransactionScope scope = TransactionScopeHelper.GetInstance();
            var vehicleCategory = await vehicleCategoryRepository.GetById(Id).ConfigureAwait(false) ?? throw new VehicleCategoryNotFoundException();
            ValidateActiveVehicles(vehicleCategory);
            vehicleCategory.Deactivate();
            scope.Complete();
        }

        private static void ValidateActiveVehicles(VehicleCategory vehicleCategory)
        {
            var anyActiveVehicle = vehicleCategory.Vehicles.Any(a => a.IsActive());
            if (anyActiveVehicle)
            {
                throw new VehicleCategoryContainsActiveVehicleException();
            }
        }

        public async Task Update(VehicleCategoryUpdateDto dto)
        {
            using TransactionScope scope = TransactionScopeHelper.GetInstance();
            var vehicleCategory = await vehicleCategoryRepository.GetById(dto.Id) ?? throw new VehicleCategoryNotFoundException();
            Validate(dto.Name);
            vehicleCategory.UpdateName(dto.Name);
            await vehicleCategoryRepository.Update(vehicleCategory);
            scope.Complete();
        }

        private async void Validate(string name)
        {
            var vehicleCategory = await vehicleCategoryRepository.GetByName(name).ConfigureAwait(false);
            if (vehicleCategory != null)
            {
                throw new VehicleCategoryAlreadyExistException();
            }
        }
    }
}
