

using Core.Entity;
using Core.Utility.Results;

namespace Core.Interfaces
{
    public interface IDalVeriSilme<T> : IGenelDalOperasyonlari
         where T : class, IEntity, new()
    {
        IResult Delete(T entity);
    }
}
