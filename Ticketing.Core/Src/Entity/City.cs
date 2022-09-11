using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticketing.Core.Entity
{
    public class City
    {
        public static readonly string Active = "Active";
        public static readonly string Inactive = "Inactive";

        protected City()
        {

        }

        public City(string name)
        {
            Name = name;
            Status = Active;
        }

        public virtual int Id { get; protected set; }
        public virtual string Name { get; protected set; }
        public virtual string Status { get; protected set; }

        public void Activate()
        {
            Status = Active;
        }
        public void Deactivate()
        {
            Status = Inactive;
        }
        public Boolean IsActive()
        {
            return Status == Active;
        }
    }
}
