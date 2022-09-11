using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticketing.Core.DTO.City
{
    public class CityUpdateDto:CityInsertDto
    {
        public long Id { get; protected set; }
        public CityUpdateDto(long id, string name) : base(name)
        {
            Id = id;
        }
    }
}
