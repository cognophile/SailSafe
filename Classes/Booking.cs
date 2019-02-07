
using System;
using SailSafe.Classes;
using System.IO;

namespace SailSafe
{
    public class Booking
    {
        private BookingRepository repository;
        private Sailing sailing;
        private Vehicle vehicle;

        public DateTime BookingDate { get; set; } = DateTime.Now;
        public string Name { get; set; }

        public Booking(string name, string license, string timeAndDirection, string vehicleType)
        {
            this.Initialise();
            this.Name = name;

            this.sailing = new Sailing(timeAndDirection);
            this.vehicle = new Vehicle(license, vehicleType);
        }

        public bool Create()
        {
            return this.repository.Save(this.BookingDate, this.Name, this.vehicle.License, this.sailing.Time, this.vehicle.Type.ToString());
        }

        private void Initialise()
        {
            this.repository = new BookingRepository();
        }
    }
}
