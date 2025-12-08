using Core.Utility.Results;
using System.Linq.Expressions;

namespace Core.Interfaces
{
    public interface IRepository<T> where T : class
    {
        IDataResult<List<T>> GetListByFilter(Expression<Func<T, bool>>? predicate = null);
        IDataResult<T?> GetByFilter(Expression<Func<T, bool>>? predicate = null);
        IResult Add(T entity);
        IResult Update(T entity);
        IResult Delete(T entity);
    }
}
