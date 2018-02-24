using ProkkisDemo1.DataAccess.Interfaces;
using System;

namespace ProkkisDemo1.DataAccess
{
    // TODO: refactor to bl layer
    public class RepositoryFactory : IRepositoryFactory
    {
        public TRepository CreateRepository<T, TRepository>() where TRepository : IRepository<T>
        {
            return (TRepository)Activator.CreateInstance(typeof(TRepository));
        }
    }
}
