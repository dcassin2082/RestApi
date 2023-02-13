using Microsoft.EntityFrameworkCore;
using RestApi.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestApi.Data.Repository.Common
{
    public abstract class RepositoryBase<T> : IDisposable where T : class
    {
        protected internal readonly TestDbContext? _dbContext;
        protected internal readonly DbSet<T>? _dbSet;

        protected RepositoryBase(TestDbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext?.Set<T>();
        }

        public void Dispose()
        {
            _dbContext?.Dispose();
        }
    }
}
