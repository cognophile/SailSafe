using System;
using System.IO;
using System.Collections.Generic;

using Sailsafe.Interfaces;
using System.Linq;
using SailSafe.Utilities;

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

        public string ReadOne()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Remove the specified args.
        /// </summary>
        /// <returns>Boolean: success</returns>
        /// <param name="args">0: Booking</param>
        public bool Remove(params object[] args)
        {
            Booking booking = (Booking)args[0];

            List<string> bookings = this.ReadAll();
            var filteredBookings = bookings.Where(line => !line.Contains(booking.GetCustomer()) && !line.Contains(booking.GetVehicleLicense()));

            if (filteredBookings != null)
            {
                return this.Overwrite(filteredBookings);
            }

            return false;
        }

        /// <summary>
        /// Save the specified args.
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

        public void Initialise()
        {
            outputPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            outputFile = Path.Combine(outputPath, "SailSafeLog.txt");
        }

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

        private bool Overwrite(IEnumerable<string> bookings)
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
    }
}
