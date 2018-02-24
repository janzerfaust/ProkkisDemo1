using System;
using System.Collections.Generic;
using System.Text;

namespace ProkkisDemo1.DataAccess.Interfaces
{
    // TODO: refactor to bl layer
    public interface IRepositoryFactory
    {
        TRepository CreateRepository<T, TRepository>() where TRepository : IRepository<T>;
    }
}
