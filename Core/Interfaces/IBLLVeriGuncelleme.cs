

using Core.Entity;
using Core.Utility.Results;

namespace Core.Interfaces
{
    public interface IBLLVeriGuncelleme<TEntity> : IGenelBLLOperasyonlari
        where TEntity : class, IEntity, new()
    {
        IResult UpdateService(TEntity entity);
    }
}
