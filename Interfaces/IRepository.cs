using System;

namespace Sailsafe.Interfaces
{
    public interface IRepository
    {
        bool Save();
        bool Remove();
        bool Edit();
        string ReadOne();
        string ReadAll();
    }
}
