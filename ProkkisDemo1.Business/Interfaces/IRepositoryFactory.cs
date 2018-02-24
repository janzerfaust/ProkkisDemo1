namespace ProkkisDemo1.DataAccess.Interfaces
{
    // TODO: refactor to bl layer
    public interface IRepositoryFactory
    {
        TRepository CreateRepository<T, TRepository>() where TRepository : IRepository<T>;
    }
}
