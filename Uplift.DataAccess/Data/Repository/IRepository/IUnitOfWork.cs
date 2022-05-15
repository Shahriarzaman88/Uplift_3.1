using System;
using System.Collections.Generic;
using System.Text;

namespace Uplift.DataAccess.Data.Repository.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        ICategoryRepository Category { get; }

        // Assignment-03 Solution 
        IFrequencyRepository Frequency { get; }
        void Save();
    }
}
