using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

using Sailsafe.Interfaces;
using SailSafe.Utilities;
using SailSafe.Models;

namespace SailSafe.Intermediaries
{
    public class BookingRepository : IRepository
    {
        private static string outputPath;
        private static string outputFile;
        private static StreamWriter outputStream;
        private static StreamReader inputStream;

        public BookingRepository()
        {
            this.Initialise();
        }

        public bool Edit()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Reads all bookings
        /// </summary>
        /// <returns>List of all bookings as strings</returns>
        public List<string> ReadAll()
        {
            List<string> lines = new List<string>();

            using (inputStream = new StreamReader(new FileStream(outputFile, FileMode.Open, FileAccess.Read)))
            {
                while (!inputStream.EndOfStream)
                {
                    var line = inputStream.ReadLine();
                    lines.Add(line);
                }

                this.Dispose();
            }

            return lines;
        }

        /// <summary>
        /// Search for a single booking
        /// </summary>
        /// <returns>List of bookings as strings</returns>
        /// <param name="args">Arguments.</param>
        public List<string> ReadOne(params object[] args)
        {
            Booking booking = (Booking)args[0];
            var filteredBookings = this.Search(booking);

            if (filteredBookings != null)
            {
                return filteredBookings;
            }

            return new List<string>(); 
        }

        /// <summary>
        /// Remove the specified Booking
        /// </summary>
        /// <returns>Boolean: success</returns>
        /// <param name="args">0: Booking</param>
        public bool Remove(params object[] args)
        {
            Booking booking = (Booking)args[0];
            var filteredBookings = this.Search(booking);

            if (filteredBookings != null)
            {
                return this.Overwrite(filteredBookings);
            }

            return false;
        }

        /// <summary>
        /// Save the specified Booking
        /// </summary>
        /// <returns>Boolean: success</returns>
        /// <param name="args">0: Booking, !: Vehicle, @: Sailing</param>
        public bool Save(params object[] args)
        {
            Booking booking = (Booking)args[0];
            Vehicle vehicle = (Vehicle)args[1];
            Sailing sailing = (Sailing)args[2];

            if (!Directory.Exists(outputFile) || new FileInfo(outputFile).Length == 0) {
                return this.Append(booking.BookingDate, booking.Name, vehicle.License, sailing.Time, vehicle.Type);
            }
            else {
                return this.Create(booking.BookingDate, booking.Name, vehicle.License, sailing.Time, vehicle.Type);
            }
        }

        /// <summary>
        /// Initialise the persistance location and access
        /// </summary>
        public void Initialise()
        {
            outputPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            outputFile = Path.Combine(outputPath, "SailSafeLog.txt");
        }

        /// <summary>
        /// Releases all resource used by the <see cref="T:SailSafe.Intermediaries.BookingRepository"/> object.
        /// </summary>
        /// <remarks>Call <see cref="Dispose"/> when you are finished using the
        /// <see cref="T:SailSafe.Intermediaries.BookingRepository"/>. The <see cref="Dispose"/> method leaves the
        /// <see cref="T:SailSafe.Intermediaries.BookingRepository"/> in an unusable state. After calling
        /// <see cref="Dispose"/>, you must release all references to the
        /// <see cref="T:SailSafe.Intermediaries.BookingRepository"/> so the garbage collector can reclaim the memory
        /// that the <see cref="T:SailSafe.Intermediaries.BookingRepository"/> was occupying.</remarks>
        public void Dispose()
        {
            if (inputStream != null) { inputStream.Close(); }
            if (outputStream != null) { outputStream.Close(); }
        }

        private bool Append(DateTime dateTime, string name, string license, DateTime time, string vehicleType)
        {
            using (outputStream = File.AppendText(outputFile))
            {
                string line = string.Join(", ", dateTime.ToShortDateString(), name, license, time.ToShortTimeString(), vehicleType);
                outputStream.WriteLine(line);

                this.Dispose();
            }

            return true;
        }

        private bool Create(DateTime dateTime, string name, string license, DateTime time, string vehicleType)
        {
            using (outputStream = new StreamWriter(new FileStream(outputFile, FileMode.OpenOrCreate, FileAccess.ReadWrite)))
            {
                string line = string.Join(", ", dateTime.ToShortDateString(), name, license, time.ToShortTimeString(), vehicleType);
                outputStream.WriteLine(line);

                this.Dispose();
            }

            return true;
        }

        private bool Overwrite(ICollection<string> bookings)
        {
            using (outputStream = new StreamWriter(new FileStream(outputFile, FileMode.Create, FileAccess.ReadWrite)))
            {
                foreach (string line in bookings)
                {
                    outputStream.WriteLine(line);
                }

                this.Dispose();
            }

            return true;
        }

        private List<string> Search(Booking booking)
        {
            List<string> bookings = this.ReadAll();
            return bookings.Where(line => !line.Contains(booking.GetCustomer()) && !line.Contains(booking.GetVehicleLicense())).ToList();
        }
    }
}
