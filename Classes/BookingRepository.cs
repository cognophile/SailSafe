using System;
using System.IO;
using Sailsafe.Interfaces;

namespace SailSafe
{
    public class BookingRepository : IRepository
    {
        public readonly static string destinationPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        public static string destinationFile = Path.Combine(destinationPath, "SailSafeLog.txt");

        public BookingRepository()
        {

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

        public bool Save()
        {
            throw new NotImplementedException();
        }
    }
}
