using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticketing.Core.Exception.City
{
    public class CityNotFoundException : SystemException
    {
        public CityNotFoundException(string? message ="City Not Found Exception") : base(message)
        {
        }
    }
}
