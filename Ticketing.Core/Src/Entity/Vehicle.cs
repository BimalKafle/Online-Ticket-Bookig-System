using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticketing.Core.Entity
{
    public class Vehicle
    {
        public static readonly string Active = "Active";
        public static readonly string Inactive = "Inactive";
        public Vehicle(string vehicle_Number, VehicleCategory vehicle_Category, string vehicle_Name)
        {

            Vehicle_Number = vehicle_Number;

            Vehicle_Category = vehicle_Category;
            Vehicle_Name = vehicle_Name;
            Vehicle_Status = Active;
        }

        protected Vehicle() { }
        public virtual int Id { get; protected set; }
        public virtual string Vehicle_Number { get; protected set; }
        public virtual int Vehicle_CategoryId { get; protected set; }
        public virtual VehicleCategory Vehicle_Category { get; protected set; }
        public virtual string Vehicle_Name { get; protected set; }
        public virtual string Vehicle_Status { get; protected set; }

        public void Activate()
        {
            Vehicle_Status = Active;
        }
        public void Deactivate()
        {
            Vehicle_Status = Inactive;
        }
        public Boolean IsActive()
        {
            return Vehicle_Status == Active;
        }
    }
}
