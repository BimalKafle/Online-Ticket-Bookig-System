using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticketing.Core.Exception.VehicleCategory
{
    public class VehicleCategoryContainsActiveVehicleException : SystemException
    {
        public VehicleCategoryContainsActiveVehicleException(string? message="Vehcile category contains active vehicle") : base(message)
        {
        }
    }
}
