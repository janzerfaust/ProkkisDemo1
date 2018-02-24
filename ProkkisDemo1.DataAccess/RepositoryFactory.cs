using System;
using System.Collections.Generic;
using System.Text;

namespace ProkkisDemo1.DataAccess
{
    public class RepositoryFactory : IRepositoryFactory
    {
        public TRepository CreateRepository<T, TRepository>() where TRepository : IRepository<T>
        {
            return (TRepository)Activator.CreateInstance(typeof(TRepository));
        }
    }
}
