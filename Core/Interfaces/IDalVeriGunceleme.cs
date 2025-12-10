using Core.Entity;
using Core.Utility.Results;

namespace Core.Interfaces
{
    public interface IDalVeriGunceleme<T> : IGenelDalOperasyonlari
         where T : class, IEntity, new()
    {
        IResult Update(T entity);
    }
}
