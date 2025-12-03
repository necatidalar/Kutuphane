namespace Core.IRepository
{
    public interface IRepository<T> where T : class
    {
        List<T> GetAll();
        List<T> GetByFilter(System.Linq.Expressions.Expression<Func<T, bool>>? predicate = null);
        T GetById(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(int id);
    }
}
