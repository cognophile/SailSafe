using System;
using Sailsafe.Interfaces;
namespace SailSafe.Interfaces
{
    public abstract class IBookingRepository : IRepository
    {
        public abstract void Initialise();
        public abstract void Dispose();
        public abstract bool Save(DateTime dateTime, string name, string license, DateTime time, string vehicleType);
        public abstract bool Remove();
        public abstract bool Edit();
        public abstract string ReadOne();
        public abstract string ReadAll();
    }
}
