using System;
using SailSafe.Intermediaries;
using System.Runtime.CompilerServices;
using System.Collections.Generic;

namespace SailSafe.Models
{
    public class Booking
    {
        private BookingRepository repository;
        private Sailing sailing;
        private Vehicle vehicle;

        public DateTime BookingDate { get; set; } = DateTime.Now;
        public string Name { get; set; }

        public Booking(string name, string license)
        {
            this.Initialise();
            this.Name = name;

            this.vehicle = new Vehicle(license);
        }

        public Booking(string name, string license, string timeAndDirection, string vehicleType)
        {
            this.Initialise();
            this.Name = name;

            this.sailing = new Sailing(timeAndDirection);
            this.vehicle = new Vehicle(license, vehicleType);
        }

        private void Initialise()
        {
            this.repository = new BookingRepository();
        }

        public bool Create()
        {
            return this.repository.Save(this, this.vehicle, this.sailing);
        }

        public bool Delete()
        {
            return this.repository.Remove(this);
        }

        public List<string> Search()
        {
            return this.repository.ReadOne(this);
        }

        public string GetCustomer()
        {
            return this.Name;
        }

        public string GetVehicleLicense()
        {
            return this.vehicle.License;
        }
    }
}
