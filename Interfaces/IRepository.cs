using System;

namespace Sailsafe.Interfaces
{
    public interface IRepository
    {
        void Initialise();
        void Dispose();
        bool Save(DateTime dateTime, string name, string license, DateTime time, string vehicleType);
        bool Remove();
        bool Edit();
        string ReadOne();
        string ReadAll();
    }
}
