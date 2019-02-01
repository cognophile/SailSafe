
using System;
using SailSafe.Classes;

namespace SailSafe
{
    public class Booking
    {
        private readonly BookingRepository repository;

        public int Time { get; set; }
        public string Name { get; set; }
        public string License { get; set; }
        public string Direction { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name"> The Full Name of the Guest to be Booked </param>
        /// <param name="license"> The License Plate of the Guest's Vehicle </param>
        /// <param name="time"> The Sailing Time the Guest will be booked for </param>
        /// <param name="direction"></param>
        public Booking(string name, string license, int time, string direction)
        {
            this.repository = new BookingRepository();

            Name = name;
            License = license;
            Time = time;
            Direction = direction;
        }

        public bool Write()
        {
            return this.repository.Save();
        }
    }
}
