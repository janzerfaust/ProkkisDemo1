using System;
using System.Collections.Generic;

namespace ProkkisDemo1.DataAccess
{
    public interface IRepository<T>
    {
        List<T> GetList();
    }
}
