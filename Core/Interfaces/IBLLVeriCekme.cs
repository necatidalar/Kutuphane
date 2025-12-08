

using Core.Entity;
using Core.Utility.Results;
using System.Linq.Expressions;

namespace Core.Interfaces
{
    public interface IBLLVeriCekme<TEntity> : IGenelBLLOperasyonlari
        where TEntity : class, IEntity, new()
    {
        IDataResult<List<TEntity>> GetListByFilterService(Expression<Func<TEntity, bool>>? predicate = null);
        IDataResult<TEntity> GetByFilterService(Expression<Func<TEntity, bool>>? predicate = null);
    }
}
