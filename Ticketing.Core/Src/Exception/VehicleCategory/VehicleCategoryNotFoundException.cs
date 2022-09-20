using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticketing.Core.Exception.VehicleCategory
{
    public class VehicleCategoryNotFoundException : SystemException
    {
        public VehicleCategoryNotFoundException(string? message="Vehicle Category Not found exception") : base(message)
        {
        }
    }
}
