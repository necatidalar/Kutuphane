using Core.Entity;
using Core.Utility.Results;

namespace Core.Interfaces
{
    public interface IDalVeriOlusturma<T> : IGenelDalOperasyonlari
        where T : class, IEntity, new()
    {
        IResult Add(T entity);
    }
}
