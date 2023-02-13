using RestApi.Data.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestApi.Services.Services.Common
{
    public abstract class ServicesBase<T> where T : class
    {
        protected readonly IRepository<T> _repo;

        protected ServicesBase(IRepository<T> repo)
        {
            _repo = repo;
        }
    }
}
