using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticketing.Core.Exception.VehicleCategory
{
    public class VehicleCategoryAlreadyExistException : SystemException
    {
        public VehicleCategoryAlreadyExistException(string? message="Vehicle category already exist") : base(message)
        {
        }
    }
}
