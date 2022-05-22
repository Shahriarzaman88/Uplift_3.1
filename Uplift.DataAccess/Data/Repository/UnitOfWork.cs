using System;
using System.Collections.Generic;
using System.Text;
using Uplift.DataAccess.Data.Repository.IRepository;
using Uplift_3._1.DataAccess.Data;

namespace Uplift.DataAccess.Data.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;
        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Category = new CategoryRepository(_db);

            // Assignment-03 solution added Frequency variable 

            Frequency = new FrequencyRepository(_db);

            Service = new ServiceRepository(_db);

            OrderHeader = new OrderHeaderRepository(_db);

            OrderDetails = new OrderDetailsRepository(_db);

            User = new UserRepository(_db);

        }
        public ICategoryRepository Category { get; private set; }


        // Section 05 Assignment-03 solution 
        public IFrequencyRepository Frequency { get; private set; } 

        public IServiceRepository Service { get; private set; }

        public IOrderHeaderRepository OrderHeader { get; private set; }

        public IOrderDetailsRepository OrderDetails { get; private set; }

        public IUserRepository User { get; private set; }

        public void Dispose()
        {
            _db.Dispose();
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
