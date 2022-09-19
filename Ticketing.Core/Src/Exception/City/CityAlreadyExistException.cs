using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticketing.Core.Exception.City
{
    public class CityAlreadyExistException : SystemException
    {
        public CityAlreadyExistException(string? message="City Already Exist") : base(message)
        {
        }
    }
}
