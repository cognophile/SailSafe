using System;
using System.Collections.Generic;
using SailSafe.Models;

namespace SailSafe.Intermediaries
{
    public class BookingManager
    {
        private Booking booking;

        public BookingManager(string name, string license)
        {
            this.booking = new Booking(name, license);
        }

        public BookingManager(string name, string license, string timeAndDirection, string vehicleType)
        {
            this.booking = new Booking(name, license, timeAndDirection, vehicleType);
        }

        public bool DoCreate()
        {
            if (this.booking != null) {
               return this.booking.Create();
            }

            return false;
        }

        public bool DoDelete()
        {
            if (this.booking != null) {
                return this.booking.Delete();
            }

            return false;
        }

        public List<string> DoSearch()
        {
            if (this.booking != null)
            {
                return this.booking.Search();
            }

            return new List<string>();
        }
    }
}
