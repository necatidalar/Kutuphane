
using Core.Entity;
using Core.Utility.Results;
using System.Linq.Expressions;

namespace Core.Interfaces
{
    public interface IDalVeriCekme<T> : IGenelDalOperasyonlari
         where T : class, IEntity, new()
    {
        IDataResult<List<T>> GetListByFilter(Expression<Func<T, bool>>? predicate = null);
        IDataResult<T?> GetByFilter(Expression<Func<T, bool>>? predicate = null);
    }
}
