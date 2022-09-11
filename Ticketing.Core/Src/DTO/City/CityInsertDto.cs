using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticketing.Core.DTO.City
{
    public class CityInsertDto
    {
        public CityInsertDto(string name)
        {
            Name = name;
        }
        public string Name
        {
            get; protected set;
        }
}
