using System;
using System.Collections.Generic;

namespace Sailsafe.Interfaces
{
    public interface IRepository
    {
        void Initialise();
        void Dispose();
        bool Save(params object[] args);
        bool Remove(params object[] args);
        bool Edit();
        string ReadOne();
        List<string> ReadAll();
    }
}
