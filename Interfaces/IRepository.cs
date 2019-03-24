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
        List<string> ReadOne(params object[] args);
        List<string> ReadAll();
    }
}
