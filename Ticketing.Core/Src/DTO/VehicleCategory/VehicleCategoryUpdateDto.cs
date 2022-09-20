using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticketing.Core.DTO.VehicleCategory
{
    public class VehicleCategoryUpdateDto : VehicleCategoryInsertDto
    {
        public long Id { get; protected set; }
        public VehicleCategoryUpdateDto(long id,string name) : base(name)
        {
            Id = id;
        }
    }
}
