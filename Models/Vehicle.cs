using System.IO;
using SailSafe.Models;

namespace SailSafe.Models
{
    public class Vehicle
    {
        protected int vehicleLength;

        public string License { get; set; }
        public string Type { get; set; }
        public virtual int Length { get; set; }

        public Vehicle()
        {
        }

        public Vehicle(string license)
        {
            this.License = license;
        }

        public Vehicle(string license, string type)
        {
            this.License = license;
            this.Type = type;
        }

        //public override string ToString()
        //{
        //    if (string.Equals(this.Type, VehicleType.Car))
        //    {
        //        this.Type = VehicleType.Car;
        //        return this.Type;
        //    }

        //    if (string.Equals(this.Type, VehicleType.Van))
        //    {
        //        this.Type = VehicleType.Van;
        //        return this.Type;
        //    }

        //    if (string.Equals(this.Type, VehicleType.Large))
        //    {
        //        this.Type = VehicleType.Large;
        //        return this.Type;
        //    }

        //    this.Type = "Unspecified";
        //    return this.Type;
        //}
    }
}
