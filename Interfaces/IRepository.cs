using System;

namespace Sailsafe.Interfaces
{
    public interface IRepository
    {
        void Initialise();
        void Dispose();
        bool Save(params object[] args);
        bool Remove();
        bool Edit();
        string ReadOne();
        string ReadAll();
    }
}
