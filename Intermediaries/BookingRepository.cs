using System;
using System.IO;
using Sailsafe.Interfaces;

namespace SailSafe.Intermediaries
{
    public class BookingRepository : IRepository
    {
        private static string outputPath;
        private static string outputFile;
        private static StreamWriter outputStream;

        public BookingRepository()
        {
            this.Initialise();
        }

        public bool Edit()
        {
            throw new NotImplementedException();
        }

        public string ReadAll()
        {
            throw new NotImplementedException();
        }

        public string ReadOne()
        {
            throw new NotImplementedException();
        }

        public bool Remove()
        {
            throw new NotImplementedException();
        }

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
            outputStream.Close();
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
    }
}
