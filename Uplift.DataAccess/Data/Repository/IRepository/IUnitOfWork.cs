﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Uplift.DataAccess.Data.Repository.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        ICategoryRepository Category { get; }

        // Section 05 Assignment-03 Solution 
        IFrequencyRepository Frequency { get; }

        IServiceRepository Service { get; }

        IOrderHeaderRepository OrderHeader { get; }

        IOrderDetailsRepository OrderDetails { get; }

        IUserRepository User { get; }
        void Save();
    }
}
