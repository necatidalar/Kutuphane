

using Core.Entity;
using Core.Utility.Results;

namespace Core.Interfaces
{
    public interface IBLLVeriSilme<TEntity> : IGenelBLLOperasyonlari
        where TEntity : class, IEntity, new()
    {
        IResult DeleteService(TEntity entity);
    }
}
