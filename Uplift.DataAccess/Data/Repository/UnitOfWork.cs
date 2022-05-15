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

        }
        public ICategoryRepository Category { get; private set; }


        // Section 05 Assignment-03 solution 
        public IFrequencyRepository Frequency { get; private set; } 

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
