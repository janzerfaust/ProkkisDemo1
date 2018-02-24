using System.Collections.Generic;

namespace ProkkisDemo1.DataAccess.Interfaces
{
    public interface IRepository<T>
    {
        List<T> GetList();
    }
}
