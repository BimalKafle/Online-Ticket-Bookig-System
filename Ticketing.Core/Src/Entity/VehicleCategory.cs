using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticketing.Core.Entity
{
    public class VehicleCategory
    {
        public static readonly string Active = "Active";
        public static readonly string Inactive = "Inactive";

        protected VehicleCategory()
        {

        }
        public VehicleCategory(string name)
        {
            Category_Name = name;
            Status = Active;
        }
        public virtual int Id { get; protected set; }
        public virtual string Category_Name { get; protected set; }
        public virtual string Status { get; protected set; }

        public virtual ICollection<Vehicle> Vehicles { get; protected set; } = new List<Vehicle>();

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

        public void UpdateName(string Name)
        {
            Category_Name = Name;
        }
    }
}
